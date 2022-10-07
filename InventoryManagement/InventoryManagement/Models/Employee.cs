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
        public string NewEmail { get; set; }
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

        public bool staffAuthentication()
        {
            createConnection();

            List<Employee> staffList = new List<Employee>();

            string query = "exec SelectStaff @Email, @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Password", Password);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Employee temp = new Employee();
                temp.Email = reader["Email"].ToString();
                temp.Password = reader["Password"].ToString();
                staffList.Add(temp);

                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }

        public Employee returnEmployeeInfo()
        {
            createConnection();           

            string query = "select * from returnEmployeeInfo(@Email)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Email", Email);

            SqlDataReader reader = cmd.ExecuteReader();

            Employee temp = new Employee();

            while (reader.Read())
            {
                temp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                temp.FullName = reader["FullName"].ToString();
                temp.Email = reader["Email"].ToString();
                temp.Address = reader["Address"].ToString();
                temp.Phone = reader["Phone"].ToString();
                temp.Password = reader["Password"].ToString();
                temp.BackupPassword = reader["BackupPassword"].ToString();
                temp.Gender = reader["Gender"].ToString();
                temp.DateOfBirth = reader["DateOfBirth"].ToString();
                temp.Roll = reader["Roll"].ToString();
                temp.DepId = Convert.ToInt32(reader["DepId"]);            
            }
            closeConnection();
            return temp;
        }
        public void updateEmployeeInfo()
        {
            createConnection();

            string query = "exec updateEmployeeInfo @FullName, @Email, @NewEmail, @Address, @Phone, @Password, @DateOfBirth, @DepId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("FullName", FullName);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("NewEmail", NewEmail);
            cmd.Parameters.AddWithValue("Address", Address);
            cmd.Parameters.AddWithValue("Phone", Phone);
            cmd.Parameters.AddWithValue("Password", Password);
            cmd.Parameters.AddWithValue("DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("DepId", DepId);

            cmd.ExecuteNonQuery();

            closeConnection();

        }

        public void addEmployee()
        {
            createConnection();

            string query = "exec addEmployee @FullName, @Email, @Address, @Phone, @Password, @BackupPassword, @Gender, @DateOfBirth, @Roll, @DepId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("FullName", FullName);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Address", Address);
            cmd.Parameters.AddWithValue("Phone", Phone);
            cmd.Parameters.AddWithValue("Password", Password);
            cmd.Parameters.AddWithValue("BackupPassword", BackupPassword);
            cmd.Parameters.AddWithValue("Gender", Gender);
            cmd.Parameters.AddWithValue("DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("Roll", Roll);      
            cmd.Parameters.AddWithValue("DepId", DepId);

            cmd.ExecuteNonQuery();

            closeConnection();

        }



    }
}

