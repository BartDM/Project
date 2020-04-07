using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
{
    public class Vendor:BaseClass
    {
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Name" && string.IsNullOrWhiteSpace(Name))
                {
                    return "Name should not be empty.";
                }
                return "";
            }
        }

        public int VendorId  { get; set; }
        public string Name { get; set; }
        public bool HasHardware { get; set; }
        public bool HasSoftware { get; set; }
        public bool HasOperatingSystem { get; set; }

        //navigation properties
        //DB 1-on-1 relationship
        public virtual Product Product { get; set; }
    }
}
