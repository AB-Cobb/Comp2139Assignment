using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp2139Assignment
{
    public class User
    {
        public string email { get; private set; }
        public string role { get; private set; }

        private User(string email, string role) {
            this.email = email;
            this.role = role;
        }

        static public User login(string email, string password)
        {
            string role = TKPdb.checkLogin(email, password);
            if (role != "denied")
                return new User(email, role);
            return null;
        }

        static public bool checkEmail(string email)
        {
            if (TKPdb.checkUserName(email))
                return true; // Email is in the DataBase
            return false;
        }

        static public void register(string email, string password, string fName, string lName)
        {
            TKPdb.register(email, password, fName, lName);
        }
    }
}
