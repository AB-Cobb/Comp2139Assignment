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
            Customer customer = Customer.getCustomerByEmail(user.email);
            lblTextOne.Text = "Thank you for registering " + customer.fname + " " + customer.email + "!";
            lblTextTwo.Text = "A confirmation email has been sent to " + customer.email + " to verify your registration";
        }

        protected void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}