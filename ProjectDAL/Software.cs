using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
{
    public class Software:Product
    {
        public int Sofwareid { get; set; }

        public string Type
        {
            get { return "Software"; }
        }

        //navigation properties
        //DB 1-on-many relationship
        public virtual List<Computer> Computers { get; set; }
    }
}
