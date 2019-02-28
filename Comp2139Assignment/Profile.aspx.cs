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
                    User user = (User)Session["User"];
                    txtProfileName.Text = user.profileName;
                    txtUsername.Text = user.username;
                    txtPassword.Text = user.password;
                    txtFirstName.Text = user.firstName;
                    txtLastName.Text = user.lastName;
                    txtPosition.Text = user.position;
                    ddlSecretQuestion.SelectedValue = user.secretQuestion;
                    txtSecretAwnser.Text = user.secretAnswer;
                    txtEmail.Text = user.emailAddress;
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
                User user = (User)Session["User"];
                user.profileName = txtProfileName.Text;
                user.username = txtUsername.Text;
                user.password = txtPassword.Text;
                user.firstName = txtFirstName.Text;
                user.lastName = txtLastName.Text;
                user.position = txtPosition.Text;
                user.secretQuestion = ddlSecretQuestion.SelectedValue;
                user.secretAnswer = txtSecretAwnser.Text;
                user.emailAddress = txtEmail.Text;
                Session["User"] = user;
                Response.Redirect("~/HomePage.aspx");
            }
        }
    }
}