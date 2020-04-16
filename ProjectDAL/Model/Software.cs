using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.DAL.Model
{
    public class Software:Product
    {
        //[Key]
        //public int Sofwareid { get; set; }

        public string Type
        {
            get { return "Software"; }
        }

        //navigation properties
        //DB 1-on-many relationship
        public virtual List<Computer> Computers { get; set; }
    }
}
