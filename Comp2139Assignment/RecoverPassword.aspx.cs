using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Customer cust;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnEmail_Click(object sender, EventArgs e)
        {
            if (TKPdb.checkUserName(txtEmail.Text))
            {
                cust = Customer.getCustomerByEmail(txtEmail.Text);
                if (cust.secretQuestion != "" && cust.secretQuestion != null)
                {
                    txtAnswer.Enabled = true;
                    btnSubmitAns.Enabled = true;
                    lblQuestion.Text = cust.secretQuestion;
                }
                else
                {
                    lblQuestion.Text = "You have not set up password recovery for this account please contact Tech Know Pro for Password Recovery";
                }
            }
            else
            {
                lblQuestion.Text = "Email not found";
            }
        }

        protected void btnSubmit0_Click(object sender, EventArgs e)
        {
            cust = Customer.getCustomerByEmail(txtEmail.Text);
            if (txtAnswer.Text == cust.secretAnswer)
            {
                
                Random rand = new Random();
                string pw = "";
                char randChar;
                for (int i = 0; i < 8; i++)
                {
                    randChar = Convert.ToChar(rand.Next(35, 123));// generate radom char
                    pw += randChar;
                }
                Comp2139Assignment.User.updatePW(txtEmail.Text, pw);
                // Display Message telling user they will receive email with new password
                string messsage = "<h1>Your New Tech Know Pro Password</h1><br>Your password has been reset to " +
                    $"<br>{pw}<br>";
                TKPemail.sendEmail(txtEmail.Text, "Tech Know Pro Password Reset", messsage);
                Response.Redirect("~/PasswordReset.aspx");
            }
        }
    }
}