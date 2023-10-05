using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.DataAcessLayer.Models;

namespace WebApplication2.DataAcessLayer
{
    public class DbContext
    {
        private SqlConnection SqlConnection;
        private SqlCommand sqlCommand;

        public DbContext()
        {
            SqlConnection = new SqlConnection("server=MFTMASTER1\\TNC;database=Amlak;trusted_connection=true");
            sqlCommand = new SqlCommand("", SqlConnection);
        }
        public List<Customer> GetCustomers()
        {
            List<Customer> ListCustomers = new List<Customer>();

            SqlConnection.Open();
            sqlCommand.CommandText = "select * from Customers";
            SqlDataReader sqlDataReader= sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.Id = sqlDataReader.GetInt64(0);
                customer.FirstName = sqlDataReader.GetString(1);
                customer.LastName=sqlDataReader.GetString(2);
                customer.CodeMelli=sqlDataReader.GetString(3);
                customer.Mobile = sqlDataReader.GetString(4);
                customer.Address = sqlDataReader.GetString(5);
                ListCustomers.Add(customer);
            }
            SqlConnection.Close();
            return ListCustomers;
        }
    }
}