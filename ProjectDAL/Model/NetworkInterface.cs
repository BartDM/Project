using System.Collections.Generic;
using System.Net;

namespace Project.DAL.Model
{
    public enum NwiNames
    {
        VI1, VI2, VI3, VI4, VI5, VI6, VI7, VI8, VI9, VI10, VI11, VI12, VI13, VI14, VI15, VI16,
        PI1, PI2, PI3, PI4, PI5, PI6, PI7, PI8
    }

    public class NetworkInterface:BaseClass
    {
        
        public int NwiId { get; set; }
        public NwiNames Name { get; set; }
        public IPAddress IP { get; set; }

        public virtual Vlan Vlan { get; set; }
        public virtual Computer Computer { get; set; }


        public override bool Equals(object obj)
        {
            var @interface = obj as NetworkInterface;
            return @interface != null &&
                   NwiId == @interface.NwiId &&
                   Name == @interface.Name &&
                   EqualityComparer<IPAddress>.Default.Equals(IP, @interface.IP) &&
                   EqualityComparer<Vlan>.Default.Equals(Vlan, @interface.Vlan);
        }

        public override int GetHashCode()
        {
            var hashCode = 1036811894;
            hashCode = hashCode * -1521134295 + NwiId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<NwiNames>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<IPAddress>.Default.GetHashCode(IP);
            hashCode = hashCode * -1521134295 + EqualityComparer<Vlan>.Default.GetHashCode(Vlan);
            return hashCode;
        }

        public override string this[string columnName]
        {
            get
            {
                //if (columnName == "Name" && string.IsNullOrWhiteSpace(Name))
                //{
                //    return "Network Interfacename should not be empty should not be empty.";
                //}

                return "";
            }
        }
    }
}
