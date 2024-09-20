using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Data.SQLite;
namespace UhlSportDataAccessLayer
{
    public static class SingleSales
    {
        public static DataTable GetAllSingleSales()
        {
            DataTable AllSales = new DataTable();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
                {
                    string query = "select * from SingleSales";

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                    adapter.Fill(AllSales);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return AllSales;
        }
        public static DataTable GetAllSales()
        {
            //contain all info fron single sales table and the related  table
            DataTable AllSales = new DataTable();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
                {
                    string query = @"
SELECT 
    (SingleSales.الرقم_الفريد_لعمليه_البيع) AS مسلسل, 
    (Custmors.الاسم_الاول || ' ' || Custmors.الاسم_الاخير) AS اسم_الشاري, 
    Products.اسم_المنتج, 
    SingleSales.الكميه, 
    SingleSales.السعر_المدفوع, 
    SingleSales.الخصم, 
    SingleSales.السعر_بعد_الخصم, 
    (PaymentsStatues.السعر_المتبقي_علي_العميل) AS مستحق,
    PaymentsStatues.حاله_الدفع, 
    SingleSales.التاريخ, 
    Colors.اللون, 
    Sizes.المقاس, 
    (Custmors.رقم_الهاتف) AS هاتف_الشاري,
    CASE 
        WHEN PaymentsStatues.ملاحظات IS NULL THEN 'فارغ' 
        ELSE PaymentsStatues.ملاحظات 
    END AS ملاحظات, 
    PaymentsStatues.الرقم_الفريد_لطريقه_الدفع 
FROM 
    SingleSales
INNER JOIN 
    Products ON SingleSales.رقم_المنتج_الفريد = Products.الرقم_الفريد 
INNER JOIN 
    Sizes ON Products.رقم_المقاس_الفريد = Sizes.الرقم_الفريد 
INNER JOIN 
    Custmors ON SingleSales.رقم_الزبون_الفريد = Custmors.الرقم_الفريد 
INNER JOIN 
    Colors ON Products.رقم_اللون_الفريد = Colors.الرقم_الفريد 
INNER JOIN 
    PaymentsStatues ON SingleSales.رقم_حاله_الدفع_ألفريد = PaymentsStatues.الرقم_الفريد_لطريقه_الدفع";



                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                    adapter.Fill(AllSales);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return AllSales;
                  }
        public static BigInteger AddNewOperation( BigInteger ID,int Quantities, DateTime dateTime, float totalPrice, float initalPayedPrice, BigInteger ProductID, int ClientID, int PaymentStatueID, byte Discount, float PriceAfterDiscount, BigInteger MultipleInvoiceID)
        {
            BigInteger insertedId = 0;

            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = @"
    INSERT INTO [SingleSales]
    (
[الرقم_الفريد_لعمليه_البيع],
        [الكميه],
        [التاريخ],
        [اجمالي_السعر],
        [السعر_المدفوع],
        [رقم_الزبون_الفريد],
        [رقم_المنتج_الفريد],
        [رقم_حاله_الدفع_ألفريد],
        [الخصم],
        [رقم_الفاتوره_المدمجه],
        [السعر_بعد_الخصم]
    )
    VALUES 
    (
@ID,
        @Quantities, 
        @dateTime, 
        @totalPrice, 
        @initalPayedPrice, 
        @ClientID, 
        @ProductID, 
        @PaymentStatueID, 
        @Discount, 
        @MultipleInvoiceID, 
        @PriceAfterDiscount
    ); 
    SELECT last_insert_rowid();";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);

                command.Parameters.AddWithValue("@Quantities", Quantities);
                command.Parameters.AddWithValue("@dateTime", dateTime);
                command.Parameters.AddWithValue("@totalPrice", totalPrice);
                command.Parameters.AddWithValue("@initalPayedPrice", initalPayedPrice);
                command.Parameters.AddWithValue("@ClientID", ClientID);
                command.Parameters.AddWithValue("@ProductID", ProductID);
                command.Parameters.AddWithValue("@PaymentStatueID", PaymentStatueID);
                command.Parameters.AddWithValue("@Discount",Discount);
                command.Parameters.AddWithValue("@PriceAfterDiscount", PriceAfterDiscount);
                command.Parameters.AddWithValue("@MultipleInvoiceID", MultipleInvoiceID);


                try
                {
                    connection.Open();
                    // استخدام ExecuteScalar لاسترجاع القيمة المُدرجة في الجدول
                    object result = command.ExecuteScalar();
                    if (result!=null&&BigInteger.TryParse(result.ToString() ,out BigInteger inserted))
                    {
                        // تحويل القيمة المُسترجعة إلى BigInteger
                        insertedId = BigInteger.Parse(result.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return insertedId;
        }
        public static BigInteger GetTheLastID()
        {
            BigInteger TheLast = 0;
            
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
        string query="  SELECT MAX(CAST(الرقم_الفريد_لعمليه_البيع AS INTEGER)) AS أكبر_رقم_فريد_لعمليه_البيع FROM SingleSales;";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            try
            {
                connection.Open();
                object LastID = command.ExecuteScalar();
                if(LastID!=null)
                {
                    TheLast = BigInteger.Parse(Convert.ToString(LastID));

                }
                
            }catch(Exception ex)
            {
            }
            finally
            {
                connection.Close();

            }
            return TheLast;

        }
        public static DataTable FindInvoiceById(BigInteger InvoiceID)
        {
            DataTable dt = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = @"
    SELECT 
    (SingleSales.الرقم_الفريد_لعمليه_البيع) AS مسلسل, 
    (Custmors.الاسم_الاول || ' ' || Custmors.الاسم_الاخير) AS اسم_الشاري, 
    Products.اسم_المنتج, 
    SingleSales.الكميه, 
    SingleSales.السعر_المدفوع, 
    SingleSales.الخصم, 
    SingleSales.السعر_بعد_الخصم, 
    (PaymentsStatues.السعر_المتبقي_علي_العميل) AS مستحق,
    PaymentsStatues.حاله_الدفع, 
    SingleSales.التاريخ, 
    Colors.اللون, 
    Sizes.المقاس, 
    (Custmors.رقم_الهاتف) AS هاتف_الشاري,
    CASE 
        WHEN PaymentsStatues.ملاحظات IS NULL THEN 'فارغ' 
        ELSE PaymentsStatues.ملاحظات 
    END AS ملاحظات, 
    PaymentsStatues.الرقم_الفريد_لطريقه_الدفع 
FROM 
    SingleSales
INNER JOIN 
    Products ON SingleSales.رقم_المنتج_الفريد = Products.الرقم_الفريد 
INNER JOIN 
    Sizes ON Products.رقم_المقاس_الفريد = Sizes.الرقم_الفريد 
INNER JOIN 
    Custmors ON SingleSales.رقم_الزبون_الفريد = Custmors.الرقم_الفريد 
INNER JOIN 
    Colors ON Products.رقم_اللون_الفريد = Colors.الرقم_الفريد 
INNER JOIN 
    PaymentsStatues ON SingleSales.رقم_حاله_الدفع_ألفريد = PaymentsStatues.الرقم_الفريد_لطريقه_الدفع

            WHERE الرقم_الفريد_لعمليه_البيع =@MultiInvoiceId";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@MultiInvoiceId", InvoiceID.ToString());
            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool PaymentDues(BigInteger MultiInvoiceId)
        {
            bool IsUpdatedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "UPDATE SingleSales SET السعر_المدفوع = السعر_بعد_الخصم WHERE رقم_الفاتوره_المدمجه = @MultiInvoiceId;UPDATE PaymentsStatues\r\nSET السعر_المتبقي_علي_العميل = 0\r\n, حاله_الدفع='تم الاستحقاق'    WHERE الرقم_الفريد_لطريقه_الدفع IN (\r\n    SELECT رقم_حاله_الدفع_ألفريد\r\n    FROM SingleSales\r\n    WHERE رقم_الفاتوره_المدمجه = @MultiInvoiceId\r\n);";


            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@MultiInvoiceId", MultiInvoiceId);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsUpdatedSuccessfully = true;
                }
            
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
            return IsUpdatedSuccessfully;
        }
        public static bool PaymentDuesForSingleSales(BigInteger MultiInvoiceId,BigInteger PaymnetsStatuesID)
        {
            bool isUpdatedSuccessfully = false;

            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                try
                {
                    connection.Open();

                    // أول استعلام لتحديث جدول SingleSales
                    string query1 = @"
            UPDATE SingleSales 
            SET السعر_المدفوع = السعر_بعد_الخصم 
            WHERE الرقم_الفريد_لعمليه_البيع = @MultiInvoiceId;";

                    using (SQLiteCommand command1 = new SQLiteCommand(query1, connection))
                    {
                        command1.Parameters.AddWithValue("@MultiInvoiceId", MultiInvoiceId);

                        int rowsAffected1 = command1.ExecuteNonQuery();
                        if (rowsAffected1 > 0)
                        {
                            isUpdatedSuccessfully = true;
                        }
                        else
                        {
                            MessageBox.Show("No rows affected in SingleSales.");
                            isUpdatedSuccessfully = false;
                        }
                    }

                    // ثاني استعلام لتحديث جدول PaymentsStatues
                    string query2 = @"
            UPDATE PaymentsStatues 
            SET السعر_المتبقي_علي_العميل = 0,
                حاله_الدفع = 'تم الاستحقاق'
            WHERE الرقم_الفريد_لطريقه_الدفع =@PaymnetsStatuesID
               ";

                    using (SQLiteCommand command2 = new SQLiteCommand(query2, connection))
                    {
                        command2.Parameters.AddWithValue("@PaymnetsStatuesID", PaymnetsStatuesID);
                        command2.Parameters.AddWithValue("@MultiInvoiceId", MultiInvoiceId);
                        int rowsAffected2 = command2.ExecuteNonQuery();
                        if (rowsAffected2 > 0)
                        {
                            isUpdatedSuccessfully = true;
                        }
                        else
                        {
                            MessageBox.Show("No rows affected in PaymentsStatues.");
                            isUpdatedSuccessfully = false;
                        }
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
            }

            return isUpdatedSuccessfully;
        }


        public static bool Delete(BigInteger InvoiceID)
        {
            bool IsDeletedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "delete from SingleSales where الرقم_الفريد_لعمليه_البيع=@MultiInvoiceId";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@MultiInvoiceId", InvoiceID.ToString());
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if(RowsAffected>0)
                {
                    IsDeletedSuccessfully = true;

                }
                else
                {
                    IsDeletedSuccessfully = false;
                }



            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            string query = @"
SELECT 
    (SingleSales.الرقم_الفريد_لعمليه_البيع) AS مسلسل, 
    (Custmors.الاسم_الاول || ' ' || Custmors.الاسم_الاخير) AS اسم_الشاري, 
    Products.اسم_المنتج, 
    SingleSales.الكميه, 
    SingleSales.السعر_المدفوع, 
    SingleSales.الخصم, 
    SingleSales.السعر_بعد_الخصم, 
    (PaymentsStatues.السعر_المتبقي_علي_العميل) AS مستحق,
    PaymentsStatues.حاله_الدفع, 
    SingleSales.التاريخ, 
    Colors.اللون, 
    Sizes.المقاس, 
    (Custmors.رقم_الهاتف) AS هاتف_الشاري,
    CASE 
        WHEN PaymentsStatues.ملاحظات IS NULL THEN 'فارغ' 
        ELSE PaymentsStatues.ملاحظات 
    END AS ملاحظات, 
    PaymentsStatues.الرقم_الفريد_لطريقه_الدفع 
FROM 
    SingleSales
INNER JOIN 
    Products ON SingleSales.رقم_المنتج_الفريد = Products.الرقم_الفريد 
INNER JOIN 
    Sizes ON Products.رقم_المقاس_الفريد = Sizes.الرقم_الفريد 
INNER JOIN 
    Custmors ON SingleSales.رقم_الزبون_الفريد = Custmors.الرقم_الفريد 
INNER JOIN 
    Colors ON Products.رقم_اللون_الفريد = Colors.الرقم_الفريد 
INNER JOIN 
    PaymentsStatues ON SingleSales.رقم_حاله_الدفع_ألفريد = PaymentsStatues.الرقم_الفريد_لطريقه_الدفع
    WHERE 
        SingleSales.السعر_المدفوع != SingleSales.السعر_بعد_الخصم;";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool PayPartOfDues(BigInteger Invoice_Id,float PayedPrice,int PaymentStatueId)
        {
            bool IsPayedSuccess = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "update SingleSales set السعر_المدفوع=السعر_المدفوع+@PayedPrice where الرقم_الفريد_لعمليه_البيع=@Invoice_Id;update PaymentsStatues set السعر_المتبقي_علي_العميل=السعر_المتبقي_علي_العميل-@PayedPrice where الرقم_الفريد_لطريقه_الدفع=@PaymentStatueId";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Invoice_Id", Invoice_Id.ToString());
            command.Parameters.AddWithValue("@PayedPrice", PayedPrice);
            command.Parameters.AddWithValue("@PaymentStatueId", PaymentStatueId);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if(RowsAffected>0)
                {
                    IsPayedSuccess = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                connection.Close();
            }
            return IsPayedSuccess;

        }
        public static DataTable GetAllSingleSalesWhichInMultiInvoice(BigInteger Id)
        {
            DataTable AllSales = new DataTable();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
                {
                    string query = @"
SELECT 
    (SingleSales.الرقم_الفريد_لعمليه_البيع) AS مسلسل, 
    (Custmors.الاسم_الاول || ' ' || Custmors.الاسم_الاخير) AS اسم_الشاري, 
    Products.اسم_المنتج, 
    SingleSales.الكميه, 
    SingleSales.السعر_المدفوع, 
    SingleSales.الخصم, 
    SingleSales.السعر_بعد_الخصم, 
    (PaymentsStatues.السعر_المتبقي_علي_العميل) AS مستحق,
    PaymentsStatues.حاله_الدفع, 
    SingleSales.التاريخ, 
    Colors.اللون, 
    Sizes.المقاس, 
    (Custmors.رقم_الهاتف) AS هاتف_الشاري,
    CASE 
        WHEN PaymentsStatues.ملاحظات IS NULL THEN 'فارغ' 
        ELSE PaymentsStatues.ملاحظات 
    END AS ملاحظات, 
    PaymentsStatues.الرقم_الفريد_لطريقه_الدفع 
FROM 
    SingleSales
INNER JOIN 
    Products ON SingleSales.رقم_المنتج_الفريد = Products.الرقم_الفريد 
INNER JOIN 
    Sizes ON Products.رقم_المقاس_الفريد = Sizes.الرقم_الفريد 
INNER JOIN 
    Custmors ON SingleSales.رقم_الزبون_الفريد = Custmors.الرقم_الفريد 
INNER JOIN 
    Colors ON Products.رقم_اللون_الفريد = Colors.الرقم_الفريد 
INNER JOIN 
    PaymentsStatues ON SingleSales.رقم_حاله_الدفع_ألفريد = PaymentsStatues.الرقم_الفريد_لطريقه_الدفع
                    WHERE 
                                SingleSales.رقم_الفاتوره_المدمجه = @Id";

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Id", Id.ToString());

                    adapter.Fill(AllSales);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return AllSales;
        }
  

    }
}

