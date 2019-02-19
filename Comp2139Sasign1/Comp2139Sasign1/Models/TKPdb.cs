using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace Comp2139Sasign1
{
    static class TKPdb
    {
        static  string dir = System.IO.Path.GetFullPath(@"..\..\") + @"app_data\TKPdb.mdf";
        static private string conn = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dir};Integrated Security=True";
        static private SqlConnection conection = new SqlConnection(conn);

        static public DataRow getCustomerById(int id)
        {
            conection.Open();
            SqlCommand cmdGetCustomerById = conection.CreateCommand();
            cmdGetCustomerById.CommandType = CommandType.Text;
            cmdGetCustomerById.Parameters.AddWithValue("@customerId", id);
            cmdGetCustomerById.CommandText = ("SELECT * FROM customers WHERE CustomerId = @customerId;");
            cmdGetCustomerById.ExecuteNonQuery();
            DataTable cust = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetCustomerById);
            sAdapter.Fill(cust);
            conection.Close();
            return cust.Rows[0];
        }

        static public DataRow getCustomerByEmail(string email)
        {
            conection.Open();
            SqlCommand cmdGetCustomerByEmail = conection.CreateCommand();
            cmdGetCustomerByEmail.CommandType = CommandType.Text;
            cmdGetCustomerByEmail.Parameters.AddWithValue("@email", email);
            cmdGetCustomerByEmail.CommandText = ("SELECT * FROM customers WHERE email = @email;");
            cmdGetCustomerByEmail.ExecuteNonQuery();
            DataTable cust = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetCustomerByEmail);
            sAdapter.Fill(cust);
            conection.Close();
            return cust.Rows[0];
        }

        static public void updateCustomer(Customer cust)
        {
            conection.Open();
            SqlCommand cmdUpdateCustomer = conection.CreateCommand();
            cmdUpdateCustomer.CommandType = CommandType.Text;

            cmdUpdateCustomer.Parameters.AddWithValue("@customerId", cust.customerId);
            cmdUpdateCustomer.Parameters.AddWithValue("@email", cust.email);
            cmdUpdateCustomer.Parameters.AddWithValue("@lname", cust.lname);
            cmdUpdateCustomer.Parameters.AddWithValue("@fname", cust.fname);
            cmdUpdateCustomer.Parameters.AddWithValue("@address", cust.address);
            cmdUpdateCustomer.Parameters.AddWithValue("@phoneNum", String.IsNullOrEmpty(cust.phoneNum) ? SqlString.Null : cust.phoneNum); 
            cmdUpdateCustomer.Parameters.AddWithValue("@position", String.IsNullOrEmpty(cust.position) ? SqlString.Null : cust.position);
            cmdUpdateCustomer.Parameters.AddWithValue("@OnContactList", cust.onContactList);
            cmdUpdateCustomer.CommandText = ("IF NOT @customerId = -1 OR EXISTS (SELECT * FROM Customers WHERE CustomerId @customerId)" +
                                                "BEGIN UPDATE customers SET Fname = @fname, Lname = @lname, Address = @Address,  WHERE CustomerId = @customerId END" +
                                                "ELSE BEGIN INSERT INTO customers (Email, Fname, Lname, Address, PhoneNum, Position, OnContactList) VALUES @email, @lname, @fname, @address, @phoneNum, @position, @OnContactList END");
            cmdUpdateCustomer.ExecuteNonQuery();
            conection.Close();
        }

        static public string checkLogin (string email, string password)
        {
            conection.Open();
            SqlCommand cmdCheckLogin = conection.CreateCommand();
            cmdCheckLogin.Parameters.AddWithValue("@email", email);
            cmdCheckLogin.Parameters.AddWithValue("@password", password);
            cmdCheckLogin.CommandText = ("IF EXISTS (SELECT * FROM user WHERE Email = @email AND password = password)" +
                                            "BEGIN SECELT role FROM User_Role WHERE email = @email END" +
                                            "ELSE BEGIN SELECT 'Denied' AS Role END");
            DataTable role = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdCheckLogin);
            sAdapter.Fill(role);
            conection.Close();
            return (String)role.Rows[0][0];
        }

        static public void getSurveyByCustomerId(int id)
        {
            conection.Open();
            SqlCommand cmdGetCustomerById = conection.CreateCommand();
            conection.Close();
        }
    }
}
