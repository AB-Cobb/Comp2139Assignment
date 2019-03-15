using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp2139Assignment
{
    public partial class ContactList : System.Web.UI.Page
    {
        List<Customer> contactList;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Session["User"] == null)
                Response.Redirect("~/Login.aspx");
            contactList = Customer.getContactList();
            lstbContactList.DataSource = contactList;
            lstbContactList.DataTextField = "contact";
            if (!IsPostBack)
            {
                lstbContactList.DataBind();
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }

        protected void update_contactList()
        {
            
            contactList = Customer.getContactList();
            lstbContactList.DataSource = contactList;
            lstbContactList.DataTextField = "contact";
            lstbContactList.DataBind(); // */
        }

        protected void btnRemoveContact_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                contactList[lstbContactList.SelectedIndex].onContactList = false;
                contactList[lstbContactList.SelectedIndex].save();
                update_contactList();/*
            contactList = Customer.getContactList();
            lstbContactList.DataTextField = "contact";
            lstbContactList.DataBind(); // */
                lblStatus.Text = "Contact Removed";
                lblStatus.Visible = true;
            }
        }

        protected void btnClearList_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                for (int i = 0; i < contactList.Count; i++)
                {
                    contactList[i].onContactList = false;
                    contactList[i].save();
                }
                update_contactList();
                lblStatus.Text = "List Cleared";
                lblStatus.Visible = true;
            }
        }

        protected void lstbContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnDisplayContactList_Click(object sender, EventArgs e)
        {

        }
    }
}