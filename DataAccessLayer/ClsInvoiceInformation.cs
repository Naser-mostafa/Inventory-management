using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UhlSportDataAccessLayer
{
    public static class ClsInvoiceInformation
    {
        public static  void GetnInvoiceInfo(ref string Country,ref string Email ,ref string BankAccountNumber,ref string BankName,ref string SalesManager,ref string ImagePath)
        {
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "select * from InvoiceInformation;";
            SQLiteCommand cmd = new SQLiteCommand(Query, connection);
            try
            {
                connection.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    Country = Convert.ToString(reader["البلد"]);
                    Email = Convert.ToString(reader["البريد_الالكتروني"]);
                    BankAccountNumber = Convert.ToString(reader["رقم_الحساب_البنكي"]);
                    BankName = Convert.ToString(reader["اسم_البنك"]);
                    SalesManager = Convert.ToString(reader["رقم_مدير_المبيعات"]);
                    ImagePath = Convert.ToString(reader["لوجو"]);
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }finally
            {
                connection.Close();
            }

        }
        public static bool Update( string Country,  string Email,  string BankAccountNumber,  string BankName,  string SalesManager,string ImagePath)
        {
            bool IsUpdatedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "update InvoiceInformation set البلد=@Country,البريد_الالكتروني=@Email,رقم_الحساب_البنكي=@BankAccountNumber,اسم_البنك=@BankName,رقم_مدير_المبيعات=@SalesManager ,لوجو=@ImagePath where رقم_الفاتوره_الفريد=1";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@BankAccountNumber", BankAccountNumber);
            command.Parameters.AddWithValue("@BankName", BankName);
            command.Parameters.AddWithValue("@SalesManager", SalesManager);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if(RowsAffected>0)
                {
                    IsUpdatedSuccessfully = true;
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
            return IsUpdatedSuccessfully;
        }


    }
}
