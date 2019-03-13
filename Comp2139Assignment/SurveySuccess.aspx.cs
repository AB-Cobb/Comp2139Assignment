using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class SurveySuccess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
                Response.Redirect("~/Login.aspx");
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Survey survey = (Survey)Session["Survey"];
            if (survey.contactMe != string.Empty)
                lblText.Visible = true;
            else
                lblText.Visible = false;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.RedirectPermanent("~/HomePage.aspx");
        }

        protected void btnReturnToSurvey_Click(object sender, EventArgs e)
        {
            Response.RedirectPermanent("~/Survey.aspx");
        }
    }
}