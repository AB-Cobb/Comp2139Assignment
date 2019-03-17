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
                string emailMessage = $"<h1>Hello {txtFirstName.Text} {txtLastName.Text}</h1><br>" +
                    $"We have received your Registration Tech Know Pro incident repoting please for:" +
                    $" <br> {txtEmail.Text} <br>" +
                    $"please go to {HttpContext.Current.Request.ApplicationPath} to login";
                TKPemail.sendEmail(txtEmail.Text, "TKP Registration Received", emailMessage);
                Comp2139Assignment.User.register(txtEmail.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text);
                Response.Redirect("~/RegisterSuccess.aspx");
            }
        }

        protected void checkEmail(object source, ServerValidateEventArgs args)
        {
            args.IsValid = !Comp2139Assignment.User.checkEmail(txtEmail.Text);
        }
    }
}