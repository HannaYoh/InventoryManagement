using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement
{
    internal abstract class DBConnection
    {
        public static string connString = "Data Source=HANNA\\SQLEXPRESS;Initial Catalog=inventorydb;Integrated Security=True";
        public static SqlConnection conn;

        public void createConnection()
        {
            conn = new SqlConnection(connString);
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

    }
}
