using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UhlSportDataAccessLayer
{
    public static class ClsColor
    {
        public static int AddingColorAndReturnScopeIdentity(string ColorName)
        {
            short InsertedID = 0;
            SQLiteConnection Connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "INSERT INTO [Colors]\r\n           (\r\n           [اللون])\r\n     VALUES (@ColorName);  SELECT last_insert_rowid();";
            SQLiteCommand cmd = new SQLiteCommand(query, Connection);
            cmd.Parameters.AddWithValue("@ColorName", ColorName);
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
            }            return InsertedID;
        }
        public static DataTable GetAllColorsName()
        {
            DataTable Dt = new DataTable();
            SQLiteConnection Connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "select اللون from Colors;";
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
        public static string GetColorNameByID(int ID)
        {
            string ColorName = "";
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string Query = "SELECT اللون FROM Colors WHERE الرقم_الفريد=@ID;";
                using (SQLiteCommand command = new SQLiteCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        object value = command.ExecuteScalar();
                        if (value != null)
                        {
                            ColorName = value.ToString();
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
            return ColorName;
        }
        public static int GetIdByColorName(string ColorName)
        {
            int ColorID = 0;
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "SELECT الرقم_الفريد FROM Colors WHERE اللون=@ColorName";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ColorName", ColorName);
                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value) // التأكد من عدم وجود قيمة فارغة
                        {
                            ColorID = Convert.ToInt32(result);
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
            return ColorID;
        }
        public static int IsThisColorAlreadyExist(string ColorName)
        {
            int ID = 0;
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "SELECT الرقم_الفريد FROM Colors WHERE اللون = @ColorName;";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@ColorName", ColorName);
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

    }
}
