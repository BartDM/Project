using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
{
    public interface IProduct
    {   // Interface = class contract
        string Name { get; set; }
        string Version { get; set; }
        string Description { get; set; }
        Vendor Vendor { get; set; }
        bool IsActive { get; set; }
    }
}
