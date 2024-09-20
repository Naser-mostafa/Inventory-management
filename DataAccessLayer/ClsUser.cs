using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Numerics;

namespace UhlSportDataAccessLayer
{
    
    public static class ClsUser
    {


        public static bool IsThisAccountExistsAndreturnInfoIfExists(ref BigInteger Id, ref string FirstName, ref string LastName, ref string UserName, ref string Password, ref sbyte Permission)
        {
            bool IsFound = false;
            string query = "SELECT * FROM Users WHERE اسم_المستخدم = @UserName AND كلمه_السر = @Password";
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                try
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        IsFound = true;
                        Id = Convert.ToInt32(dt.Rows[0][0]);
                        FirstName = dt.Rows[0][1].ToString();
                        LastName = dt.Rows[0][2].ToString();
                        UserName = dt.Rows[0][3].ToString();
                        Password = dt.Rows[0][4].ToString();
                        Permission = Convert.ToSByte(dt.Rows[0][5]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    IsFound = false;
                }
            }
            return IsFound;
        }
        public static DataTable GetAllUsers()
        {
            DataTable users = new DataTable();
            string query = "SELECT * FROM Users;";
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
                {
                    connection.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        adapter.Fill(users);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return users;
        }
        public static bool IsThisPasswordBelongsToThisId(int Id, string Password)
        {
            bool IsFound = false;
            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                string query = "SELECT COUNT(*) FROM users WHERE رقم_المستخدم_الفريد = @Id AND كلمه_السر = @Password";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Password", Password);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        IsFound = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            return IsFound;
        }
        public static bool UpdateUserInfo(int userId, string firstName, string lastName, string userName, string password, sbyte permission)
        {
            bool isSuccess = false;
            string query = "UPDATE Users SET اسم_المستخدم = @UserName, كلمه_السر = @Password, الاسم_الاول = @FirstName, الاسم_الاخير = @LastName, رقم_الصلاحيات_الفريد = @Permission WHERE رقم_المستخدم_الفريد = @UserId";

            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Permission",Convert.ToInt16(permission));
                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        isSuccess = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            return isSuccess;
        }
        public static bool DeleteUser(int userId)
        {
            bool isSuccess = false;
            string query = "Delete  from Users where رقم_المستخدم_الفريد=@UserId;Delete  from Log_in where رقم_المستخدم_الفريد=@UserId;DELETE FROM Log_Out WHERE رقم_المستخدم_الفريد = @UserId";

            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        isSuccess = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            return isSuccess;
        }
        public static bool AddNewUser(string firstName, string lastName, string userName, string password, sbyte permission)
        {
            bool isSuccess = false;
            string query = @"
        INSERT INTO Users
        (الاسم_الاول, الاسم_الاخير, اسم_المستخدم, كلمه_السر, رقم_الصلاحيات_الفريد)
        VALUES
        (@firstName, @lastName, @userName, @password, @permission);";

            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@permission", Convert.ToInt16(permission));

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return isSuccess;
        }
        public static bool GetUserInfoById(int userId, ref string firstName, ref string lastName, ref string userName, ref string password, ref sbyte permission)
        {
            bool isSuccess = false;

            string query = "SELECT * FROM Users WHERE رقم_المستخدم_الفريد = @UserId";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        connection.Open();

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstName = reader["الاسم_الاول"].ToString();
                                lastName = reader["الاسم_الاخير"].ToString();
                                userName = reader["اسم_المستخدم"].ToString();
                                password = reader["كلمه_السر"].ToString();
                                permission = Convert.ToSByte(reader["رقم_الصلاحيات_الفريد"]);
                                isSuccess = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return isSuccess;
        }

        public static bool UpdateUserNameAndPasswordInfo()
        {
            string UserName = "Naser0120#";
            string Password = "Naser0120#";
            bool isSuccess = false;
            string query = "UPDATE Users SET اسم_المستخدم = @UserName, كلمه_السر = @Password;";

            using (SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
        

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        isSuccess = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            return isSuccess;
        }

    }


}
