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
    public static class ClsLogOutDates
    {
        public static void AddNew(DateTime date, BigInteger userId)
        {
            string query = "INSERT INTO [Log_Out] ([التاريخ], [رقم_المستخدم_الفريد]) VALUES (@Dt, @UserId);";

            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // إضافة القيم للبارامترات
                    command.Parameters.AddWithValue("@Dt", date);
                    command.Parameters.AddWithValue("@UserId", userId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        public static DataTable GetAllLogOutDates()
        {
            DataTable All = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "SELECT Log_Out.رقم_تسجيل_الخروج_الفريد, Users.الاسم_الاول, Users.الاسم_الاخير, Log_Out.التاريخ\r\nFROM     Log_Out INNER JOIN\r\n                  Users ON Log_Out.رقم_المستخدم_الفريد = Users.رقم_المستخدم_الفريد";
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
            string Query = "delete from Log_Out;"; // استعلام حذف السجلات من الجدول

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
