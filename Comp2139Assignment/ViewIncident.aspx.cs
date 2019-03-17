using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class ViewIncident : System.Web.UI.Page
    {
        List<Customer> customers;
        List<Incident> incidents;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!(Session["User"] != null && ((User)Session["User"]).role == "Technician"))
                Response.Redirect("~/Login.aspx");
            customers = Customer.getCustomerList();
            ddlCustomer.DataSource = customers;
            ddlCustomer.DataTextField = "name";
            if (!IsPostBack)
                ddlCustomer.DataBind();
            incidents = Incident.getIncidentsByCustomerEmail(customers[ddlCustomer.SelectedIndex].email);
            lstbIncident.DataSource = incidents;
            lstbIncident.DataTextField = "description";
            if (!IsPostBack)
                lstbIncident.DataBind();

            if (Session["Incident"] != null)
            {
                Incident incident = (Incident)Session["Incident"];
                lblCustomerID.Text = Convert.ToString(incident.customerId);
                lblIncidentNumber.Text = Convert.ToString(incident.incidentId);
                lblReportDateAndTime.Text = Convert.ToString(incident.date);
                txtDescription.Text = incident.description;
            }// 
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }

        protected void btnCreateIncident_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CreateIncident.aspx");
        }

        protected void btnRetrieve_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Incident incident = incidents[lstbIncident.SelectedIndex];
                lblCustomerID.Text = Convert.ToString(incident.customerId);
                lblIncidentNumber.Text = Convert.ToString(incident.incidentId);
                lblReportDateAndTime.Text = Convert.ToString(incident.date);
                Status.Text = incident.status;
                btnStatus.Enabled = true;
                txtDescription.Text = incident.description;
                if (incident.status == "Open")
                {
                    btnStatus.Text = "Close Incindent";
                }
                else
                {
                    btnStatus.Text = "Re-Open Incindent";
                }
            }

        }

        protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            incidents = Incident.getIncidentsByCustomerEmail(customers[ddlCustomer.SelectedIndex].email);
            lstbIncident.DataSource = incidents;
            lstbIncident.DataTextField = "description";
            lstbIncident.DataBind(); // */
        }

        protected void lstbIncident_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbIncident.SelectedIndex;
        }

        protected void btnStatus_Click(object sender, EventArgs e)
        {
            Incident incident = incidents[lstbIncident.SelectedIndex];
            if (incident.status == "Open")
            {
                incident.status = "Closed";
                btnStatus.Text = "Re-Open Incindent";
            }
            else
            {
                incident.status = "Open";
                btnStatus.Text = "Close Incindent";
            }
            Status.Text = incident.status;
            incident.save();
        }
    }
}