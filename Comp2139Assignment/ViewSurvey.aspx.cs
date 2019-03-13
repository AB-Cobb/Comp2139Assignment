using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class ViewSurvey : System.Web.UI.Page
    {
        List<Survey> surveys;
        List<Customer> customers;
        Survey selectedSurvey;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Session["User"] == null)
                Response.Redirect("~/Login.aspx");
            customers = Customer.getCustomerList();
            ddlCustomers.DataSource = customers;
            ddlCustomers.DataBind();
            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }

        protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            surveys = Survey.getSurveysByCustomerId(Customer.getCustomerByEmail(customers[ddlCustomers.SelectedIndex].email).customerId);
            lstbSurvey.DataSource = surveys;
            lstbSurvey.DataBind();
            txtCustomer.Text = Convert.ToString(customers[ddlCustomers.SelectedIndex].customerId);
            
        }

        protected void lstbSurvey_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        protected void btnRetrieveSurveyDetails_Click(object sender, EventArgs e)
        {
            selectedSurvey = surveys[lstbSurvey.SelectedIndex];
            lblProbResolution.Text = getSurveyText(selectedSurvey.resolution);
            lblResponseTime.Text = getSurveyText(selectedSurvey.responeseTime);
            lblTechEfficientcy.Text = getSurveyText(selectedSurvey.efficentcy);
        }
        private string getSurveyText(int value)
        {
            switch (value)
            {
                case 5:
                    return "Very Satisfied";
                case 4:
                    return "Satisfied";
                case 3:
                    return "Average";
                case 2:
                    return "Unsatisfied";
                case 1:
                    return "Very Unsatisfied";
                default:
                    return "No Answer";
            }
        }
    }
}