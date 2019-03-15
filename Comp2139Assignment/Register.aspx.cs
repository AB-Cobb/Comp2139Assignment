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
                Comp2139Assignment.User.register(txtEmail.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text);
                Session["RegEmail"] = txtEmail.Text;
                Response.Redirect("~/RegisterSuccess.aspx");
            }
        }

        protected void checkEmail(object source, ServerValidateEventArgs args)
        {
            args.IsValid = !Comp2139Assignment.User.checkEmail(txtEmail.Text);
        }
    }
}