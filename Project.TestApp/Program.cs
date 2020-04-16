using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Project.DAL;

namespace Project.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DAL.Model.VM computer = new DAL.Model.VM()
            {
                Name = "VMServer1",
                Description = "TEST VM",
                IsActive = true                
            };

            DAL.Model.PM computer2 = new DAL.Model.PM()
            {
                Name = "PMServer1",
                Description = "TEST PM",
                IsActive = true
            };

            DAL.Model.OperatingSystem os1 = new DAL.Model.OperatingSystem()
            {
                Name = "Wii",
                Description = "iets",
                Version = "1.1",
                IsActive = true                
            };
            DAL.Model.Vlan vlan1 = new DAL.Model.Vlan()
            {
                Nr = 1,
                Description = "Test VLAN",
                IpBegin = IPAddress.Parse("192.168.1.1"),
                MaskLength = 24               
            };
            DAL.Model.Vlan vlan2 = new DAL.Model.Vlan()
            {
                Nr = 2,
                Description = "Test VLAN2",
                IpBegin = IPAddress.Parse("192.168.2.1"),
                MaskLength = 24
            };

            using (Project.DAL.ProjectDBContextCF context = new ProjectDBContextCF())
            {
                //context.VMS.Add(computer);
                //context.PMS.Add(computer2);
                //context.OperatingSystems.Add(os1);

                context.Vlans.Add(vlan1);
                context.Vlans.Add(vlan2);

                context.SaveChanges();
            }
        }
    }
}
