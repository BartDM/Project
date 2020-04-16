using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.DAL.Model
{
    public class Location:BaseClass
    {
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Name" && string.IsNullOrWhiteSpace(Name))
                {
                    return "Name should not be empty.";
                }
                else if (columnName == "Description" && string.IsNullOrWhiteSpace(Description))
                {
                    return "Description should not be empty.";
                }

                return "";
            }
        }

        [Key]
        public int LocId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //navigation properties
        //DB 1-on-1 relationship
        public virtual List<Computer> Computers { get; set; }
    }
    
}
