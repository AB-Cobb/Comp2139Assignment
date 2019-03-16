using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                if (Session["User"] == null)
                    Response.Redirect("~/Login.aspx");
                else
                {
                    Customer customer = Customer.getCustomerByEmail(((User)Session["User"]).email);
                    /*
                    User user = (User)Session["User"];
                    */
                    txtProfileName.Text = customer.profileName;
                    txtUsername.Text = customer.email;
                    //txtPassword.Text = customer.password;
                    txtFirstName.Text = customer.fname;
                    txtLastName.Text = customer.lname;
                    txtPosition.Text = customer.position;
                    //ddlSecretQuestion.SelectedValue = customer.secretQuestion;
                    //txtSecretAwnser.Text = customer.secretAnswer;
                    txtEmail.Text = customer.email;
                    // */
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid && Comp2139Assignment.User.login(txtUsername.Text, txtPassword.Text) != null)
            {

                Customer customer = Customer.getCustomerByEmail(((User)Session["User"]).email);
                
                //User user = (User)Session["User"];
                customer.profileName = txtProfileName.Text;
                customer.fname = txtFirstName.Text;
                customer.lname = txtLastName.Text;
                customer.position = txtPosition.Text;
                //customer.secretQuestion = ddlSecretQuestion.SelectedValue;
                //customer.secretAnswer = txtSecretAwnser.Text;
                customer.save();
                //Session["User"] = user;
                Response.Redirect("~/HomePage.aspx");
                // */
            }
        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UpdatePassword.aspx");                                           
        }
    }
}