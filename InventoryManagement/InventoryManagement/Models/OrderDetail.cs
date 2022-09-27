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
        public string DeliveryDate { get; set; }
        public string FullName { get; set; }
        public string ProductName { get; set; }


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

        public decimal calculateProfit()
        {
            createConnection();

            string query = "select dbo.CalculateProfit()";
            SqlCommand cmd = new SqlCommand(query, conn);

            var result = cmd.ExecuteScalar();

            closeConnection();
            return Convert.ToDecimal(result);
        }

        public decimal calculateEarnings()
        {
            createConnection();

            string query = "select dbo.calculateEarnings()";
            SqlCommand cmd = new SqlCommand(query, conn);

            var result = cmd.ExecuteScalar();

            closeConnection();
            return Convert.ToDecimal(result);
        }

        public List<OrderDetail> viewAllOrders()
        {
            createConnection();

            List<OrderDetail> list = new List<OrderDetail>();

            string query = "select * from viewAllOrders()";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                OrderDetail temp = new OrderDetail();

                temp.FullName = reader["FullName"].ToString();
                temp.OrderId = Convert.ToInt32(reader["OrderId"]);
                temp.OrderDate = reader["OrderDate"].ToString();
                temp.DeliveryDate = reader["DeliveryDate"].ToString();
                temp.ProductId = Convert.ToInt32(reader["ProductId"]);
                temp.ProductName = reader["ProductName"].ToString();
                temp.Quantity = Convert.ToInt32(reader["Quantity"]);
                temp.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                temp.RetailPrice = Convert.ToDouble(reader["RetailPrice"]);
                temp.WholesalePrice = Convert.ToDouble(reader["WholesalePrice"]);

                list.Add(temp);
            }

            closeConnection();
            return list;
        }

        public List<OrderDetail> searchByOrderId()
        {
            createConnection();

            List<OrderDetail> list = new List<OrderDetail>();

            string query = "select * from searchByOrderId(@OrderId)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("OrderId", OrderId);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                OrderDetail temp = new OrderDetail();

                temp.FullName = reader["FullName"].ToString();
                temp.OrderId = Convert.ToInt32(reader["OrderId"]);
                temp.OrderDate = reader["OrderDate"].ToString();
                temp.DeliveryDate = reader["DeliveryDate"].ToString();
                temp.ProductId = Convert.ToInt32(reader["ProductId"]);
                temp.ProductName = reader["ProductName"].ToString();
                temp.Quantity = Convert.ToInt32(reader["Quantity"]);
                temp.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                temp.RetailPrice = Convert.ToDouble(reader["RetailPrice"]);
                temp.WholesalePrice = Convert.ToDouble(reader["WholesalePrice"]);

                list.Add(temp);
            }

            closeConnection();
            return list;
        }
    }
}
