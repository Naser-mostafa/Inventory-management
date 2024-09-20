using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UhlSportDataAccessLayer
{
    public static class ClsLoginDate
    {
        public static bool AddNew(DateTime Dt, BigInteger UserId)
        {
            bool IsAddedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "INSERT INTO [Log_in]\r\n                  ([التاريخ]\r\n           ,[رقم_المستخدم_الفريد])\r\n     VALUES (@Dt,@UserId);";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("Dt", Dt);
            command.Parameters.AddWithValue("UserId", UserId);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if(RowsAffected>0)
                {
                    IsAddedSuccessfully = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                connection.Close();
            }
            return IsAddedSuccessfully;


        }
        public static DataTable GetAllLogInDates()
        {
            DataTable All = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "SELECT Log_in.رقم_تسجيل_الدخول_الفريد, Users.الاسم_الاول, Users.الاسم_الاخير, Log_in.التاريخ\r\nFROM     Log_in INNER JOIN\r\n                  Users ON Log_in.رقم_المستخدم_الفريد = Users.رقم_المستخدم_الفريد";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);

                try
                {
                    connection.Open();
                    adapter.Fill(All);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            return All;
        }
        
        public static bool DeleteALL()
        {
        bool IsDeletedSuccessfully = false;
        string Query = "delete from Log_in;"; // استعلام حذف السجلات من الجدول

        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                    SQLiteCommand command = new SQLiteCommand(Query, connection); // إنشاء كائن الأمر
                connection.Open(); // فتح الاتصال بقاعدة البيانات
                int rowsAffected = command.ExecuteNonQuery(); // تنفيذ الاستعلام والحصول على عدد الصفوف المتأثرة

                if (rowsAffected > 0)
                {
                    IsDeletedSuccessfully = true; // تم حذف السجلات بنجاح
                }
            }
        }
        catch (Exception ex)
        {
            // يمكنك إضافة رمز للتعامل مع أي استثناء يحدث هنا، مثل تسجيل الخطأ أو إرجاع قيمة خاصة بالخطأ
            Console.WriteLine("Error: " + ex.Message);
        }

        return IsDeletedSuccessfully;
    }



}
}
