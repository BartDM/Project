using System.Collections.Generic;

namespace Project.BDO
{
    public class Vendor
    {        
        public int VendorId  { get; set; }
        public string Name { get; set; }
        public bool HasHardware { get; set; }
        public bool HasSoftware { get; set; }
        public bool HasOperatingSystem { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
