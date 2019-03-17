using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class UpdatePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!(Session["User"] != null && ((User)Session["User"]).role == "Client"))
                Response.Redirect("~/Login.aspx");
        }

        protected void btnSubmit0_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Comp2139Assignment.User.updatePW(((User)Session["User"]).email, txtNewPW.Text);
                //Display Message to user Here

                Response.Redirect("~/Profile.aspx");
            }
        }
    }
}