using System.Collections.Generic;
using System.Data;
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
            SqlConnection = new SqlConnection("server=DESKTOP-DMMGNAE;database=Amlak;trusted_connection=true");
            sqlCommand = new SqlCommand("", SqlConnection);
        }

        public DataTable SearchCustomers(string searchText)
        {
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

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataSet customers = new DataSet();

            adapter.Fill(customers, "Moshtariha");

            SqlConnection.Close();
            return customers.Tables["Moshtariha"];
        }
        public void DeleteCustomer(long customerId)
        {
            SqlConnection.Open();
            sqlCommand.CommandText =
                $"delete from customers where Id={customerId}";
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }
        public void AddCustomer(Customer moshtariJadid)
        {
            SqlConnection.Open();
            sqlCommand.CommandText = $@"insert into customers values(
                                        N'{moshtariJadid.FirstName}',
                                        N'{moshtariJadid.LastName}',
                                        N'{moshtariJadid.CodeMelli}',
                                        N'{moshtariJadid.Mobile}',
                                        N'{moshtariJadid.Address}')";
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }

        public void UpdateCustomer(Customer moshtari)
        {
            SqlConnection.Open();
            sqlCommand.CommandText = $@"update customers set 
                                      FirstName=N'{moshtari.FirstName}',
                                      LastName=N'{moshtari.LastName}',
                                      CodeMelli=N'{moshtari.CodeMelli}',
                                      Mobile=N'{moshtari.Mobile}',
                                      Address=N'{moshtari.Address}'
                                      where Id={moshtari.Id}";
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }
        public Customer GetById(long customerId)
        {
            SqlConnection.Open();
            sqlCommand.CommandText = 
                $"select * from customers where Id={customerId}";

            SqlDataReader reader = sqlCommand.ExecuteReader();

            Customer moshtari = new Customer();
            while(reader.Read())
            {
                moshtari.Id = reader.GetInt64(0);
                moshtari.FirstName = reader.GetString(1);
                moshtari.LastName = reader.GetString(2);
                moshtari.CodeMelli = reader.GetString(3);
                moshtari.Mobile = reader.GetString(4);
                moshtari.Address = reader.GetString(5);
                moshtari.Birthdate = reader.GetDateTime(6);
                moshtari.CodePosti = reader.GetString(7);
                moshtari.ImageUrl = reader.GetString(8);
                moshtari.FatherName = reader.GetString(9);
            }

            return moshtari;
        }
    }
}