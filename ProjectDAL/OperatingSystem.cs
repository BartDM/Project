using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
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
