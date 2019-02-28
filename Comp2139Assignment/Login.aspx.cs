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
                User user = new User();
                if (txtUsername.Text == "admin@isp.net" && txtPassword.Text == "p@ssword1")
                    user.role = "Admin";
                else if (txtUsername.Text == "tech@isp.net" && txtPassword.Text == "p@ssword2")
                    user.role = "Technician";
                else if (txtUsername.Text == "user@isp.net" && txtPassword.Text == "p@ssword3")
                    user.role = "Client";
                else
                {
                    lblInvalidPassword.Visible = true;
                    return;
                }
                user.username = txtUsername.Text;
                user.password = txtPassword.Text;
                Session["User"] = user;
                Response.Redirect("~/HomePage.aspx");
            }
        }
    }
}