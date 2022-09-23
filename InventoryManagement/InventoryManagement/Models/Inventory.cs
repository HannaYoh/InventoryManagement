using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement.Models
{
    internal class Inventory : DBConnection
    {
        //variables
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double RetailPrice { get; set; }
        public double WholesalePrice { get; set; }
        public string ManufactureDate { get; set; }
        public int AmountAvailable { get; set; }
        public bool isAvailable { get; set; }
        public int SupplierId { get; set; }

        //methods
        public List<Inventory> displayLowOnStock()
        {
            createConnection();

            List<Inventory> inventoryList = new List<Inventory>();

            string query = "select * from lowOnStock()";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();
           
            while (reader.Read())
            {
                Inventory model = new Inventory();
                model.ProductName = reader["ProductName"].ToString();
                model.AmountAvailable = Convert.ToInt32(reader["AmountAvailable"]);

                inventoryList.Add(model);

            }

            closeConnection();
            return inventoryList;


        }
    }
}
