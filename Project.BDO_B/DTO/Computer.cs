using System.Collections.Generic;

namespace Project.BDO
{
    public class Computer:Product
    {  
        public int ComputerId { get; set; }
        public virtual OperatingSystem Os { get; set; }
        public virtual Location Location { get; set; }
        public virtual List<Software> Softwares { get; set; }
        public virtual List<NetworkInterface> Netwerkinterfaces { get; set; }
    }
}
