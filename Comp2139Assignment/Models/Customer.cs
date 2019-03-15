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
        public string name {  get
            {
                return fname + " " + lname;
            }
        }
        public string contact
        {
            get
            {
                return $"{name}, {phoneNum}, {email}";
            }
        }
        private string _fname;
        public string fname
        {
            get
            {
                return this._fname;
            }
            set
            {
 
                if (value.Length > 20)
                    _fname = value.Substring(0, 20);
                else
                    _fname = value;
            }
        }
        private string _lname;
        public string lname
        {
            get
            {
                return _lname;
            }
            set
            {
                if (value.Length > 20)
                    _lname = value.Substring(0, 20);
                else
                    _lname = value;
            }
        } // */
        private string _address;
        public string address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value.Length > 100)
                    _address = value.Substring(0, 100);
                else
                    _address = value;
            }
        }//*/
        private string _phoneNum;
        public string phoneNum
        {
            get
            {
                return _phoneNum;
            }
            set
            {
                if (value.Length > 12)
                    _phoneNum = value.Substring(0, 12);
                else
                    _phoneNum = value;
            }
        }// */
        private string _position;
        public string position
        {
            get
            {
                return _position;
            }
            set
            {
                if (value.Length > 50)
                    _position = value.Substring(0, 50);
                else
                    _position = value;
            }
        }// */
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
            {
                int id = (int)cust["CustomerId"];
                string email = (string)cust["email"];
                string fname = (string)cust["fname"];
                string lname = (string)cust["lname"];
                string address = cust["address"] == DBNull.Value ? "" : (string)cust["address"];
                string phoneNum = cust["phoneNum"] == DBNull.Value ? "" : (string)cust["phoneNum"];
                string position = cust["position"] == DBNull.Value ? "" : (string)cust["position"];
                contactList.Add(new Customer(id, email, fname, lname, address, phoneNum, position));
            }
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

            int id = (int)cust["CustomerId"];

            string fname = (string)cust["fname"];
            string lname = (string)cust["lname"];
            string address = cust["address"] == DBNull.Value ? "" : (string)cust["address"];
            string phoneNum = cust["phoneNum"] == DBNull.Value ? "" : (string)cust["phoneNum"];
            string position = cust["position"] == DBNull.Value ? "" : (string)cust["position"];
            return new Customer(id, email, fname, lname, address, phoneNum, position);
        }
        static public List<Customer> getCustomerList()
        {
            List<Customer> customers = new List<Customer> { };
            DataTable custsData= TKPdb.getAllCustomers();
            foreach (DataRow cust in custsData.Rows)
            {
                int id = (int)cust["CustomerId"];
                string email = (string)cust["email"];
                string fname = (string)cust["fname"];
                string lname = (string)cust["lname"];
                string address = cust["address"] == DBNull.Value ? "" : (string)cust["address"];
                string phoneNum = cust["phoneNum"] == DBNull.Value ? "" : (string)cust["phoneNum"];
                string position = cust["position"]== DBNull.Value ? "" : (string)cust["position"];
                customers.Add(new Customer(id, email, fname, lname, address, phoneNum, position));
            }
            return customers;
        }

        public void save()
        {
            TKPdb.updateCustomer(this);
        }
    }
}
