using System.Net;

namespace Project.BDO
{
    public enum NwiNames
    {
        VI1, VI2, VI3, VI4, VI5, VI6, VI7, VI8, VI9, VI10, VI11, VI12, VI13, VI14, VI15, VI16,
        PI1, PI2, PI3, PI4, PI5, PI6, PI7, PI8
    }
    public class NetworkInterface
    {
        public int NetworkInterfaceId { get; set; }
        public NwiNames Name { get; set; }
        public IPAddress Ip { get; set; }
        public virtual Vlan Vlan { get; set; }
        public virtual Computer Computer { get; set; }       
    }
}
