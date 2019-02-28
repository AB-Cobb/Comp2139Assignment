using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class Survey : System.Web.UI.Page
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
                IncidentSurvey survey = new IncidentSurvey();
                survey.description = ddlIncidentList.SelectedValue;
                survey.responseTime = rblResponseTime.SelectedValue;
                survey.technicianEfficiency = rblTechnicianEfficiency.SelectedValue;
                survey.problemResolution = rblProblemResolution.SelectedValue;
                survey.additionalComments = txtAdditionalComments.Text;
                if (chkContactMe.Checked == true)
                    survey.contactMe = rblContactMe.SelectedValue;
                else
                    survey.contactMe = null;
                Session["Survey"] = survey;
                Response.Redirect("~/SurveySuccess.aspx");
            }
        }

        protected void chkContactMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContactMe.Checked == true)
                rblContactMe.Enabled = true;
            else
                rblContactMe.Enabled = false;
        }
    }
}