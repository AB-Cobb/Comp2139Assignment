using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Comp2139Assignment
{
    public class Survey
    { 
        public int surveyId { get; private set; }
        public int incidentId { get; private set; }
        public int responeseTime { get; set; }
        public int efficentcy { get; set; }
        public int resolution { get; set; }
        public string contactMe { get; set;  }
        public string comments {
            get {
                return comments;
            }
            set {
                if (value.Length > 250)
                    comments = value.Substring(0, 250);
                else
                    comments = value;
            }
        }

        public Survey (int incidentId, int responeseTime, int efficentcy, int resolution, string comments)
        {
            this.surveyId = -1;
            this.responeseTime = responeseTime;
            this.efficentcy = efficentcy;
            this.resolution = resolution;
            if (comments.Length > 250)
                comments = comments.Substring(0, 250);
            this.comments = comments;
        }
        
        private Survey (int surveyId, int incidentId, int responeseTime, int efficentcy, int resolution, string comments)
        {
            this.surveyId = surveyId;
            this.responeseTime = responeseTime;
            this.efficentcy = efficentcy;
            this.resolution = resolution;
            this.comments = comments;
        }
        

        static public Survey getSurveyByInicidentId(int incidentId)
        {
            DataRow survey = TKPdb.getSurveyByInicidentId(incidentId);
            return new Survey((int)survey["SurveyId"], (int)survey["IncidentId"], (int)survey["ResponseTime"], (int)survey["Efficentcy"], (int)survey["Resolution"], (string)survey["Comments"]);
        }

        static public Survey getSurveyBySurveyId(int surveyId)
        {
            DataRow survey = TKPdb.getSurveyBySurveyId(surveyId);
            return new Survey((int)survey["SurveyId"], (int)survey["IncidentId"], (int)survey["ResponseTime"], (int)survey["Efficentcy"], (int)survey["Resolution"], (string)survey["Comments"]);
        }
        static public List<Survey> getSurveysByCustomerId(int id)
        {
            List<Survey> surveys = new List<Survey> { };
            DataTable surveyData = TKPdb.getSurveysByCustomerId(id);
            foreach (DataRow survey in surveyData.Rows)
                surveys.Add(new Survey((int)survey["SurveyId"], (int)survey["IncidentId"], (int)survey["ResponseTime"], (int)survey["Efficentcy"], (int)survey["Resolution"], (string)survey["Comments"]));
            return surveys;
        }
        
        public void saveSurvay()
        {
            TKPdb.updateSurvey(this);
        }
    }
}
