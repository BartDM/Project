using System.Collections.Generic;

namespace Project.BDO
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Computer> Computers { get; set; }
    }
}
