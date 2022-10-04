using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement.Models
{
    internal class RecentActivity : DBConnection
    {
        //variables
        public int ActivityId { get; set; }
        public string ActivityDate { get; set; }
        public char ActivityType { get; set; }
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        //methods

        public RecentActivity returnSupplier()
        {
            createConnection();

            string query = "select * from returnRecentSupplierInfo()";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            // RecentActivity temp = new RecentActivity();

            while (reader.Read())
            {
                this.FullName = reader["FullName"].ToString();
                this.ActivityType = Convert.ToChar(reader["ActivityType"]);
                this.ActivityDate = reader["ActivityDate"].ToString();
                this.SupplierName = reader["SupplierName"].ToString();
            }

            closeConnection();
            return this;
        }

        public RecentActivity returnInventory()
        {
            createConnection();

            string query = "select * from returnRecentInventoryInfo()";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            // RecentActivity temp = new RecentActivity();

            while (reader.Read())
            {
                this.FullName = reader["FullName"].ToString();
                this.ActivityType = Convert.ToChar(reader["ActivityType"]);
                this.ActivityDate = reader["ActivityDate"].ToString();
                this.ProductName = reader["ProductName"].ToString();
            }

            closeConnection();
            return this;
        }

    }
}
