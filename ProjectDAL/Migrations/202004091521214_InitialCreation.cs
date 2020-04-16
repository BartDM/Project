namespace Project.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        LocId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.LocId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProdId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Version = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Location_LocId = c.Int(),
                        Os_ProdId = c.Int(),
                        Vendor_VendorId = c.Int(),
                        Host_ProdId = c.Int(),
                    })
                .PrimaryKey(t => t.ProdId)
                .ForeignKey("dbo.Location", t => t.Location_LocId)
                .ForeignKey("dbo.Product", t => t.Os_ProdId)
                .ForeignKey("dbo.Vendor", t => t.Vendor_VendorId)
                .ForeignKey("dbo.Product", t => t.Host_ProdId)
                .Index(t => t.Location_LocId)
                .Index(t => t.Os_ProdId)
                .Index(t => t.Vendor_VendorId)
                .Index(t => t.Host_ProdId);
            
            CreateTable(
                "dbo.NetworkInterface",
                c => new
                    {
                        NwiId = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Ip_Address = c.Long(nullable: false),
                        Ip_ScopeId = c.Long(nullable: false),
                        Computer_ProdId = c.Int(),
                        Vlan_Vlanid = c.Int(),
                    })
                .PrimaryKey(t => t.NwiId)
                .ForeignKey("dbo.Product", t => t.Computer_ProdId)
                .ForeignKey("dbo.Vlan", t => t.Vlan_Vlanid)
                .Index(t => t.Computer_ProdId)
                .Index(t => t.Vlan_Vlanid);
            
            CreateTable(
                "dbo.Vlan",
                c => new
                    {
                        Vlanid = c.Int(nullable: false, identity: true),
                        Nr = c.Int(nullable: false),
                        Description = c.String(),
                        IpBegin_Address = c.Long(nullable: false),
                        IpBegin_ScopeId = c.Long(nullable: false),
                        MaskLength = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Vlanid);
            
            CreateTable(
                "dbo.ProductUser",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        Product_ProdId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Product", t => t.Product_ProdId)
                .Index(t => t.Product_ProdId);
            
            CreateTable(
                "dbo.Vendor",
                c => new
                    {
                        VendorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HasHardware = c.Boolean(nullable: false),
                        HasSoftware = c.Boolean(nullable: false),
                        HasOperatingSystem = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VendorId);
            
            CreateTable(
                "dbo.ProgramUser",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        JobTitle = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.SoftwareComputer",
                c => new
                    {
                        Software_ProdId = c.Int(nullable: false),
                        Computer_ProdId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Software_ProdId, t.Computer_ProdId })
                .ForeignKey("dbo.Product", t => t.Software_ProdId)
                .ForeignKey("dbo.Product", t => t.Computer_ProdId)
                .Index(t => t.Software_ProdId)
                .Index(t => t.Computer_ProdId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Host_ProdId", "dbo.Product");
            DropForeignKey("dbo.SoftwareComputer", "Computer_ProdId", "dbo.Product");
            DropForeignKey("dbo.SoftwareComputer", "Software_ProdId", "dbo.Product");
            DropForeignKey("dbo.Product", "Vendor_VendorId", "dbo.Vendor");
            DropForeignKey("dbo.ProductUser", "Product_ProdId", "dbo.Product");
            DropForeignKey("dbo.Product", "Os_ProdId", "dbo.Product");
            DropForeignKey("dbo.NetworkInterface", "Vlan_Vlanid", "dbo.Vlan");
            DropForeignKey("dbo.NetworkInterface", "Computer_ProdId", "dbo.Product");
            DropForeignKey("dbo.Product", "Location_LocId", "dbo.Location");
            DropIndex("dbo.SoftwareComputer", new[] { "Computer_ProdId" });
            DropIndex("dbo.SoftwareComputer", new[] { "Software_ProdId" });
            DropIndex("dbo.ProductUser", new[] { "Product_ProdId" });
            DropIndex("dbo.NetworkInterface", new[] { "Vlan_Vlanid" });
            DropIndex("dbo.NetworkInterface", new[] { "Computer_ProdId" });
            DropIndex("dbo.Product", new[] { "Host_ProdId" });
            DropIndex("dbo.Product", new[] { "Vendor_VendorId" });
            DropIndex("dbo.Product", new[] { "Os_ProdId" });
            DropIndex("dbo.Product", new[] { "Location_LocId" });
            DropTable("dbo.SoftwareComputer");
            DropTable("dbo.ProgramUser");
            DropTable("dbo.Vendor");
            DropTable("dbo.ProductUser");
            DropTable("dbo.Vlan");
            DropTable("dbo.NetworkInterface");
            DropTable("dbo.Product");
            DropTable("dbo.Location");
        }
    }
}
