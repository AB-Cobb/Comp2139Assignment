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
                if (!(Session["User"] != null && ((User)Session["User"]).role == "Client" ) )
                    Response.Redirect("~/Login.aspx");
                else
                {
                    Customer customer = Customer.getCustomerByEmail(((User)Session["User"]).email);
                    txtProfileName.Text = customer.name;
                    txtUsername.Text = customer.email;
                    txtFirstName.Text = customer.fname;
                    txtLastName.Text = customer.lname;
                    txtPosition.Text = customer.position;
                    txtAddress.Text = customer.address;
                    txtPhoneNum.Text = customer.phoneNum;
                    ddlSecretQuestion.SelectedValue = customer.secretQuestion;
                    txtSecretAwnser.Text = customer.secretAnswer;
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
            if (Page.IsValid)
            {

                Customer customer = Customer.getCustomerByEmail(((User)Session["User"]).email);
                

                customer.fname = txtFirstName.Text;
                customer.lname = txtLastName.Text;
                customer.position = txtPosition.Text;
                customer.phoneNum = txtPhoneNum.Text;
                customer.address = txtAddress.Text;
                customer.secretQuestion = ddlSecretQuestion.SelectedValue;
                customer.secretAnswer = txtSecretAwnser.Text;
                customer.save();

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