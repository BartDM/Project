using System.Collections.Generic;

namespace Project.DAL.Model
{
    public class Computer:Product
    {
        public int ComputerId { get; set; }
        

        //navigation properties
        //DB 1-on-1 relationship
        public virtual OperatingSystem Os { get; set; }
        public virtual Location Location { get; set; }
        //DB 1-on-many relationship
        public virtual List<Software> Softwares { get; set; }
        public virtual List<NetworkInterface> Netwerkinterfaces { get; set; }
        
        
        //Network
        //Users
    }
}
