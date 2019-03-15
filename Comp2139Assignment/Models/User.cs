using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp2139Assignment
{
    public class User
    {
        private string _email;
        public string email { get
            {
                return _email;
            }
            private set
            {
                if (value.Length > 50)
                    _email = value.Substring(0, 20);
                else
                    _email = value;
            }
        }
        public string role { get; private set; }

        private User(string email, string role) {
            this.email = email;
            this.role = role;
        }

        static public User login(string email, string password)
        {
            string role = TKPdb.checkLogin(email, password);
            if (role != "Denied")
                return new User(email, role);
            return null;
        }

        static public bool checkEmail(string email)
        {
            return TKPdb.checkUserName(email);
        }

        static public void register(string email, string password, string fName, string lName)
        {
            TKPdb.register(email, password, fName, lName);
        }
    }
}
