using GETForms.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private string _connectionString;

        public CustomerDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Searches for customers.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <returns></returns>
        public IList<Customer> SearchForCustomers(string search, string sortBy)
        {
            IList<Customer> customers = new List<Customer>();

            string sqlCommand = "SELECT first_name, last_name, email, active FROM customer WHERE last_name LIKE @search OR first_name LIKE @search ORDER BY " + sortBy;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlCommand, conn);

                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(MapRowToCustomer(reader));
                }
            }

            return customers;
            
        }

        /// <summary>
        /// Maps a sql data row to an actor object.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Customer MapRowToCustomer(SqlDataReader reader)
        {
            int isActiveNum = Convert.ToInt32(reader["active"]);

            Customer customer = new Customer();

            if(isActiveNum == 0)
            {
                customer.IsActive = false;
            }
            else
            {
                customer.IsActive = true;
            }

            customer.FirstName = Convert.ToString(reader["first_name"]);
            customer.LastName = Convert.ToString(reader["last_name"]);
            customer.Email = Convert.ToString(reader["email"]);

            return customer;            
        }
    }
}
