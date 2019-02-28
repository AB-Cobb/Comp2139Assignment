using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp2139Assignment
{
    public class User
    {
        public int userID { get; set; }
        public string role { get; set; }
        public string profileName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string position { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string secretQuestion { get; set; }
        public string secretAnswer { get; set; }
        public string emailAddress { get; set; }
    }
}