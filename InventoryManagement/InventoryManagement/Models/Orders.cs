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
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }


        //methods
        public int totalOrder()
        {
            createConnection();

            string query = "select dbo.countOrders()";
            SqlCommand cmd = new SqlCommand(query, conn);

            var result = cmd.ExecuteScalar();

            closeConnection();
            return (int)result;
        }

        public void addOrders()
        {
            createConnection();

            string query = "exec insertIntoOrders @CustId, @DeliveryDate";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("CustId", CustId);
            cmd.Parameters.AddWithValue("DeliveryDate", DeliveryDate);

            cmd.ExecuteNonQuery();

            closeConnection();
        }
    }
}
