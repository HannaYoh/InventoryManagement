using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    internal class DiscountDetail : DBConnection
    {
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public string DiscountCode { get; set; }
        public bool Status { get; set; }
        public double DiscountAmount { get; set; }


        public int DiscountDetailId { get; set; }
        public int SupplierId { get; set; }
        public string AppliedDate { get; set; }
        public int RedeemedInTotal { get; set; }

        public List<DiscountDetail> viewAllDiscounts()
        {
            createConnection();

            List<DiscountDetail> list = new List<DiscountDetail>();

            string query = "select * from viewAllDiscounts()";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DiscountDetail temp = new DiscountDetail();

                temp.DiscountId = Convert.ToInt32(reader["DiscountId"]);
                temp.DiscountName = reader["DiscountName"].ToString();
                temp.DiscountCode = reader["DiscountCode"].ToString(); 
                temp.Status = Convert.ToBoolean(reader["Status"]); 
                temp.DiscountDetailId = Convert.ToInt32(reader["DiscountDetailId"]); 
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.AppliedDate = reader["DiscountCode"].ToString();
                temp.RedeemedInTotal = Convert.ToInt32(reader["RedeemedInTotal"]);


                list.Add(temp);
            }

            closeConnection();
            return list;
        }

        public List<DiscountDetail> searchByDiscountId()
        {
            createConnection();

            List<DiscountDetail> list = new List<DiscountDetail>();

            string query = "select * from searchByDiscountId(@DiscountId)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("DiscountId", DiscountId);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DiscountDetail temp = new DiscountDetail();

                temp.DiscountId = Convert.ToInt32(reader["DiscountId"]);
                temp.DiscountName = reader["DiscountName"].ToString();
                temp.DiscountCode = reader["DiscountCode"].ToString();
                temp.Status = Convert.ToBoolean(reader["Status"]);
                temp.DiscountDetailId = Convert.ToInt32(reader["DiscountDetailId"]);
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.AppliedDate = reader["DiscountCode"].ToString();
                temp.RedeemedInTotal = Convert.ToInt32(reader["RedeemedInTotal"]);

                list.Add(temp);
            }

            closeConnection();
            return list;
        }
        public List<DiscountDetail> categoryBySupplierId()
        {
            createConnection();

            List<DiscountDetail> list = new List<DiscountDetail>();

            string query = "select * from categoryByDiscountSupplierId(@SupplierId)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SupplierId", SupplierId);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DiscountDetail temp = new DiscountDetail();

                temp.DiscountId = Convert.ToInt32(reader["DiscountId"]);
                temp.DiscountName = reader["DiscountName"].ToString();
                temp.DiscountCode = reader["DiscountCode"].ToString();
                temp.Status = Convert.ToBoolean(reader["Status"]);
                temp.DiscountDetailId = Convert.ToInt32(reader["DiscountDetailId"]);
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.AppliedDate = reader["DiscountCode"].ToString();
                temp.RedeemedInTotal = Convert.ToInt32(reader["RedeemedInTotal"]);

                list.Add(temp);
            }

            closeConnection();
            return list;
        }
        public List<DiscountDetail> categoryByStatus()
        {
            createConnection();

            List<DiscountDetail> list = new List<DiscountDetail>();

            string query = "select * from categoryByStatus(@Status)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Status", Status);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DiscountDetail temp = new DiscountDetail();

                temp.DiscountId = Convert.ToInt32(reader["DiscountId"]);
                temp.DiscountName = reader["DiscountName"].ToString();
                temp.DiscountCode = reader["DiscountCode"].ToString();
                temp.Status = Convert.ToBoolean(reader["Status"]);
                temp.DiscountDetailId = Convert.ToInt32(reader["DiscountDetailId"]);
                temp.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                temp.AppliedDate = reader["DiscountCode"].ToString();
                temp.RedeemedInTotal = Convert.ToInt32(reader["RedeemedInTotal"]);

                list.Add(temp);
            }

            closeConnection();
            return list;
        }
    }
}
