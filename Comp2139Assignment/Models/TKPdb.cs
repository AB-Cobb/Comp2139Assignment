using System;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace Comp2139Assignment
{
    static class TKPdb
    {
        //static  string dir = System.IO.Path.GetFullPath(@"..\..\") + @"app_data\TKPdb.mdf";
        //static string dir = @"C:\Users\andre\source\repos\Comp2139Assignment\Comp2139Assignment\App_Data\TKPdb.mdf";
        static string dir = "|DataDirectory|TKPdb.mdf";
        static private string conn = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dir};Integrated Security=False";
        static private SqlConnection conection = new SqlConnection(conn);

        static public DataTable getContactList()
        {
            conection.Open();
            SqlCommand cmdGetContactList = conection.CreateCommand();
            cmdGetContactList.CommandType = CommandType.Text;
            cmdGetContactList.CommandText = "SELECT * FROM customer WHERE OnContactList = 1;";
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
            cmdGetAllCustomers.CommandText = "SELECT * FROM customer;";
            DataTable custList = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetAllCustomers);
            sAdapter.Fill(custList);
            conection.Close();
            return custList;
        }

        static public void updatePassword(string email, string password)
        {
            if (checkUserName(email))
            {
                conection.Open();
                SqlCommand cmdUpdatePassword = conection.CreateCommand();
                cmdUpdatePassword.CommandType = CommandType.Text;
                cmdUpdatePassword.Parameters.AddWithValue("@email", email);
                cmdUpdatePassword.Parameters.AddWithValue("@password", password);
                cmdUpdatePassword.CommandText = "UPDATE [user] SET password = @password WHERE email like @email";
                cmdUpdatePassword.ExecuteNonQuery();
                conection.Close();
            }
        }

        static public DataRow getCustomerById(int id)
        {
            conection.Open();
            SqlCommand cmdGetCustomerById = conection.CreateCommand();
            cmdGetCustomerById.CommandType = CommandType.Text;
            cmdGetCustomerById.Parameters.AddWithValue("@customerId", id);
            cmdGetCustomerById.CommandText = "SELECT * FROM customer WHERE CustomerId = @customerId;";
            DataTable cust = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetCustomerById);
            sAdapter.Fill(cust);
            conection.Close();
            return cust.Rows[0];
        }
        static public DataRow getIncidentById(int id)
        {
           
            conection.Open();
            SqlCommand cmdGetIncidentById = conection.CreateCommand();
            cmdGetIncidentById.CommandType = CommandType.Text;
            cmdGetIncidentById.Parameters.AddWithValue("@incidentId", id);
            cmdGetIncidentById.CommandText = "SELECT * FROM incident WHERE incidentId = @incidentId;";
            DataTable incid = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetIncidentById);
            sAdapter.Fill(incid);
            conection.Close();
            return incid.Rows[0];
        }

        static public DataRow getCustomerByEmail(string email)
        {
            conection.Open();
            SqlCommand cmdGetCustomerByEmail = conection.CreateCommand();
            cmdGetCustomerByEmail.CommandType = CommandType.Text;
            cmdGetCustomerByEmail.Parameters.AddWithValue("@email", email);
            cmdGetCustomerByEmail.CommandText = "SELECT * FROM customer WHERE email = @email;";
            DataTable cust = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdGetCustomerByEmail);
            sAdapter.Fill(cust);
            conection.Close();
            return cust.Rows[0];
        }

        static public void updateCustomer(Customer cust)
        {          
            //check if customer already exists
            if (checkUserName(cust.email))
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
                cmdUpdateCustomer.Parameters.AddWithValue("@secretQuestion", String.IsNullOrEmpty(cust.secretQuestion) ? SqlString.Null : cust.secretQuestion);
                cmdUpdateCustomer.Parameters.AddWithValue("@secretAnswer", String.IsNullOrEmpty(cust.secretAnswer) ? SqlString.Null : cust.secretAnswer);
                cmdUpdateCustomer.Parameters.AddWithValue("@OnContactList", cust.onContactList);
                cmdUpdateCustomer.CommandText = "UPDATE customer SET Fname = @fname, Lname = @lname, Address = @Address, PhoneNum = @phoneNum,  Position = @position, SecretQuestion = @secretQuestion, SecretAnswer = @secretAnswer, OnContactList = @OnContactList" +

                    " WHERE CustomerId = @customerId ;";
                cmdUpdateCustomer.ExecuteNonQuery();
            }
            else
            {
                conection.Open();
                SqlCommand cmdCreateCustomer = conection.CreateCommand();
                cmdCreateCustomer.CommandType = CommandType.Text;
                cmdCreateCustomer.Parameters.AddWithValue("@customerId", cust.customerId);
                cmdCreateCustomer.Parameters.AddWithValue("@email", cust.email);
                cmdCreateCustomer.Parameters.AddWithValue("@lname", cust.lname);
                cmdCreateCustomer.Parameters.AddWithValue("@fname", cust.fname);
                cmdCreateCustomer.Parameters.AddWithValue("@address", cust.address);
                cmdCreateCustomer.Parameters.AddWithValue("@phoneNum", String.IsNullOrEmpty(cust.phoneNum) ? SqlString.Null : cust.phoneNum);
                cmdCreateCustomer.Parameters.AddWithValue("@position", String.IsNullOrEmpty(cust.position) ? SqlString.Null : cust.position);
                cmdCreateCustomer.Parameters.AddWithValue("@OnContactList", cust.onContactList);
                cmdCreateCustomer.CommandText = "INSERT INTO customer (Email, Fname, Lname, Address, PhoneNum, Position, OnContactList) VALUES (@email, @lname, @fname, @address, @phoneNum, @position, @OnContactList );";
                cmdCreateCustomer.ExecuteNonQuery();
            }
            conection.Close();
        }

        static private bool checkIncidentById(int id)
        {
            conection.Open();
            SqlCommand cmdCheckIncident = conection.CreateCommand();
            cmdCheckIncident.Parameters.AddWithValue("@id", id);
            cmdCheckIncident.CommandText = "SELECT * FROM Incident WHERE IncidentId = @id;";
            DataTable check = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdCheckIncident);
            sAdapter.Fill(check);
            conection.Close();
            return check.Rows.Count > 0;
        }

        static public void updateIncident (Incident incident)
        {
            if (checkIncidentById(incident.incidentId)){
                conection.Open();
                SqlCommand cmdUpdateIncident = conection.CreateCommand();
                cmdUpdateIncident.CommandType = CommandType.Text;

                cmdUpdateIncident.Parameters.AddWithValue("@incidentId", incident.incidentId);
                cmdUpdateIncident.Parameters.AddWithValue("@customerId", incident.customerId);
                cmdUpdateIncident.Parameters.AddWithValue("@status", incident.status);
                cmdUpdateIncident.Parameters.AddWithValue("@date", incident.date);
                cmdUpdateIncident.Parameters.AddWithValue("@description", incident.description);
                cmdUpdateIncident.Parameters.AddWithValue("@methodOfContact", incident.methodOfContact);

                cmdUpdateIncident.CommandText = "UPDATE incident SET date = @date, status = @status, description = @description, methodOfContact = @methodOfContact WHERE incidentId = @incidentId;";
                cmdUpdateIncident.ExecuteNonQuery();
            }
            else
            {
                conection.Open();
                SqlCommand cmdCreateIncident = conection.CreateCommand();
                cmdCreateIncident.CommandType = CommandType.Text;

                cmdCreateIncident.Parameters.AddWithValue("@customerId", incident.customerId);
                cmdCreateIncident.Parameters.AddWithValue("@status", incident.status);
                cmdCreateIncident.Parameters.AddWithValue("@date", incident.date);
                cmdCreateIncident.Parameters.AddWithValue("@description", incident.description);
                cmdCreateIncident.Parameters.AddWithValue("@methodOfContact", incident.methodOfContact);

                cmdCreateIncident.CommandText = "INSERT INTO incident (customerId, status, date, description, methodOfContact)" +
                                                    " VALUES (@customerId, @status, @date, @description, @methodOfContact);";
                cmdCreateIncident.ExecuteNonQuery();
            }
            conection.Close();
        }

        static public DataTable getIncidentsByCustomerEmail (string email)
        {
            conection.Open();
            SqlCommand getIncidentsByCustmerEmail = conection.CreateCommand();
            getIncidentsByCustmerEmail.CommandType = CommandType.Text;
            getIncidentsByCustmerEmail.Parameters.AddWithValue("@email", email);
            getIncidentsByCustmerEmail.CommandText = "SELECT * FROM incident WHERE customerid LIKE (SELECT customerid FROM customer WHERE email LIKE @email);";
            DataTable custList = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(getIncidentsByCustmerEmail);
            sAdapter.Fill(custList);
            conection.Close();
            return custList;
        }

        static public DataTable getIncidentsForSurvey(string email)
        {
            conection.Open();
            SqlCommand getIncidentsByCustmerEmail = conection.CreateCommand();
            getIncidentsByCustmerEmail.CommandType = CommandType.Text;
            getIncidentsByCustmerEmail.Parameters.AddWithValue("@email", email);
            getIncidentsByCustmerEmail.CommandText = "SELECT * FROM incident i WHERE customerid LIKE (SELECT customerid FROM customer WHERE email LIKE @email)" +
                " AND i.incidentId NOT IN (SELECT s.incidentId FROM Survey s);";
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
            cmdCheckLogin.CommandText = $"SELECT * FROM [user] WHERE Email = @email AND password like @password;";
            DataTable userData = new DataTable();
                SqlDataAdapter sAdapter = new SqlDataAdapter(cmdCheckLogin);
            sAdapter.Fill(userData);
            if (userData == null || userData.Rows.Count == 0) {
                conection.Close();
                return "Denied";
            }
            SqlCommand cmdGetRole = conection.CreateCommand();
            cmdGetRole.Parameters.AddWithValue("@email", email);
            cmdGetRole.CommandText = "SELECT role FROM User_Role WHERE email = @email;";
            DataTable role = new DataTable();
            sAdapter = new SqlDataAdapter(cmdGetRole);
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
                " (SELECT i.incidentid FROM incident i WHERE customerid = @id);";
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
            cmdCheckUserName.CommandText = "SELECT * FROM Customer WHERE email like @email;";
            DataTable check = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdCheckUserName);
            sAdapter.Fill(check);
            conection.Close();
            return check.Rows.Count > 0;
        }
        static private bool checkSurveyById (int id)
        {
            conection.Open();
            SqlCommand cmdCheckSurvey = conection.CreateCommand();
            cmdCheckSurvey.Parameters.AddWithValue("@id", id);
            cmdCheckSurvey.CommandText = "SELECT * FROM Survey WHERE SurveyId = @id;";
            DataTable check = new DataTable();
            SqlDataAdapter sAdapter = new SqlDataAdapter(cmdCheckSurvey);
            sAdapter.Fill(check);
            conection.Close();
            return check.Rows.Count > 0;
        }
        static public void updateSurvey(Survey survey)
        {
            if (checkSurveyById(survey.surveyId))
            {
                conection.Open();
                SqlCommand cmdUpdateSurvey = conection.CreateCommand();
                cmdUpdateSurvey.Parameters.AddWithValue("@surveyId", survey.surveyId);
                cmdUpdateSurvey.Parameters.AddWithValue("@resolution", survey.resolution);
                cmdUpdateSurvey.Parameters.AddWithValue("@responeseTime", survey.responeseTime);
                cmdUpdateSurvey.Parameters.AddWithValue("@efficentcy", survey.efficentcy);
                cmdUpdateSurvey.Parameters.AddWithValue("@comments", survey.comments);
                cmdUpdateSurvey.CommandText = "UPDATE survey SET resolution = @resolution, ResponseTime = @responeseTime, efficentcy = @efficentcy, comments = @comments WHERE surveyId = @surveyId;";
                cmdUpdateSurvey.ExecuteNonQuery();
            }
            else
            {
                conection.Open();
                SqlCommand cmdCreateSurvey = conection.CreateCommand();
                cmdCreateSurvey.Parameters.AddWithValue("@incidentId", survey.incidentId);
                cmdCreateSurvey.Parameters.AddWithValue("@resolution", survey.resolution);
                cmdCreateSurvey.Parameters.AddWithValue("@responeseTime", survey.responeseTime);
                cmdCreateSurvey.Parameters.AddWithValue("@efficentcy", survey.efficentcy);
                cmdCreateSurvey.Parameters.AddWithValue("@comments", survey.comments);
                cmdCreateSurvey.CommandText = "INSERT INTO survey(incidentId, resolution, ResponseTime, efficentcy, comments) VALUES( @incidentId, @resolution, @responeseTime, @efficentcy, @comments);";
                cmdCreateSurvey.ExecuteNonQuery();
            }
            /*
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
                                                "ELSE BEGIN INSERT INTO survey (surveyId, incidentId, resolution, responeseTime, efficentcy, comments) VALUES (@surveyId, @incidentId, @resolution, @responeseTime, @efficentcy, @comments);";
            cmdUpdateSurvey.ExecuteNonQuery();
            
            // */
            conection.Close();
        }

        static public void register (string email, string password, string fName, string lName)
        {
            conection.Open();
            SqlCommand cmdRegister = conection.CreateCommand();
            cmdRegister.Parameters.AddWithValue("@email", email);
            cmdRegister.Parameters.AddWithValue("@password", password);
            cmdRegister.Parameters.AddWithValue("@fname", fName);
            cmdRegister.Parameters.AddWithValue("@lname", lName);
            cmdRegister.CommandText = "INSERT INTO [user] (email, password) VALUES (@email, @password);" +
                " INSERT INTO user_role (email, role) VALUES (@email, 'Client');" +
                " INSERT INTO customer (email, fname, lname, OnContactList) VALUES (@email, @fname, @lname, 0);";
            cmdRegister.ExecuteNonQuery();
            conection.Close();
        }
    }   
}
