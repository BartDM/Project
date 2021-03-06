﻿using System.ComponentModel.DataAnnotations;

namespace Project.DAL.Model
{
    public abstract class User:BaseClass
    {   // Abstract:    * Put all the properties and methodes that sub-classes need
        //              * Perform validation
        [Key]
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
