using System.Collections.Generic;

namespace Project.DAL.Model
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
        public virtual List<Product> Products { get; set; }
    }
}
