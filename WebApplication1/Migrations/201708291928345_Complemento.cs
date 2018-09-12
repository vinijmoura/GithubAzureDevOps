namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Complemento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Complemento", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Complemento");
        }
    }
}
