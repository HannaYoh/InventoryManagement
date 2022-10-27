using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagement.Models
{
    internal class Customer : DBConnection
    {
        //variables

        public int CustId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string NewEmail { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }

        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }


        //methods
        public int totalCustomer()
        {
            createConnection();

            string query = "select dbo.countCustomers()";
            SqlCommand cmd = new SqlCommand(query, conn);

            var result = cmd.ExecuteScalar();

            closeConnection();
            return (int)result;
        }
        /*public List<Customer> searchCustomerByName()
        {
            createConnection();

            List<Customer> list = new List<Customer>();

            string query = "select * from searchByCustomerName(@Fullname)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("FullName", FullName);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Customer temp = new Customer();

               // temp.CustId = Convert.ToInt32(reader["CustId"]);
                temp.FullName = reader["FullName"].ToString();
                temp.Email = reader["Email"].ToString();
                temp.Address = reader["Address"].ToString();
                temp.Phone = reader["Phone"].ToString();
                temp.Gender = reader["Gender"].ToString();
               // temp.BirthOfDate = reader["BirthOfDate"].ToString();


                list.Add(temp);
            }

            closeConnection();
            return list;
        }*/

        public void addCustomer()
        {
            createConnection();

            string query = "exec insertIntoCustomer @FullName, @Email , @Address, @Phone, @Gender, @DateOfBirth";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("FullName", FullName);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Address", Address);
            cmd.Parameters.AddWithValue("Phone", Phone);
            cmd.Parameters.AddWithValue("Gender", Gender);
            cmd.Parameters.AddWithValue("DateOfBirth", DateOfBirth);

            cmd.ExecuteNonQuery();

            closeConnection();
        }
        public void deleteCustomer()
        {
            createConnection();

            string query = "exec deleteCustomer @Email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Email", Email);

            cmd.ExecuteNonQuery();

            closeConnection();
        }

        public List<Customer> searchCustomer()
        {
            createConnection();

            List<Customer> list = new List<Customer>();

            string query = "select * from searchCustomer(@FullName)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("FullName", FullName);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Customer temp = new Customer();
                
                temp.CustId = Convert.ToInt32(reader["CustId"]);
                temp.FullName = reader["FullName"].ToString();
                temp.Email = reader["Email"].ToString();
                temp.Address = reader["Address"].ToString();
                temp.Phone = reader["Phone"].ToString();
                temp.Gender = reader["Gender"].ToString();
                temp.DateOfBirth = reader["DateOfBirth"].ToString();
                
                list.Add(temp);
            }

            closeConnection();
            return list;
        }

        public Customer returnCustomerInfo()
        {
            createConnection();

            string query = "exec selectCustomerByEmail @Email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Email", Email);

            SqlDataReader reader = cmd.ExecuteReader();

            Customer temp = new Customer();

            while (reader.Read())
            {
                temp.CustId = Convert.ToInt32(reader["CustId"]);
                temp.FullName = reader["FullName"].ToString();
                temp.Email = reader["Email"].ToString();
                temp.Address = reader["Address"].ToString();
                temp.Phone = reader["Phone"].ToString();
                temp.Gender = reader["Gender"].ToString();
                temp.DateOfBirth = reader["DateOfBirth"].ToString();
            }
            closeConnection();
            return temp;
        }

        public List<Customer> searchOrderByCustId()
        {
            createConnection();

            List<Customer> list = new List<Customer>();

            string query = "select * from searchOrderByCustId(@CustId)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("CustId", CustId);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Customer temp = new Customer();

                temp.OrderId = Convert.ToInt32(reader["OrderId"]);
                temp.OrderDate = reader["OrderDate"].ToString();               
                temp.ProductId = Convert.ToInt32(reader["ProductId"]);            
                temp.Quantity = Convert.ToInt32(reader["Quantity"]);
                temp.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                
                list.Add(temp);
            }

            closeConnection();
            return list;
        }

        public int returnCustomerId()
        {
            createConnection();

            string query = "select dbo.getCustomerId(@Email)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Email", Email);

            var result = cmd.ExecuteScalar();

            closeConnection();
            return (int)result;
        }

        public void updateCustomerInfo()
        {
            createConnection();

            string query = "exec updateCustomerInfo @FullName, @Email, @NewEmail, @Address, @Phone, @DateOfBirth, @Gender";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("FullName", FullName);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("NewEmail", NewEmail);
            cmd.Parameters.AddWithValue("Address", Address);
            cmd.Parameters.AddWithValue("Phone", Phone);            
            cmd.Parameters.AddWithValue("DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("Gender", Gender);

            cmd.ExecuteNonQuery();

            closeConnection();

        }





    }
}
