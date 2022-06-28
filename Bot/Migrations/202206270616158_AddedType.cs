namespace Bot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "CarTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "CarTypeId");
            AddForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes");
            DropIndex("dbo.Cars", new[] { "CarTypeId" });
            DropColumn("dbo.Cars", "CarTypeId");
            DropTable("dbo.CarTypes");
        }
    }
}
