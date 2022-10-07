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

        public string OrderDate { get; set; }   //orders variables
        public string OrderDate2 { get; set; }
        public string DeliveryDate { get; set; }
        public string FullName { get; set; }
        public string ProductName { get; set; }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }   //supplier variable


        public double Total { get; set; }      //aggregate
        public int BestSold { get; set; }

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
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.SupplierName = reader["SupplierName"].ToString();
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
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.SupplierName = reader["SupplierName"].ToString();
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
        public List<OrderDetail> searchByDate()
        {
            createConnection();

            List<OrderDetail> list = new List<OrderDetail>();

            string query = "select * from searchByDate(@OrderId, @OrderDate, @OrderDate2)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("OrderId", OrderId);
            cmd.Parameters.AddWithValue("OrderDate", OrderDate);
            cmd.Parameters.AddWithValue("OrderDate2", OrderDate2);



            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                OrderDetail temp = new OrderDetail();

                temp.FullName = reader["FullName"].ToString();
                temp.OrderId = Convert.ToInt32(reader["OrderId"]);
                temp.OrderDate = reader["OrderDate"].ToString();
                temp.DeliveryDate = reader["DeliveryDate"].ToString();
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.SupplierName = reader["SupplierName"].ToString();
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
        public List<OrderDetail> categoryBySupplier()
        {
            createConnection();

            List<OrderDetail> list = new List<OrderDetail>();

            string query = "select * from categoryBySupplier(@SupplierName)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SupplierName", SupplierName);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                OrderDetail temp = new OrderDetail();

                temp.FullName = reader["FullName"].ToString();
                temp.OrderId = Convert.ToInt32(reader["OrderId"]);
                temp.OrderDate = reader["OrderDate"].ToString();
                temp.DeliveryDate = reader["DeliveryDate"].ToString();
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.SupplierName = reader["SupplierName"].ToString();
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


        public List<OrderDetail> displayBestSellers()
        {
            createConnection();

            List<OrderDetail> list = new List<OrderDetail>();

            string query = "exec displayBestSellers";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                OrderDetail temp = new OrderDetail();

                temp.ProductName = reader["ProductName"].ToString();
                temp.BestSold = Convert.ToInt32(reader["BestSold"]);

                list.Add(temp);
            }

            closeConnection();
            return list;
        }


    }
}
