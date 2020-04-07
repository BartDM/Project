using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
{
    public class PM : Computer
    { // Physical computer
        public string Type { 
            get {return "Physical";}
        }

        //navigation properties
        //DB 1-on-many relationship
        public virtual List<VM> Vms { get; }

    }
}
