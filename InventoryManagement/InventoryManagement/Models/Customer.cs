using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagement.Models
{
    internal class Customer : DBConnection
    {
        //variables
        public int CustId { get; set; }



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




    }
}
