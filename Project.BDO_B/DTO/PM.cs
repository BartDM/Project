using System.Collections.Generic;

namespace Project.BDO
{
    public class PM : Computer
    { // Physical computer
        public string Type { get; }
        public virtual List<VM> Vms { get; }
    }
}
