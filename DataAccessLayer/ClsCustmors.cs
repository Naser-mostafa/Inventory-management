using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Numerics;

namespace UhlSportDataAccessLayer
{
    public static  class ClsCustmors
    {
        public static DataTable GetAllCustmors()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = @"
SELECT 
    الرقم_الفريد AS مسلسل,
    الاسم_الاول,
    الاسم_الاخير,
    البلد,
    رقم_الهاتف
FROM 
    Custmors";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    try
                    {
                        connection.Open();
                        adapter.Fill(dt);

                        // تحويل القيم null إلى سلسلة فارغة في الجدول
                        foreach (DataRow row in dt.Rows)
                        {
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                if (row.IsNull(i))
                                {
                                    row[i] = "NULL"; // استبدال القيم null بسلسلة فارغة
                                }
                            }
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
            return dt;
        }
        public static bool AddNewCustmor(string FirstName, string LastName, string CountryName, string PhoneNumber)
        {
            bool isAddedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "INSERT INTO [Custmors]\r\n           (\r\n           [الاسم_الاول]\r\n           ,[الاسم_الاخير]\r\n           ,[رقم_الهاتف]\r\n           ,[البلد])\r\n     VALUES (@FirstName, @LastName, @PhoneNumber, @CountryName)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            if (LastName == "")
            {
                command.Parameters.AddWithValue("@LastName", DBNull.Value);

            }
            else
            {
                command.Parameters.AddWithValue("@LastName", LastName);

            }
            command.Parameters.AddWithValue("@PhoneNumber", string.IsNullOrEmpty(PhoneNumber) ? (object)DBNull.Value : PhoneNumber);
            command.Parameters.AddWithValue("@CountryName", string.IsNullOrEmpty(CountryName) ? (object)DBNull.Value : CountryName);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isAddedSuccessfully = true;
                }
                else
                {
                    isAddedSuccessfully = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                isAddedSuccessfully = false;
            }
            finally
            {
                connection.Close();
            }
            return isAddedSuccessfully;
        }

        public static bool UpdateCustomer(BigInteger ID, string FirstName, string LastName, string CountryName, string PhoneNumber)
        {
            bool IsUpdatedSuccessfully = false;
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "update Custmors set الاسم_الاول=@FirstName,الاسم_الاخير=@LastName,رقم_الهاتف=@PhoneNumber,البلد=@CountryName where الرقم_الفريد=@ID;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    if(string.IsNullOrEmpty(LastName))
                    {
                        cmd.Parameters.AddWithValue("@LastName", DBNull.Value);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@LastName", LastName);

                    }
                    if (string.IsNullOrEmpty(CountryName))
                    {
                        cmd.Parameters.AddWithValue("@CountryName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CountryName", CountryName);
                    }
                    if (string.IsNullOrEmpty(PhoneNumber))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    }
                    cmd.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            IsUpdatedSuccessfully = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                } // يتم إغلاق الأمر تلقائيًا عند الانتهاء من استخدامه
            } // يتم إغلاق الاتصال تلقائيًا عند الانتهاء من استخدامه
            return IsUpdatedSuccessfully;
        }
        public static DataTable FindCustmorByName(string Name)
        {
            DataTable dt = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "SELECT * FROM Custmors WHERE الاسم_الاول LIKE @Name || '%'";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); // استخدام SQLiteDataAdapter بدلاً من SqlDataAdapter
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static void FindCustmorByID(BigInteger ID, ref string FirstName,ref string LastName, ref string Phone,ref string CountryName)
        {
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "SELECT * FROM Custmors WHERE الرقم_الفريد = @ID ";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SQLiteDataReader adapter = cmd.ExecuteReader();
               while(adapter.Read())
                {
                    FirstName = (string)adapter["الاسم_الاول"];
                    if (adapter["الاسم_الاخير"]==DBNull.Value)
                    {
                        LastName = "";
                    }
                    else
                    {
                        LastName = (string)adapter["الاسم_الاخير"];
 
                    }
                    if (adapter["رقم_الهاتف"]==DBNull.Value)
                    {
                        Phone = "";
                    }
                    else
                    {
                        Phone = (string)adapter["رقم_الهاتف"];
                    }
                    if (adapter["البلد"] == DBNull.Value)
                    {
                        CountryName = "";
                    }
                    else
                    {
                        CountryName = (string)adapter["البلد"];
                    }

                }
                adapter.Close();
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

        public static bool Delete(BigInteger ID)
        {
            bool IsDeletedSuccessfully = true;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "delete from Custmors where الرقم_الفريد=@ID";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                int rowsaffected = cmd.ExecuteNonQuery();
                if(rowsaffected>0)
                {
                    IsDeletedSuccessfully = true;
                }
              
            }
            catch(Exception ex)
            {
                IsDeletedSuccessfully = false;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return IsDeletedSuccessfully;
            }
    }
}
