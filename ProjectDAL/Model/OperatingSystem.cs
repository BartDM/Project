using System.Collections.Generic;

namespace Project.DAL.Model
{
    public class OperatingSystem:Product
    {
        public int OsId { get; set; }

        public string Type
        {
            get { return "Operating System"; }     
        }
        //navigation properties
        //DB 1-on-many relationship
        public virtual List<Computer> Computers { get; set; }

    }

    
}
