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
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string BirthOfDate { get; set; }
        public int OrderId { get; set; }
        public string OrdaerDate { get; set; }
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
        public List<Customer> searchCustomerByName()
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
        }
        public void addCustomer()
        {
            createConnection();

            string query = "exec insertIntoCustomer @FullName, @Email , @Address, @Phone, @Gender, @BirthOfDate";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("FullName", FullName);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Address", Address);
            cmd.Parameters.AddWithValue("Phone", Phone);
            cmd.Parameters.AddWithValue("Gender", Gender);
            cmd.Parameters.AddWithValue("BirthOfDate", BirthOfDate);

            cmd.ExecuteNonQuery();

            closeConnection();
        }
        public void deleteCustomer()
        {
            createConnection();

            string query = " ";
            SqlCommand cmd = new SqlCommand(query, conn);
            

            cmd.ExecuteNonQuery();

            closeConnection();
        }

    }
}
