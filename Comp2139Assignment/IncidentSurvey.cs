using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp2139Assignment
{
    public class IncidentSurvey
    {
        public int surveyID { get; set; }
        public string description { get; set; }
        public string responseTime { get; set; }
        public string technicianEfficiency { get; set; }
        public string problemResolution { get; set; }
        public string additionalComments { get; set; }
        public string contactMe { get; set; }
    }
}