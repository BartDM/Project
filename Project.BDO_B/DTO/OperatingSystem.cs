using System.Collections.Generic;

namespace Project.BDO
{
    public class OperatingSystem:Product
    {
        public string Type { get; }        
        public virtual List<Computer> Computers { get; set; }
    }    
}
