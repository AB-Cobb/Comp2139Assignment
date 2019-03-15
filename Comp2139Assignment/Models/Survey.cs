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
        private string _comments;
        public string comments {
            get {
                return _comments;
            }
            set {
                if (value.Length > 250)
                    _comments = value.Substring(0, 250);
                else
                    _comments = value;
            }
        }

        public Survey (int incidentId, int responeseTime, int efficentcy, int resolution, string comments)
        {
            this.surveyId = -1;
            this.incidentId = incidentId;
            this.responeseTime = responeseTime;
            this.efficentcy = efficentcy;
            this.resolution = resolution;
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
            {
                int surveyid = (int)survey["SurveyId"];
                int incidentid = (int)survey["IncidentId"];
                int responseTime = (Byte)survey["ResponseTime"];
                int efficentcy = (Byte)survey["Efficentcy"];
                int resultion = (Byte)survey["Resolution"];
                string comments = (string)survey["Comments"];
                surveys.Add(new Survey(surveyid, incidentid, responseTime, efficentcy, resultion, comments));
            }
            return surveys;
        }
        
        public void saveSurvay()
        {
            TKPdb.updateSurvey(this);
        }
    }
}
