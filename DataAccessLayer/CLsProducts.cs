using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.Numerics;
using System.Data.SQLite;

namespace UhlSportDataAccessLayer
{
    public static class CLsProducts
    {
        public static DataTable GetAllProductsInfo()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
                {
                    connection.Open();
                    string query = "SELECT  (Products.الرقم_الفريد)As مسلسل, " +
                                   "Products.اسم_المنتج, " +
                                   "Products.الكميه, " +
                                   "Products.تاريخ_وقت_الشراء, " +
                                   "Products.سعر_الشراء_للوحده, " +
                                   "Products.سعر_البيع_للوحده, " +
                                   "Colors.اللون, " +
                                   "Sizes.المقاس, " +
                                   "Products.الصوره_الخاصه_بالمنتج " +
                                   "FROM Products " +
                                   "INNER JOIN Colors ON Products.رقم_اللون_الفريد = Colors.الرقم_الفريد " +
                                   "INNER JOIN Sizes ON Products.رقم_المقاس_الفريد = Sizes.الرقم_الفريد;";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    SQLiteDataReader reader = command.ExecuteReader();

                    // Add columns to DataTable
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dt.Columns.Add(reader.GetName(i));
                    }

                    // Read data from SQLiteDataReader and fill DataTable
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader[i];
                        }
                        dt.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }
        public static void GetProductInfoByID(BigInteger ID, ref string ProductName, ref float buyingPrice, ref float SellingPrice, ref int ColorId, ref int SizeId, ref int Quantity, ref string ImagePath)
        {
            SQLiteConnection Connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "select * from Products where الرقم_الفريد=@ID";
            SQLiteCommand Command = new SQLiteCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID",ID);
            try
            {
                Connection.Open();
                SQLiteDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    ProductName = (string)Reader["اسم_المنتج"];
                    buyingPrice = float.Parse(Reader["سعر_الشراء_للوحده"].ToString());
                    SellingPrice = float.Parse(Reader["سعر_البيع_للوحده"].ToString());
                    ColorId = (int)Reader["رقم_اللون_الفريد"];
                    SizeId = (int)Reader["رقم_المقاس_الفريد"];
                    Quantity = (int)Reader["الكميه"];
                    if(Reader["الصوره_الخاصه_بالمنتج"]!=DBNull.Value)
                    {
                        ImagePath = (string)Reader["الصوره_الخاصه_بالمنتج"];

                    }
                    else
                    {
                        ImagePath = "";

                    }
                    Reader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            finally
            {
                Connection.Close();
            }
        }
        public static bool AddNewProduct( string ProductName, DateTime dateAndTime, float buyingPrice, float SellingPrice, short Color_ID, short Size_ID, string ImagePath, float profitAfterSellAll, int Quantities)
        {
            bool IsAdded = false;
        

            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "INSERT INTO [Products]\r\n           (\r\n           [اسم_المنتج]\r\n           ,[تاريخ_وقت_الشراء]\r\n           ,[سعر_الشراء_للوحده]\r\n           ,[سعر_البيع_للوحده]\r\n           ,[رقم_اللون_الفريد]\r\n           ,[رقم_المقاس_الفريد]\r\n           ,[الصوره_الخاصه_بالمنتج]\r\n           ,[الربح_بعد_البيع]\r\n           ,[الكميه])\r\n     VALUES ( @ProductName, @dateAndTime, @buyingPrice, @SellingPrice, @Color_ID, @Size_ID, @ImagePath, @profitAfterSellAll, @Quantities);";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    command.Parameters.AddWithValue("@dateAndTime", dateAndTime); // DateTime to float
                    command.Parameters.AddWithValue("@buyingPrice", buyingPrice);
                    command.Parameters.AddWithValue("@SellingPrice", SellingPrice);
                    command.Parameters.AddWithValue("@Color_ID", Color_ID);
                    command.Parameters.AddWithValue("@Size_ID", Size_ID);
                    command.Parameters.AddWithValue("@ImagePath", !string.IsNullOrEmpty(ImagePath) ? (object)ImagePath : DBNull.Value);
                    command.Parameters.AddWithValue("@profitAfterSellAll", profitAfterSellAll);
                    command.Parameters.AddWithValue("@Quantities", Quantities);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if(rowsAffected>0)
                        {
                            IsAdded = true;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }

            return IsAdded;
        }

        public static bool Update(BigInteger ID, int Quantities,string Name ,DateTime dateAndTime, float buyingPrice, float SellingPrice, int Color_ID, int Size_ID, string ImagePath, float profitAfterSellAll)
        {
            bool IsUpdatedSuccessfully = false;
            SQLiteConnection Connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "update Products set    الكميه=@Quantities,تاريخ_وقت_الشراء=@dateAndTime,سعر_الشراء_للوحده=@buyingPrice,سعر_البيع_للوحده=@SellingPrice,رقم_اللون_الفريد=@Color_ID,رقم_المقاس_الفريد=@Size_ID,الصوره_الخاصه_بالمنتج=@ImagePath,الربح_بعد_البيع=@profitAfterSellAll,اسم_المنتج=@Name   where الرقم_الفريد=@ID";
            SQLiteCommand Command = new SQLiteCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Name", Name);

            Command.Parameters.AddWithValue("@Quantities", Quantities);
            Command.Parameters.AddWithValue("@dateAndTime", dateAndTime);
            Command.Parameters.AddWithValue("@buyingPrice", buyingPrice);
            Command.Parameters.AddWithValue("@SellingPrice", SellingPrice);
            Command.Parameters.AddWithValue("@Color_ID", Color_ID);

            Command.Parameters.AddWithValue("@Size_ID", Size_ID);
            if(ImagePath=="")
            {
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            Command.Parameters.AddWithValue("@profitAfterSellAll", profitAfterSellAll);
            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsUpdatedSuccessfully = true;
                    Connection.Close();
                }
                else
                {
                    IsUpdatedSuccessfully = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.Close();
            }
            return IsUpdatedSuccessfully;
        }
        public static bool UpdateQuantity(BigInteger ID, int Quantities)
        {
            bool IsUpdatedSuccessfully = false;
            SQLiteConnection Connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "update Products set الكميه=@Quantities ,الربح_بعد_البيع=@Quantities*سعر_البيع_للوحده  where الرقم_الفريد=@ID";
            SQLiteCommand Command = new SQLiteCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID.ToString());
         
            Command.Parameters.AddWithValue("@Quantities", Quantities);

            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsUpdatedSuccessfully = true;
                    Connection.Close();
                }
                else
                {
                    IsUpdatedSuccessfully = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.Close();
            }
            return IsUpdatedSuccessfully;
         }
        public static bool Delete(BigInteger ID)
        {
            bool 
                IsDeletedSuccessfully = false;
            SQLiteConnection Connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "delete from Products where الرقم_الفريد=@ID";
            SQLiteCommand cmd = new SQLiteCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@ID", ID.ToString());
            try
            {
                Connection.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsDeletedSuccessfully = true;
                }
                else
                {
                    IsDeletedSuccessfully = false;
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                IsDeletedSuccessfully = false;
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                Connection.Close();
            }
            return IsDeletedSuccessfully;
        }
        public static DataTable FindByProductThatNameStartWithName(string ProductNamePrefix)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "SELECT  (Products.الرقم_الفريد)As مسلسل, " +
                                   "Products.اسم_المنتج, " +
                                   "Products.الكميه, " +
                                   "Products.تاريخ_وقت_الشراء, " +
                                   "Products.سعر_الشراء_للوحده, " +
                                   "Products.سعر_البيع_للوحده, " +
                                   "Colors.اللون, " +
                                   "Sizes.المقاس, " +
                                   "Products.الصوره_الخاصه_بالمنتج " +
                                   "FROM Products " +
                                   "INNER JOIN Colors ON Products.رقم_اللون_الفريد = Colors.الرقم_الفريد " +
                                   "INNER JOIN Sizes ON Products.رقم_المقاس_الفريد = Sizes.الرقم_الفريد WHERE اسم_المنتج LIKE @ProductNamePrefix || '%';";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@ProductNamePrefix", ProductNamePrefix);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return dt;
        }

        public static BigInteger GetLastID()
        {
            BigInteger Last_ID =0;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "SELECT MAX(CAST(الرقم_الفريد AS bigint)) FROM Products;";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            try
            {
                connection.Open();
                object value = command.ExecuteScalar();
                if (value != DBNull.Value)
                {
                    Last_ID =BigInteger.Parse(value.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
                return Last_ID = 0;
            }
            finally
            {
                connection.Close();
            }
            return Last_ID;
        }
        public static bool returns(int Quantity, string ProductName)
        {
            bool IsUpdatedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "UPDATE Products SET الكميه = الكميه + @Quantity WHERE اسم_المنتج = @ProductName;";
            SQLiteCommand command = new SQLiteCommand(Query, connection);
            command.Parameters.AddWithValue("@ProductName", ProductName);
            command.Parameters.AddWithValue("@Quantity", Quantity);

            try
            {
                connection.Open();
                int RowAffected = command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    IsUpdatedSuccessfully = true;
                }
                else
                {
                    IsUpdatedSuccessfully = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
            return IsUpdatedSuccessfully;
        }
        public static bool ReturnQuantity(BigInteger ID, int Quantities)
        {
            bool IsUpdatedSuccessfully = false;
            SQLiteConnection Connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "UPDATE Products SET الكميه = الكميه + @Quantities, الربح_بعد_البيع = @Quantities * سعر_البيع_للوحده WHERE الرقم_الفريد = @ID;";
            SQLiteCommand Command = new SQLiteCommand(query, Connection);
            Command.Parameters.AddWithValue("@ID", ID.ToString());

            Command.Parameters.AddWithValue("@Quantities", Quantities);

            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsUpdatedSuccessfully = true;
                    Connection.Close();
                }
                else
                {
                    IsUpdatedSuccessfully = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.Close();
            }
            return IsUpdatedSuccessfully;
        }

    }
}



