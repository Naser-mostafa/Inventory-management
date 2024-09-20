using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace UhlSportDataAccessLayer
{
    public static class ClsSizes
    {
        public static int AddingSizeAndReturnScopeIdentity(string Size)
        {
            short InsertedID = 0;
            SQLiteConnection Connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "INSERT INTO [Sizes]\r\n           (\r\n           [المقاس])\r\n     VALUES (@Size);  SELECT last_insert_rowid();";
            SQLiteCommand cmd = new SQLiteCommand(query, Connection);
            cmd.Parameters.AddWithValue("@Size", Size);
            try
            {
                Connection.Open();
                object Value = cmd.ExecuteScalar();
                if (Value != null && short.TryParse(Value.ToString(), out short InsertedId))
                {
                    InsertedID = InsertedId;
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
            return InsertedID;
        }
        public static int IsThisSizeAlreadyExist(string SizeName)
        {
            int ID = 0;
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "SELECT الرقم_الفريد FROM Sizes WHERE المقاس = @SizeName;";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@SizeName", SizeName);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        ID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            return ID;
        }
        public static DataTable GetAllSizes()
        {
            DataTable Dt = new DataTable();
            SQLiteConnection Connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "select المقاس from Sizes;";
            SQLiteCommand Command = new SQLiteCommand(query, Connection);
            try
            {
                Connection.Open();
                SQLiteDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    Dt.Load(reader);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.Close();
            }
            return Dt;
        }
        public static string GetSizeNameByID(int ID)
        {
            string SizeName = "";
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string Query = "SELECT المقاس FROM Sizes WHERE الرقم_الفريد=@ID;";
                using (SQLiteCommand command = new SQLiteCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        object value = command.ExecuteScalar();
                        if (value != null)
                        {
                            SizeName = value.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return SizeName;
        }
        public static int GetIdBySizeName(string SizeName)
        {
            int SizeID = 0;
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "SELECT الرقم_الفريد FROM Sizes WHERE المقاس=@SizeName";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SizeName", SizeName);
                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value) // التأكد من عدم وجود قيمة فارغة
                        {
                            SizeID = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return SizeID;
        }
         
    
    }
}
