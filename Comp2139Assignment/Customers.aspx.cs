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
        List<Customer> customers;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Session["User"] == null)
                Response.Redirect("~/Login.aspx");
            customers = Customer.getCustomerList();
            lstbCustomers.DataSource = customers;
            lstbCustomers.DataTextField = "name";
            if (!IsPostBack)
                lstbCustomers.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }

        protected void btnAddToContactList_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                customers[lstbCustomers.SelectedIndex].onContactList = true;
                customers[lstbCustomers.SelectedIndex].save();
                lblAddToContactList.Visible = true;
            }
        }

        protected void btnDisplayContactList_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ContactList.aspx");
        }

        protected void lstbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAddress.Text = customers[lstbCustomers.SelectedIndex].address;
            lblEmail.Text = customers[lstbCustomers.SelectedIndex].email;
            lblPhone.Text = customers[lstbCustomers.SelectedIndex].phoneNum;
        }
    }
}