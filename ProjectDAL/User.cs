using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
{
    public abstract class User:BaseClass
    {   // Abstract:    * Put all the properties and methodes that sub-classes need
        //              * Perform validation

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsEnabled { get; set; }

        protected User(string username, string password, bool isEnabled)
        {
            this.Username = username;
            this.Password = password;
            IsEnabled = isEnabled;
        }

    }
}
