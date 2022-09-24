using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement.Models
{
    internal class OrderDetail : DBConnection
    {
        //variables
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double RetailPrice { get; set; }
        public double WholesalePrice { get; set; }

        public string OrderDate { get; set; }   //from orders
        public double Total { get; set; }      //aggregate

        //methods
        public List<OrderDetail> displayGrossRevenue()
        {
            createConnection();

            List<OrderDetail> list = new List<OrderDetail>();

            string query = "select * from displayGrossRevenue()";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                OrderDetail temp = new OrderDetail();

                temp.OrderDate = reader["OrderDate"].ToString();
                temp.Total = Convert.ToDouble(reader["Total"]);

                list.Add(temp);
            }

            closeConnection();
            return list;
        }

        /*public double calculateProfit()
        {
            createConnection();

            string query = "select dbo.CalculateProfit()";
            SqlCommand cmd = new SqlCommand(query, conn);

            var result = cmd.ExecuteScalar();

            closeConnection();
            return (double)result;
        }*/
    }
}
