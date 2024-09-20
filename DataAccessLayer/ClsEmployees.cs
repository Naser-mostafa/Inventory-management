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
    public static class ClsEmployees
    {
        public static DataTable GetAllEmployees()
        {
            // هذا القيمة تُعين لتحديث حالة الراتب إلى غير المدفوعة بعد تحديث الرواتب
            byte NotPayed = 1;
            DataTable dt = new DataTable();
            byte NumberOfTheDayOnTheMonth = (byte)DateTime.Today.Day; // يوم الشهر الحالي

            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                // استعلام SQL لتحديث حالة الرواتب ثم استرجاع بيانات الموظفين
                string Query = @"
BEGIN TRANSACTION;
UPDATE Employees 
SET الرقم_الفريد_لحاله_الراتب = @NotPayed 
WHERE @NumberOfTheDayOnTheMonth IN (1, 2);
COMMIT;

SELECT 
    Employees.رقم_الموظف_الفريد, 
    Employees.الاسم_الاول, 
    Employees.الاسم_الاخير, 
    Employees.تاريخ_الميلاد, 
    Countries.اسم_الدوله, 
    Departments.اسم_التخصص, 
    salaryPayments.الراتب AS 'حاله الراتب', 
    CASE 
        WHEN Employees.تاريخ_الاستقاله IS NULL THEN 'نشط'
        ELSE Employees.تاريخ_الاستقاله 
    END AS 'تاريخ_الاستقاله' 
FROM 
    Employees 
INNER JOIN 
    Departments ON Employees.الرقم_الفريد_للتخصص = Departments.الرقم_الفريد_لتخصص_العمل 
INNER JOIN 
    Countries ON Employees.الرقم_الفريد_للدوله = Countries.الرقم_الفريد_للدوله 
INNER JOIN 
    salaryPayments ON Employees.الرقم_الفريد_لحاله_الراتب = salaryPayments.الرقم_الفريد
";


                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(Query, connection))
                {
                    try
                    {
                        // إعداد معلمة تحديث الرواتب غير المدفوعة
                        adapter.SelectCommand.Parameters.AddWithValue("@NotPayed", NotPayed);
                        adapter.SelectCommand.Parameters.AddWithValue("@NumberOfTheDayOnTheMonth", NumberOfTheDayOnTheMonth);

                        connection.Open();
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            return dt;
        }

        public static bool AddNewEmployee(string FirstName,string LastName,string DateOfBirth, BigInteger CountryID, BigInteger DepartmentID,short Salary)
        {
            bool IsAddedSuccessfully = false;
            //this is the forign Key for the Pamyment Salires To Employees and this is related that the salary Is NotPayed.
            short NotPayed = 1;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "INSERT INTO [Employees]\r\n           (\r\n           [الاسم_الاول]\r\n           ,[الاسم_الاخير]\r\n           ,[تاريخ_الميلاد]\r\n           ,[الرقم_الفريد_للدوله]\r\n           ,[الرقم_الفريد_للتخصص]\r\n           ,[الرقم_الفريد_لحاله_الراتب]\r\n           ,[الراتب]\r\n           ,[تاريخ_الاستقاله])\r\n     VALUES(@FirstName,@LastName,@DateOfBirth,@CountryID,@DepartmentID,@NotPayed,@Salary,@resignationDate);";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            command.Parameters.AddWithValue("@LastName", LastName);
            DateTime dt = new DateTime(1900, 1, 1);
            if (DateOfBirth == dt.ToString())
            {
                
                command.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@DateOfBirth",Convert.ToDateTime(DateOfBirth));
            }
            command.Parameters.AddWithValue("@NotPayed", NotPayed);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@resignationDate",DBNull.Value);

            try
            {
                connection.Open();
                int RowAffected = command.ExecuteNonQuery();
                if(RowAffected>0)
                {
                    IsAddedSuccessfully = true;
                }
                else
                {
                    IsAddedSuccessfully = false;
                }
            }     
            catch(Exception ex)
            {
                connection.Close();
                IsAddedSuccessfully = false;
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
            return IsAddedSuccessfully;

        }
        public static bool Update(BigInteger ID,string FirstName,string SecondName,string DateOfBirth, BigInteger CountryId, BigInteger DepartmentID,short Salary)
        {
            bool IsUpdatedSuccessfully = false;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "update Employees set الاسم_الاول=@FirstName,تاريخ_الميلاد=@DateOfBirth,الرقم_الفريد_للدوله=@CountryId,الرقم_الفريد_للتخصص=@DepartmentID,الاسم_الاخير=@SecondName,الراتب=@Salary where رقم_الموظف_الفريد=@ID";
            SQLiteCommand command = new SQLiteCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            DateTime dt = new DateTime(1900, 1, 1);
            if(DateOfBirth=="")
            {
                command.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);

            }
            else
            {
                command.Parameters.AddWithValue("@DateOfBirth",Convert.ToDateTime(DateOfBirth));
            }
            command.Parameters.AddWithValue("@CountryId", CountryId);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            try
            {
                connection.Open();
                int RowAffected = command.ExecuteNonQuery();
                if(RowAffected>0)
                {
                    IsUpdatedSuccessfully = true;
                }
                else
                {
                    IsUpdatedSuccessfully = false;
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
        public static void FindEmployeeByID(BigInteger ID, ref string FirstName, ref string LastName, ref string DateOfBirth, ref BigInteger CountryID, ref BigInteger DepartmentID, ref short Salary)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string Query = "select الاسم_الاول, الاسم_الاخير, تاريخ_الميلاد, الرقم_الفريد_للدوله, الرقم_الفريد_للتخصص, الراتب from Employees where رقم_الموظف_الفريد=@ID";
                using (SQLiteCommand command = new SQLiteCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        connection.Open();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FirstName = reader.GetString(reader.GetOrdinal("الاسم_الاول"));
                                LastName = reader.GetString(reader.GetOrdinal("الاسم_الاخير"));
                                DateOfBirth = reader.IsDBNull(reader.GetOrdinal("تاريخ_الميلاد")) ? "" : reader.GetDateTime(reader.GetOrdinal("تاريخ_الميلاد")).ToString();
                                CountryID = reader.GetInt16(reader.GetOrdinal("الرقم_الفريد_للدوله"));
                                DepartmentID = reader.GetInt16(reader.GetOrdinal("الرقم_الفريد_للتخصص"));
                                Salary =Convert.ToInt16(reader["الراتب"]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // يمكنك هنا تنفيذ الإجراءات اللازمة عند حدوث خطأ
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }
        public static bool DeleteEmployeeByID(BigInteger ID)
        {
            bool IsDeletedSuccessfully = false;

            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            string query = "delete from Employees where رقم_الموظف_الفريد=@ID";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
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

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
            return IsDeletedSuccessfully;
        }
        public static DataTable GetEmployeesThatNameStartWith(string Prefix)
        {
            DataTable dt = new DataTable();
          
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string Query = @"
    BEGIN TRANSACTION;
    UPDATE Employees 
    SET الرقم_الفريد_لحاله_الراتب = @NotPayed 
    WHERE @NumberOfTheDayOnTheMonth IN (1, 2);
    COMMIT;
    
    SELECT 
    Employees.رقم_الموظف_الفريد, 
    Employees.الاسم_الاول, 
    Employees.الاسم_الاخير, 
    Employees.تاريخ_الميلاد, 
    Countries.اسم_الدوله, 
    Departments.اسم_التخصص, 
    salaryPayments.الراتب AS 'حاله الراتب', 
    CASE 
        WHEN Employees.تاريخ_الاستقاله IS NULL THEN 'نشط'
        ELSE Employees.تاريخ_الاستقاله 
    END AS 'تاريخ_الاستقاله' 
FROM 
    Employees 
INNER JOIN 
    Departments ON Employees.الرقم_الفريد_للتخصص = Departments.الرقم_الفريد_لتخصص_العمل 
INNER JOIN 
    Countries ON Employees.الرقم_الفريد_للدوله = Countries.الرقم_الفريد_للدوله 
INNER JOIN 
    salaryPayments ON Employees.الرقم_الفريد_لحاله_الراتب = salaryPayments.الرقم_الفريد
WHERE الاسم_الاول LIKE @Prefix || '%'";

                using (SQLiteCommand command = new SQLiteCommand(Query, connection))
                {
                    // تعيين القيم للمعاملات
                    command.Parameters.AddWithValue("@Prefix", Prefix);
                    command.Parameters.AddWithValue("@NotPayed", 1);
                    command.Parameters.AddWithValue("@NumberOfTheDayOnTheMonth", DateTime.Now.Day);

                    try
                    {
                        connection.Open();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            return dt;
        }

        public static int PayAllSalariesToAllEmployees()
        {
            byte Payed = 2;
            int _RowsAffected = 0;
            SQLiteConnection connecton = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "UPDATE Employees SET الرقم_الفريد_لحاله_الدفع=@Payed  ";
            SQLiteCommand command = new SQLiteCommand(Query, connecton);
            command.Parameters.AddWithValue("Payed", Payed);
            try
            {
                connecton.Open();
                int RowAffected = command.ExecuteNonQuery();
                if (RowAffected > 0) 
                {
                    _RowsAffected = RowAffected;
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connecton.Close();
            }

            return _RowsAffected;
        }
        public static int MakeAllSalariesNotPayed()
        {
            byte NotPayed = 1;
            int _RowsAffected = 0;
            SQLiteConnection connecton = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "UPDATE Employees SET الرقم_الفريد_لحاله_الدفع=@NotPayed ";
            SQLiteCommand command = new SQLiteCommand(Query, connecton);
            command.Parameters.AddWithValue("NotPayed", NotPayed);
            try
            {
                connecton.Open();
                int RowAffected = command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    _RowsAffected = RowAffected;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connecton.Close();
            }

            return _RowsAffected;
        }
        public static bool MakeSalaryPayedForEmployee(BigInteger EmployeeId)
        {
            byte Payed = 2;
            bool IsPayedSuccess = false;
            SQLiteConnection connecton = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "UPDATE Employees SET الرقم_الفريد_لحاله_الراتب=@Payed ";
            SQLiteCommand command = new SQLiteCommand(Query, connecton);
            command.Parameters.AddWithValue("@Payed", Payed);
            try
            {
                connecton.Open();
                int RowAffected = command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    IsPayedSuccess = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connecton.Close();
            }

            return IsPayedSuccess;
        }
        public static bool SubmitResignationForAnEmployee(BigInteger EmployeeId)
        {

            bool IsSubmitSuccess = false;
            DateTime dateTime = DateTime.Now;
            SQLiteConnection connecton = new SQLiteConnection(Settings.connectionStringForSqlite);
            string Query = "UPDATE Employees SET تاريخ_الاستقاله=@dateTime where رقم_الموظف_الفريد=@EmployeeId ";
            SQLiteCommand command = new SQLiteCommand(Query, connecton);
            command.Parameters.AddWithValue("@dateTime", dateTime);
            command.Parameters.AddWithValue("@EmployeeId", EmployeeId);

            try
            {
                connecton.Open();
                int RowAffected = command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    IsSubmitSuccess = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connecton.Close();
            }

            return IsSubmitSuccess;
        }



    }
}
