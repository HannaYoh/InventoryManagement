using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement.Models
{
    internal class Admin : DBConnection
    {
        //variables
        public int AdminId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string BackupPassword { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }

        //methods
        public bool adminAuthentication()
        {
            createConnection();

            List<Admin> adminList = new List<Admin>();

            string query = "exec SelectOneAdmin @Email, @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Password", Password);


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Admin temp = new Admin();
                temp.Email = reader["Email"].ToString();
                temp.Password = reader["Password"].ToString();
                adminList.Add(temp);

                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }

    }
}

