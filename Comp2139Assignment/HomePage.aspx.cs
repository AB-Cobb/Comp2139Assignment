using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                if (Session["User"] == null)
                    Response.Redirect("~/Login.aspx");
                else
                {
                    User user = (User)Session["User"];
                    if (user.role == "Client")
                    {
                        hplCustomersPage.Visible = false;
                        hplIncidentsPage.Visible = false;
                        hplViewSurveysPage.Visible = false;
                    }
                    else if (user.role == "Technician")
                    {
                        hplViewSurveysPage.Visible = false;
                        hplProfilePage.Visible = false;
                        lblSurvey.Visible = false;
                        hplSurveyPage.Visible = false;
                    }
                    else if (user.role == "Admin")
                    {
                        hplIncidentsPage.Visible = false;
                        hplProfilePage.Visible = false;
                        hplSurveyPage.Visible = false;
                    }
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }
    }
}