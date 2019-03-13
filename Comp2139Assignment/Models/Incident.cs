using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Comp2139Assignment
{
    public class Incident
        {
        public int customerId { get; private set; }
        public int incidentId { get; private set; }
        public DateTime date { get; private set; }
        public string status { get; set; }
        public string description{ 
            get {
                return description;
            }
            set {
                if (value.Length > 250)
                    description = value.Substring(0, 250);
                else
                    description = value;
            }
        }
        public string methodOfContact { get; set; }

        public Incident (int customerId, string description, string methodOfContact)
        {
            this.customerId = customerId;
            this.description = description;
            this.methodOfContact = methodOfContact;
            this.status = "Open";
            this.date = DateTime.Today;
        }
        private Incident(int customerId, string description, string methodOfContact, DateTime date, string status)
        {
            this.customerId = customerId;
            this.description = description;
            this.methodOfContact = methodOfContact;
            this.status = status;
            this.date = date;
            this.date = DateTime.Today;
        }
        public void save()
        {
            TKPdb.updateIncident(this);
        }
        static public List<Incident> getIncidentsByCustomerEmail(string email)
        {
            List<Incident> incidents = new List<Incident> { };
            DataTable inicedentData = TKPdb.getIncidentsByCustomerEmail(email);
            foreach (DataRow incident in inicedentData.Rows)
                incidents.Add(new Incident((int)incident["IncidentId"], (string)incident["Description"], (string)incident["MethodOfContact"], (DateTime)incident["Date"], (string)incident["status"]));
            return incidents;
        }
    }
}
