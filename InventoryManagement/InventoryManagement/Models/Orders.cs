using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement.Models
{
    internal class Orders : DBConnection
    {
        //variables
        public int OrderId { get; set; }
        public int CustId { get; set; }
        public int ProductId { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double RetailPrice { get; set; }
        public double WholesalePrice { get; set; }

        //methods
        public List<Orders> displayGrossRevenue()
        {
            createConnection();

            List<Orders> ordersList = new List<Orders>();

            string query = "select * from displayGrossRevenue()";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Orders model = new Orders();
                model.OrderDate = reader["OrderDate"].ToString();
                model.TotalPrice = Convert.ToInt32(reader["total"]);

                ordersList.Add(model);

            }

            closeConnection();
            return ordersList;


        }
    }
}
