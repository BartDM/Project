using System.Collections.Generic;
using System.Net;

namespace Project.BDO
{
    public class Vlan
    {
        public int Vlanid { get; set; }
        public int Nr { get; set; }
        public string Name { get; }
        public string Description { get; set; }
        public IPAddress IpBegin { get; set; }
        public int MaskLength { get; set; }
        //public IPAddressRange Range
        //{
        //    get { return Range; }
        //    set
        //    {
        //        Range= new IPAddressRange(IpBegin, maskLength: MaskLength);  //https://github.com/jsakamoto/ipaddressrange/blob/master/README.md
        //    }
        //}
        public virtual List<NetworkInterface> Ips { get; set; }
    }
}
