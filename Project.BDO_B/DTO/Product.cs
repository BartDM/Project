using System.Collections.Generic;

namespace Project.BDO
{
    public class Product
    {        
        public int ProdId { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual List<ProductUser> Users { get; set; }     
    }
}
