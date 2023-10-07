using System.Collections.Generic;
using System.Data.SqlClient;
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
       
        public List<Customer> SearchCustomers(string searchText)
        {
            List<Customer> ListCustomers = new List<Customer>();

            SqlConnection.Open();
            if (string.IsNullOrEmpty(searchText))
            {
                sqlCommand.CommandText = "select * from Customers";
            }
            else
            {
                sqlCommand.CommandText = $@"select * from Customers where 
                                        FirstName like N'%{searchText}%' or
                                        LastName like N'%{searchText}%' or
                                        CodeMelli like N'%{searchText}%' or
                                        Mobile like N'%{searchText}%' or
                                        Address like N'%{searchText}%'";
            }
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.Id = sqlDataReader.GetInt64(0);
                customer.FirstName = sqlDataReader.GetString(1);
                customer.LastName = sqlDataReader.GetString(2);
                customer.CodeMelli = sqlDataReader.GetString(3);
                customer.Mobile = sqlDataReader.GetString(4);
                customer.Address = sqlDataReader.GetString(5);
                ListCustomers.Add(customer);
            }
            SqlConnection.Close();
            return ListCustomers;
        }
    }
}