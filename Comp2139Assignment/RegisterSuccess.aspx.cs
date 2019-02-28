using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class RegisterSuccess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            lblTextOne.Text = "Thank you for registering " + user.firstName + " " + user.lastName + "!";
            lblTextTwo.Text = "A confirmation email has been sent to " + user.emailAddress + " to verify your registration";
        }

        protected void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}