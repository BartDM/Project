using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
{
    public class VM:Computer
    { // Virtual Machine computer
        public string Type
        {
            get { return "Virtual"; }
        }

        //navigation properties
        //DB 1-on-1 relationship
        public virtual PM Host { get; set; }
    }

}

