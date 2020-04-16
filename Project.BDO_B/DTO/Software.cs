using System.Collections.Generic;

namespace Project.BDO
{
    public class Software:Product
    {
        public string Type { get;  }
        public virtual List<Computer> Computers { get; set; }
    }
}
