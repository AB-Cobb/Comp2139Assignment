using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace Comp2139Assignment
{
    static class TKPdb
    {
        static  string dir = System.IO.Path.GetFullPath(@"..\..\") + @"app_data\TKPdb.mdf";
        static private string conn = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dir};Integrated Security=True";
        static private SqlConnection conection = new SqlConnection(conn);

        static public DataTable getContactList()
        {
            conection.Open();
            SqlCommand cmdGetContactList = conection.CreateCommand();
            cmdGetContactList.CommandType = CommandType.Text;
            cmdGetContactList.CommandText = ("SELECT * FROM customers WHERE OnContactList = 1;");
            DataTable contactList = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetContactList);
            sAdapter.Fill(contactList);
            conection.Close();
            return contactList;
        }

        static public DataTable getAllCustomers()
        {
            conection.Open();
            SqlCommand cmdGetAllCustomers = conection.CreateCommand();
            cmdGetAllCustomers.CommandType = CommandType.Text;
            cmdGetAllCustomers.CommandText = ("SELECT * FROM customers WHERE OnContactList = 1;");
            DataTable custList = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetAllCustomers);
            sAdapter.Fill(custList);
            conection.Close();
            return custList;
        }



        static public DataRow getCustomerById(int id)
        {
            conection.Open();
            SqlCommand cmdGetCustomerById = conection.CreateCommand();
            cmdGetCustomerById.CommandType = CommandType.Text;
            cmdGetCustomerById.Parameters.AddWithValue("@customerId", id);
            cmdGetCustomerById.CommandText = ("SELECT * FROM customers WHERE CustomerId = @customerId;");
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
            cmdUpdateCustomer.CommandText = "IF NOT @customerId = -1 OR NOT NULL (SELECT * FROM Customers WHERE CustomerId = @customerId)" +
                                                "BEGIN UPDATE customers SET Fname = @fname, Lname = @lname, Address = @Address,  WHERE CustomerId = @customerId END" +
                                                "ELSE BEGIN INSERT INTO customers (Email, Fname, Lname, Address, PhoneNum, Position, OnContactList) VALUES @email, @lname, @fname, @address, @phoneNum, @position, @OnContactList END;";
            cmdUpdateCustomer.ExecuteNonQuery();
            conection.Close();
        }

        static public void updateIncident (Incident incident)
        {
            conection.Open();
            SqlCommand cmdUpdateIncident = conection.CreateCommand();
            cmdUpdateIncident.CommandType = CommandType.Text;

            cmdUpdateIncident.Parameters.AddWithValue("@incidentId", incident.incidentId);
            cmdUpdateIncident.Parameters.AddWithValue("@customerId", incident.customerId);
            cmdUpdateIncident.Parameters.AddWithValue("@status", incident.status);
            cmdUpdateIncident.Parameters.AddWithValue("@date", incident.date);
            cmdUpdateIncident.Parameters.AddWithValue("@description", incident.description);
            cmdUpdateIncident.Parameters.AddWithValue("@methodOfContact", incident.methodOfContact);

            cmdUpdateIncident.CommandText = "IF NOT @incidentId = -1 OR EXISTS (SELECT * FROM incident WHERE incidentId = @incidentId)" +
                                                "BEGIN UPDATE incident SET date = @date, status = @status, description = @description,  WHERE incidentId = @incidentId END" +
                                                "ELSE BEGIN INSERT INTO incident (customerId, status, date, description, methodeOfContact)" +
                                                " VALUES @incidentId, @customerId, @status, @date, @description, @methodOfContact END;";
            cmdUpdateIncident.ExecuteNonQuery();
            conection.Close();


        }
        static public DataTable getIncidentsByCustomerEmail (string email)
        {
            conection.Open();
            SqlCommand getIncidentsByCustmerEmail = conection.CreateCommand();
            getIncidentsByCustmerEmail.CommandType = CommandType.Text;
            getIncidentsByCustmerEmail.Parameters.AddWithValue("@email", email);
            getIncidentsByCustmerEmail.CommandText = "SELECT * FROM incidents WHERE customerid LIKE (SELECECT customerid FROM customer WHERE email LIKE @email);";
            DataTable custList = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(getIncidentsByCustmerEmail);
            sAdapter.Fill(custList);
            conection.Close();
            return custList;
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
        static public DataRow getSurveyByInicidentId (int id)
        {
            conection.Open();
            SqlCommand cmdGetSurveyByInicidentId = conection.CreateCommand();
            cmdGetSurveyByInicidentId.Parameters.AddWithValue("@id", id);
            cmdGetSurveyByInicidentId.CommandText = ("SELECT * FROM survey WHERE incidentid = @id;");
            DataTable survey = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetSurveyByInicidentId);
            sAdapter.Fill(survey);
            conection.Close();
            return survey.Rows[0];
        }
        static public DataRow getSurveyBySurveyId(int id)
        {
            conection.Open();
            SqlCommand cmdGetSurveyByInicidentId = conection.CreateCommand();
            cmdGetSurveyByInicidentId.Parameters.AddWithValue("@id", id);
            cmdGetSurveyByInicidentId.CommandText = "SELECT * FROM survey WHERE surveyid = @id;";
            DataTable survey = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetSurveyByInicidentId);
            sAdapter.Fill(survey);
            conection.Close();
            return survey.Rows[0];
        }

        static public DataTable getSurveysByCustomerId(int id)
        {
            conection.Open();
            SqlCommand cmdGetSurveysByCustomerId = conection.CreateCommand();
            cmdGetSurveysByCustomerId.Parameters.AddWithValue("@id", id);
            cmdGetSurveysByCustomerId.CommandText = "SELECT * FROM survey s WHERE s.incidentid IN" +
                " SELECT i.incidentid FROM incidents i WHERE customerid = @id;";
            DataTable surveys = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetSurveysByCustomerId);
            sAdapter.Fill(surveys);
            conection.Close();
            return surveys;
        }
        static public bool checkUserName(string name)
        {
            conection.Open();
            SqlCommand cmdCheckUserName = conection.CreateCommand();
            cmdCheckUserName.Parameters.AddWithValue("@email", name);
            cmdCheckUserName.CommandText = "SELECT * FROM Customers WHERE email like @email;";
            DataTable check = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdCheckUserName);
            sAdapter.Fill(check);
            conection.Close();
            return check.Rows.Count > 0;
        }
        static public void updateSurvey(Survey survey)
        {
            conection.Open();
            SqlCommand cmdUpdateSurvey = conection.CreateCommand();
            cmdUpdateSurvey.Parameters.AddWithValue("@surveyId", survey.surveyId);
            cmdUpdateSurvey.Parameters.AddWithValue("@incidentId", survey.incidentId);
            cmdUpdateSurvey.Parameters.AddWithValue("@resolution", survey.resolution);
            cmdUpdateSurvey.Parameters.AddWithValue("@responeseTime", survey.responeseTime);
            cmdUpdateSurvey.Parameters.AddWithValue("@efficentcy", survey.efficentcy);
            cmdUpdateSurvey.Parameters.AddWithValue("@comments", survey.comments);
            cmdUpdateSurvey.CommandText = "IF NOT @surveyId = -1 OR NOT NULL(SELECT * FROM surveys WHERE SurveyId = @surveyId)" +
                                                "BEGIN UPDATE survey SET resolution = @resolution, responeseTime = @responeseTime, efficentcy = @efficentcy, comments = @comments WHERE surveyId = @surveyId END" +
                                                "ELSE BEGIN INSERT INTO survey (surveyId, incidentId, resolution, responeseTime, efficentcy, comments) VALUES @surveyId, @incidentId, @resolution, @responeseTime, @efficentcy, @comments;";
            cmdUpdateSurvey.ExecuteNonQuery();
            conection.Close();
        }
        static public void register (string email, string password, string fName, string lName)
        {
            conection.Open();
            SqlCommand cmdRegister = conection.CreateCommand();
            cmdRegister.Parameters.AddWithValue("@email", email);
            cmdRegister.Parameters.AddWithValue("@passwird", password);
            cmdRegister.Parameters.AddWithValue("@fname", fName);
            cmdRegister.Parameters.AddWithValue("@lname", lName);
            cmdRegister.CommandText = "INSERT INTO user (email, password) VALUES @email, @password;" +
                " INSERT INTO user_role (email, role) VALUES @email 'client';" +
                " INSERT INTO customr (email, fname, lname) VALUES @email, @fname, @lname;";
            cmdRegister.ExecuteNonQuery();
            conection.Close();
        }
    }   


}
