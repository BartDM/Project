using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
{
    public class ProductUser:User
    {
        public string Description { get; set; }
        //navigation properties
        //DB 1-on-many relationship
        public virtual Product Product { get; set; }

        public ProductUser(string username, string password, bool isEnabled, string description, Product product):base(username,password,isEnabled)
        {
            Description = description;
            Product = product;
        }

        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Description" && string.IsNullOrWhiteSpace(Description))
                {
                    return "Description should not be empty.";
                }
                else if (columnName == "Username" && string.IsNullOrWhiteSpace(Username))
                {
                    return "Last Name should not be empty.";
                }
                else if (columnName == "Password" && string.IsNullOrWhiteSpace(Password))
                {
                    return "Last Name should not be empty.";
                }

                return "";
            }
        }
    }
}
