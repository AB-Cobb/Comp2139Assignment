using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp2139Assignment
{
    public class Incident
    {
        public string customer { get; set; }
        public int customerID { get; set; }
        public string dateAndTime { get; set; }
        public int incidentNumber { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string methodOfContact { get; set; }
    }
}