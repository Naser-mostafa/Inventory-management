using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UhlSportDataAccessLayer
{

   
    public class Settings
    {
        public static string connectionStringForSqlite = $"Data Source=DatabaseFile/FaislDb.db";
        public static void AccessDenied()
        {
            MessageBox.Show("انت محظور من الوصول الي هنا يرجي التواصل مع مستر مبارك ");
        }
    }
}
