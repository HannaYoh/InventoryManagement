using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement.Models
{
    internal class Discount : DBConnection
    {
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public string DiscountCode { get; set; }
        public byte Status { get; set; }
        public double DiscountAmount { get; set; }

        public int totalDiscount()
        {
            createConnection();

            string query = "select dbo.countDiscount()";
            SqlCommand cmd = new SqlCommand(query, conn);

            var result = cmd.ExecuteScalar();

            closeConnection();
            return (int)result;
        }
    }
    
}
