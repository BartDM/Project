using System.Collections.Generic;

namespace Project.DAL.Model
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
