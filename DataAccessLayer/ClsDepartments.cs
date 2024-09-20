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
    public static class ClsDepartments
    {
        public static DataTable GetAllDepartmentsName()
        {
          
            DataTable AllDepartments = new DataTable();
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "select اسم_التخصص from Departments;";
            SQLiteCommand command = new SQLiteCommand(Query, connection);
            try
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
           
                
                    AllDepartments.Load(reader);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
            return AllDepartments;
        }
        public static BigInteger IsThisDepartmmentIsAlreadyExist(string DepartmentNAme)
        {
            BigInteger   DepartmentID = 0;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "select الرقم_الفريد_لتخصص_العمل from Departments where اسم_التخصص=@DepartmentNAme";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@DepartmentNAme", DepartmentNAme);
            try
            {
                connection.Open();
                object value = command.ExecuteScalar();
                if (value != null)
                {
                    DepartmentID = Convert.ToInt64(value);
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
            return DepartmentID;
        }
        public static BigInteger AddDepartmentAndReturnId(string DepartmentName)
        {
            BigInteger ID = 0;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "INSERT INTO [Departments]\r\n           (\r\n           [اسم_التخصص])\r\n     VALUES(@DepartmentName);SELECT last_insert_rowid();";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);
            try
            {
                connection.Open();
                object value = cmd.ExecuteScalar();
              
                if(value!=null&& BigInteger.TryParse(value.ToString(),out BigInteger insertedId))
                {
                    ID = Convert.ToInt64(value);
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
            return ID;
        }
        public static string FindCountryNameByID(BigInteger DepartmentID)
        {
            string Id = "";

            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "select اسم_التخصص from Departments where الرقم_الفريد_لتخصص_العمل=@DepartmentID;";
            SQLiteCommand command = new SQLiteCommand(Query, connection);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            try
            {
                connection.Open();
                var ID = command.ExecuteScalar();
                if (ID != null)
                {
                    Id = (string)ID;
                }
            }
            catch (Exception ex)
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
