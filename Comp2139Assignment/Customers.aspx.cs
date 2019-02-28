using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Session["User"] == null)
                Response.Redirect("~/Login.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }

        protected void btnAddToContactList_Click(object sender, EventArgs e)
        {
            lblAddToContactList.Visible = true;
        }

        protected void btnDisplayContactList_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ContactList.aspx");
        }
    }
}