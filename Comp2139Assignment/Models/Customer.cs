using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Comp2139Assignment
{
    public class Customer
    {
        public int customerId { get; private set; }
        public string email { get; private set; }
        public string profileName { get; set; }

        public string fname
        {
            get
            {
                return fname;
            }
            set
            {
                if (value.Length > 20)
                    fname = value.Substring(0, 20);
                else
                    fname = value;
            }
        }
        public string lname
        {
            get
            {
                return lname;
            }
            set
            {
                if (value.Length > 20)
                    lname = value.Substring(0, 20);
                else
                    lname = value;
            }
        }
        public string address
        {
            get
            {
                return address;
            }
            set
            {
                if (value.Length > 100)
                    address = value.Substring(0, 100);
                else
                    address = value;
            }
        }
        public string phoneNum
        {
            get
            {
                return phoneNum;
            }
            set
            {
                if (value.Length > 12)
                    phoneNum = value.Substring(0, 12);
                else
                    phoneNum = value;
            }
        }
        public string position
        {
            get
            {
                return position;
            }
            set
            {
                if (value.Length > 50)
                    position = value.Substring(0, 50);
                else
                    position = value;
            }
        }
        public bool onContactList { get; set; }

        public Customer(string email, string fname, string lname, string address, bool onContactList = false)
        {
            this.customerId = -1;
            this.email = email;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.phoneNum = null;
            this.position = null;
            this.onContactList = false;
        }

        private Customer(int customerId, string email, string fname, string lname, string address, string phoneNum, string position, bool onContactList = false)
        {
            this.customerId = customerId;
            this.email = email;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.phoneNum = phoneNum;
            this.position = position;
            this.onContactList = onContactList;
        }
        
        static public List<Customer> getContactList()
        {
            List<Customer> contactList = new List<Customer> { };
            DataTable contactsData = TKPdb.getContactList();
            foreach (DataRow cust in contactsData.Rows)
                contactList.Add(new Customer((int)cust["CustomerId"], (string)cust["email"], (string)cust["fname"], (string)cust["lname"], (string)cust["address"], (string)cust["phoneNum"], (string)cust["position"]));
            return contactList;
        }
        static public Customer getCustomerById(int id)
        {
            DataRow cust = TKPdb.getCustomerById(id);
            return new Customer((int)cust["CustomerId"], (string)cust["email"], (string)cust["fname"], (string)cust["lname"], (string)cust["address"], (string)cust["phoneNum"], (string)cust["position"]);
        }
        static public Customer getCustomerByEmail(string email)
        {
            DataRow cust = TKPdb.getCustomerByEmail(email);
            return new Customer((int)cust["CustomerId"], (string)cust["email"], (string)cust["fname"], (string)cust["lname"], (string)cust["address"], (string)cust["phoneNum"], (string)cust["position"]);
        }
        static public List<Customer> getCustomerList()
        {
            List<Customer> customers = new List<Customer> { };
            DataTable custsData= TKPdb.getAllCustomers();
            foreach (DataRow cust in custsData.Rows)
                customers.Add(new Customer((int)cust["CustomerId"], (string)cust["email"], (string)cust["fname"], (string)cust["lname"], (string)cust["address"], (string)cust["phoneNum"], (string)cust["position"]));
            return customers;
        }
        public void save()
        {
            TKPdb.updateCustomer(this);
        }
    }
}
