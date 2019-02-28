using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void CustomValidatorTermsOfService_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (chkTermsOfService.Checked == false)
            {
                args.IsValid = false;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                User user = new User();
                user.emailAddress = txtEmail.Text;
                user.role = "Client";
                user.firstName = txtFirstName.Text;
                user.lastName = txtLastName.Text;
                user.username = txtEmail.Text;
                user.password = txtPassword.Text;
                Session["User"] = user;
                Response.Redirect("~/RegisterSuccess.aspx");
            }
        }
    }
}