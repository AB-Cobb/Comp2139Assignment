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
        List<Customer> customers;
        Customer selectedCustomer;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!(Session["User"] != null && ((User)Session["User"]).role == "Technician"))
                Response.Redirect("~/Login.aspx");

            customers = Customer.getCustomerList();
            ddlCustomers.DataSource = customers;
            ddlCustomers.DataTextField = "name";
            if (!IsPostBack)
            {
                ddlCustomers.DataBind();
            }
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
                //int custId = Customer.getCustomerByEmail(((User)Session["User"]).email).customerId;
                int custId = customers[ddlCustomers.SelectedIndex].customerId;
                Incident incident = new Incident(custId, txtDescription.Text, rblMethodOfContact.SelectedValue);
                incident.save();
                Session["Incident"] = incident;
                Response.Redirect("~/ViewIncident.aspx");
            }
        }

        protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ddlCustomers.SelectedIndex;
            selectedCustomer = customers[ddlCustomers.SelectedIndex];
            txtCustomerID.Text = Convert.ToString(selectedCustomer.customerId);
            txtReportDateAndTime.Text = Convert.ToString(DateTime.Today);
        }
    }
}