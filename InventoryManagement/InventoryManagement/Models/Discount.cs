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
        public void addDiscount()
        {
            createConnection();

            string query = "exec insertIntoDiscount @DiscountName, @DiscountCode, @Status , @DiscountAmount";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("DiscountName", DiscountName);
            cmd.Parameters.AddWithValue("DiscountCode", DiscountCode);
            cmd.Parameters.AddWithValue("Status", Status);
            cmd.Parameters.AddWithValue("DiscountAmount", DiscountAmount);

            cmd.ExecuteNonQuery();

            closeConnection();
        }
        public string searchDiscountCode(string code)
        {
            createConnection();

            string query = "select dbo.searchDiscountCode(@code)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("code", code);

            var result = cmd.ExecuteScalar();

            closeConnection();
            return (string)result;

        }

        public int getDiscountPercentageByCode(string code)
        {
            createConnection();

            string query = "select dbo.getDiscountPercentageByCode(@code)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("code", code);

            var result = cmd.ExecuteScalar();

            closeConnection();
            return (int)result;

        }
    }

}
