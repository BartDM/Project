using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BDO
{
    public abstract class User
    {   
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsEnabled { get; set; }   
    }
}
