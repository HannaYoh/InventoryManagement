using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace InventoryManagement.Models
{
    internal class Supplier : DBConnection
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public List<Supplier> searchSupplier()
        {
            createConnection();
            List<Supplier> list = new List<Supplier>();

            string query = "select * from Supplier";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Supplier temp = new Supplier();

                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.SupplierName = reader["SupplierName"].ToString();
                temp.Email = reader["Email"].ToString();
                temp.Address = reader["Address"].ToString();
                temp.Phone = reader["Phone"].ToString();

                list.Add(temp);
            }

            closeConnection();
            return list;

        }

        public void addSupplier()
        {
            createConnection();

            string query = "exec addSupplier @SupplierName, @Email, @Address, @Phone";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SupplierName", SupplierName);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Address", Address);
            cmd.Parameters.AddWithValue("Phone", Phone);

            cmd.ExecuteNonQuery();

            closeConnection();

        }



        public List<Supplier> searchBySupplierId()
        {
            createConnection();

            List<Supplier> list = new List<Supplier>();

            string query = "select * from searchBySupplierId(@SupplierId)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SupplierId", SupplierId);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Supplier temp = new Supplier();

                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.SupplierName = reader["SupplierName"].ToString();
                temp.Email = reader["Email"].ToString();
                temp.Address = reader["Address"].ToString();
                temp.Phone = reader["Phone"].ToString();

                list.Add(temp);
            }

            closeConnection();
            return list;
        }

        public void updateSupplierInfo()
        {
            createConnection();

            string query = "exec updateSupplier @SupplierId, @SupplierName, @Email, @Address, @Phone";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SupplierId", SupplierId);
            cmd.Parameters.AddWithValue("SupplierName", SupplierName);
            cmd.Parameters.AddWithValue("Email", Email);          
            cmd.Parameters.AddWithValue("Address", Address);
            cmd.Parameters.AddWithValue("Phone", Phone);
            
            cmd.ExecuteNonQuery();

            closeConnection();

        }

        public void deleteSupplier()
        {
            createConnection();

            string query = "exec deleteSupplier @SupplierId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SupplierId", SupplierId);

            cmd.ExecuteNonQuery();

            closeConnection();
            
        }

        public List<Supplier> loadAllSuppliers()
        {
            createConnection();

            List<Supplier> list = new List<Supplier>();

            string query = "select * from Supplier";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Supplier temp = new Supplier();

                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.SupplierName = reader["SupplierName"].ToString();
                temp.Email = reader["Email"].ToString();
                temp.Address = reader["Address"].ToString();
                temp.Phone = reader["Phone"].ToString();


                list.Add(temp);
            }

            closeConnection();
            return list;
        }
    }
}




        
