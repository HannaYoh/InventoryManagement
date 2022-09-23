using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement.Models
{
    internal class Employee : DBConnection
    {
        //variables
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string BackupPassword { get; set; }
        public string Gender { get; set; }
        public string Roll { get; set; }
        public string DateOfBirth { get; set; }
        public int DepId { get; set; }

        //methods
        public bool adminAuthentication()
        {
            createConnection();

            List<Employee> adminList = new List<Employee>();

            string query = "exec SelectAdmin @Email, @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Password", Password);


            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Employee temp = new Employee();
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

