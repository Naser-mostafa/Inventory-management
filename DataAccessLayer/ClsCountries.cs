using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Numerics;

namespace UhlSportDataAccessLayer
{
    public static class ClsCountries
    {
        public static DataTable GetAllCountriesName()
        {
            DataTable AllCountries = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "select اسم_الدوله from Countries;";
            SQLiteCommand command = new SQLiteCommand(Query, connection);
            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
             
                
                    AllCountries.Load(reader);
                
            }
            catch(Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
            return AllCountries;
        }
        public static BigInteger IsThisCountryIsAlreadyExist(string CountryName)
        {
            BigInteger CountryID = 0;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "select الرقم_الفريد_للدوله from Countries where اسم_الدوله=@CountryName" ;
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                object value = command.ExecuteScalar();
                if(value!=null)
                {
                    CountryID = Convert.ToInt64(value);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return CountryID;
        }
        public static BigInteger AddCountryAndReturnId(string CountryName)
        {
            BigInteger ID = 0;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "INSERT INTO [Countries]\r\n           (\r\n           [اسم_الدوله])\r\n     VALUES(@CountryName); SELECT last_insert_rowid();";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                object value = cmd.ExecuteScalar();

                if (value != null && BigInteger.TryParse(value.ToString(), out BigInteger insertedId))
                {
                    ID = Convert.ToInt64(value);
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
            return ID;
        }
        public static string FindCountryNameByID(BigInteger CountryID)
        {
            string Id = "";
           
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "select اسم_الدوله from Countries where الرقم_الفريد_للدوله=@CountryID;";
            SQLiteCommand command = new SQLiteCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                connection.Open();
                var ID = command.ExecuteScalar();
                if(ID!=null)
                {
                    Id = (string)ID;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
            return Id;
        }

    }
}
