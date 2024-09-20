using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UhlSportDataAccessLayer
{
    public static class ClsMultipleinvoices
    {
        public static DataTable GetAllMultipleInvoices()
        {
            DataTable Result = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "select * from Multi_Sales;";
            SQLiteCommand command = new SQLiteCommand(Query, connection);
            try
            {
                connection.Open();
                SQLiteDataReader Reader = command.ExecuteReader();
                if(Reader.HasRows)
                {
                    Result.Load(Reader);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
            return Result;
        }
        public static BigInteger AddNewInvoice(DateTime dt, float TotalPrice,float IntialPayedPrice,float PriceAfterDiscount)
        {
            long InvoiceID = 0;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "INSERT INTO [Multi_Sales]\r\n           (\r\n           [التاريخ]\r\n           ,[السعر_الاجمالي]\r\n           ,[السعر_المدفوع]\r\n           ,[المبلغ_المستحق])\r\n     VALUES(@dt,@TotalPrice,@IntialPayedPrice,@PriceAfterDiscount);SELECT last_insert_rowid();";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@dt", dt);
            cmd.Parameters.AddWithValue("@IntialPayedPrice", IntialPayedPrice);
            cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);
            cmd.Parameters.AddWithValue("@PriceAfterDiscount", PriceAfterDiscount);


            try
            {
                connection.Open();
                object Value = cmd.ExecuteScalar();
                if(Value!=null&&long.TryParse(Value.ToString(),out long InsertedID))
                {
                    InvoiceID = Convert.ToInt64(Value);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return InvoiceID;
        }
        public static DataTable FindMultiInvoiceById(BigInteger InvoiceID)
        {
            DataTable dt = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "select * from Multi_Sales where رقم_الفاتوره_المدمجه=@InvoiceID;";
            SQLiteCommand command = new SQLiteCommand(Query, connection);
            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool PaymentDues(BigInteger InvoiceID)
        {
            bool IsUpdatedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "UPDATE Multi_Sales SET السعر_المدفوع = السعر_الاجمالي, المبلغ_المستحق = 0 WHERE رقم_الفاتوره_المدمجه = @InvoiceId";
            SQLiteCommand command = new SQLiteCommand(Query, connection);
            command.Parameters.AddWithValue("@InvoiceId", InvoiceID);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if(RowsAffected>0)
                {
                    IsUpdatedSuccessfully = true;
                }
                else
                {
                    IsUpdatedSuccessfully = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return IsUpdatedSuccessfully;
        }
        public static bool Delete(BigInteger InvoiceID)
        {
            bool IsDeletedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "delete from Multi_Sales where رقم_الفاتوره_المدمجه=@InvoiceID;";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if(RowsAffected>0)
                {
                    IsDeletedSuccessfully = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
            return IsDeletedSuccessfully;

        }
        public static DataTable GetAllInvoicesThatHaveDues()
        {
            DataTable dt = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "select * from Multi_Sales where  السعر_المدفوع!=السعر_الاجمالي";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
               
                connection.Close();
            }
            return dt;
        }
        public static bool PayPartOfDues(float AmountWillAdd,BigInteger InvoiceID)
        {
            bool ISUpdatedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "update Multi_Sales set السعر_المدفوع=السعر_المدفوع+@AmountWillAdd,المبلغ_المستحق=المبلغ_المستحق-@AmountWillAdd where رقم_الفاتوره_المدمجه=@InvoiceID";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@AmountWillAdd", AmountWillAdd);
            command.Parameters.AddWithValue("@InvoiceID", InvoiceID.ToString());
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if(RowsAffected>0)
                {
                    ISUpdatedSuccessfully = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }finally
            {
                connection.Close();
            }
            return ISUpdatedSuccessfully;
        }
        public static BigInteger GetTheLastID()
        {
            BigInteger TheLast = 0;

            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "SELECT MAX(CAST(رقم_الفاتوره_المدمجه AS INTEGER)) FROM Multi_Sales;";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            try
            {
                connection.Open();
                object LastID = command.ExecuteScalar();
                if (LastID != null)
                {
                    TheLast = BigInteger.Parse(Convert.ToString(LastID));

                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();

            }
            return TheLast;

        }

    }
}
