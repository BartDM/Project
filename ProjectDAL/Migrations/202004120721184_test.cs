namespace Project.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ComputerId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ComputerId");
        }
    }
}
