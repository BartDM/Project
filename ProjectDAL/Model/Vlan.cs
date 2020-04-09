using System.Collections.Generic;
using System.Net;
using NetTools;

namespace Project.DAL.Model
{
    public class Vlan:BaseClass
    {

        public int Vlanid { get; set; }
        public int Nr { get; set; }
        public string Name()
        {
           return "VLAN " + Nr; 
        }

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

        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Nr" && Nr <= 0)
                {
                    return "VLAN number is not correct.";
                }
                else if (columnName == "Description" && string.IsNullOrWhiteSpace(Description))
                {
                    return "Description should not be empty.";
                }
                else if (columnName == "Masklength" && (MaskLength > 32 || MaskLength < 0))
                {
                    return "Mask Length is not valid.";
                }

                return "";
            }
        }

        public override bool Equals(object obj)
        {
            var vlan = obj as Vlan;
            return vlan != null &&
                   Vlanid == vlan.Vlanid &&
                   Nr == vlan.Nr &&
                   EqualityComparer<IPAddress>.Default.Equals(IpBegin, vlan.IpBegin) &&
                   MaskLength == vlan.MaskLength;
        }

        public override int GetHashCode()
        {
            var hashCode = -2033167572;
            hashCode = hashCode * -1521134295 + Vlanid.GetHashCode();
            hashCode = hashCode * -1521134295 + Nr.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IPAddress>.Default.GetHashCode(IpBegin);
            hashCode = hashCode * -1521134295 + MaskLength.GetHashCode();
            return hashCode;
        }
    }
}
