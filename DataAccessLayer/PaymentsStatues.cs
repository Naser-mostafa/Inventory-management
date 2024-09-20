using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UhlSportDataAccessLayer
{
    public static class PaymentsStatues
    {

        public static int AddNewPayment(float RemainderPrice, string PaymentStatue, string Notes)
        {
            int InsertedId = 0;
            SQLiteConnection connection = new SQLiteConnection(Settings.connectionStringForSqlite);
            String query = "INSERT INTO [PaymentsStatues]\r\n           (\r\n           [حاله_الدفع]\r\n           ,[السعر_المتبقي_علي_العميل]\r\n           ,[ملاحظات])\r\n     VALUES (@PaymentStatue,@RemainderPrice,@Notes);SELECT last_insert_rowid();";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@PaymentStatue", PaymentStatue);
            command.Parameters.AddWithValue("@RemainderPrice", RemainderPrice);
            if(Notes!= "")
            {
                command.Parameters.AddWithValue("@Notes", Notes);

            }
            else
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);

            }
            try
            {
                connection.Open();
                object Value = command.ExecuteScalar();
                if (Value != null && int.TryParse(Value.ToString(), out int InsertedID))
                {
                    InsertedId = Convert.ToInt32(Value);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return InsertedId;
        }
    }
}
