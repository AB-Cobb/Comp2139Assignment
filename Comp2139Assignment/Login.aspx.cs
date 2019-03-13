using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                /*
                string role;
                if (txtUsername.Text == "admin@isp.net" && txtPassword.Text == "p@ssword1")
                    role = "Admin";
                else if (txtUsername.Text == "tech@isp.net" && txtPassword.Text == "p@ssword2")
                    role = "Technician";
                else if (txtUsername.Text == "user@isp.net" && txtPassword.Text == "p@ssword3")
                    role = "Client";
                else
                {
                    lblInvalidPassword.Visible = true;
                    return;
                }
                // */

                Session["User"] = Comp2139Assignment.User.login(txtUsername.Text, txtPassword.Text);
                if (Session["User"] != null)
                    Response.Redirect("~/HomePage.aspx");
                lblInvalidPassword.Visible = true;
                return;
                
            }
        }
    }
}