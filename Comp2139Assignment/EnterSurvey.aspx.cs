using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class EnterSurvey : System.Web.UI.Page
    {
        List<Incident> incidents;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Session["User"] == null)
                Response.Redirect("~/Login.aspx");
            txtCustomerID.Text = Convert.ToString(Customer.getCustomerByEmail( ((User)Session["User"]).email).customerId);
            incidents = Incident.getIncidentsByCustomerEmail(((User)Session["User"]).email);
            ddlIncidentList.DataSource = incidents;
            ddlIncidentList.DataTextField = "description";
            if (!IsPostBack)
                ddlIncidentList.DataBind();
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
                int index = ddlIncidentList.SelectedIndex;
                int resTime = getSurveyValue(rblResponseTime.SelectedValue);
                int techEffic = getSurveyValue(rblTechnicianEfficiency.SelectedValue);
                int probRes = getSurveyValue(rblProblemResolution.SelectedValue);
                Survey survey = new Survey(incidents[ddlIncidentList.SelectedIndex].incidentId, resTime, techEffic, probRes, txtAdditionalComments.Text);
                survey.saveSurvay();
                Session["Survey"] = survey;
                Response.Redirect("~/SurveySuccess.aspx");
            }
        }
        private int getSurveyValue(string input)
        {
            switch (input) {
                case "Very Satisfied":
                    return 5;
                case "Satisfied":
                    return 4;
                case "Average":
                    return 3;
                case "Unsatisfied":
                    return 2;
                case "Very Unsatisfied":
                    return 1;
                default:
                    return 0;
            }
        }
        protected void chkContactMe_CheckedChanged(object sender, EventArgs e)
        {
            rblContactMe.Enabled = chkContactMe.Checked;
            /*
            if (chkContactMe.Checked == true) //not good code
                rblContactMe.Enabled = true;
            else
                rblContactMe.Enabled = false;
                */
        }
    }
}