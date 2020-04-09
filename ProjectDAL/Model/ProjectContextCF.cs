using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

// install Entity Framework

namespace Project.DAL.Model
{


    public class ProjectContextCF : DbContext
    {

        public ProjectContextCF() : base("ProjectContextCF")
        { //The name of the connection string (which you'll add to the Web.config file later) is passed in to the constructor.
        }

        public DbSet<PM> PMS { get; set; }
        public DbSet<VM> VMS { get; set; }

        public DbSet<Vlan> Vlans { get; set; }
        public DbSet<NetworkInterface> NetworkInterfaces { get; set; }

        public DbSet<Software> Softwares { get; set; }
        public DbSet<OperatingSystem> OperatingSystems { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<ProgramUser> ProgramUsers { get; set; }
        public DbSet<ProductUser> ProductUsers { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
