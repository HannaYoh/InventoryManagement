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
        public List<Inventory> viewAllProducts()
        {
            createConnection();

            List<Inventory> list = new List<Inventory>();

            string query = "select * from Inventory";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Inventory temp = new Inventory();

                temp.ProductId = Convert.ToInt32(reader["ProductId"]);
                temp.ProductName = reader["ProductName"].ToString();
                temp.RetailPrice = Convert.ToDouble(reader["RetailPrice"]);
                temp.WholesalePrice = Convert.ToDouble(reader["WholesalePrice"]);
                temp.ManufactureDate = reader["ManufactureDate"].ToString();
                temp.AmountAvailable = Convert.ToInt32(reader["AmountAvailable"]);
                temp.isAvailable = Convert.ToBoolean(reader["isAvailable"]);
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);


                list.Add(temp);
            }

            closeConnection();
            return list;
        }

        public List<Inventory> searchByProductId()
        {
            createConnection();

            List<Inventory> list = new List<Inventory>();

            string query = "select * from searchByProductId(@ProductId)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ProductId", ProductId);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Inventory temp = new Inventory();

                temp.ProductId = Convert.ToInt32(reader["ProductId"]);
                temp.ProductName = reader["ProductName"].ToString();
                temp.RetailPrice = Convert.ToDouble(reader["RetailPrice"]);
                temp.WholesalePrice = Convert.ToDouble(reader["WholesalePrice"]);
                temp.ManufactureDate = reader["ManufactureDate"].ToString();
                temp.AmountAvailable = Convert.ToInt32(reader["AmountAvailable"]);
                temp.isAvailable = Convert.ToBoolean(reader["isAvailable"]);
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);


                list.Add(temp);
            }

            closeConnection();
            return list;
        }

        public List<Inventory> categoryBySupplier()
        {
            createConnection();

            List<Inventory> list = new List<Inventory>();

            string query = "select * from categoryBySupplier(@SupplierId)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SupplierId", SupplierId);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Inventory temp = new Inventory();

                temp.ProductId = Convert.ToInt32(reader["ProductId"]);
                temp.ProductName = reader["ProductName"].ToString();
                temp.RetailPrice = Convert.ToDouble(reader["RetailPrice"]);
                temp.WholesalePrice = Convert.ToDouble(reader["WholesalePrice"]);
                temp.ManufactureDate = reader["ManufactureDate"].ToString();
                temp.AmountAvailable = Convert.ToInt32(reader["AmountAvailable"]);
                temp.isAvailable = Convert.ToBoolean(reader["isAvailable"]);
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);

                list.Add(temp);
            }

            closeConnection();
            return list;
        }

    }
}
