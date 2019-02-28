using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class CreateIncident : System.Web.UI.Page
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Incident incident = new Incident();
                incident.dateAndTime = DateTime.Today.ToShortDateString();
                incident.description = txtDescription.Text;
                incident.methodOfContact = rblMethodOfContact.SelectedValue;
                Session["Incident"] = incident;
                Response.Redirect("~/ViewIncident.aspx");
            }
        }
    }
}