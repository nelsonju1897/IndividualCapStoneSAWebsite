namespace IndividualCapStoneSAWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssaultRecords",
                c => new
                    {
                        AssaultRecordId = c.Int(nullable: false, identity: true),
                        SurvivorId = c.Int(nullable: false),
                        AssaultTypeId = c.Int(nullable: false),
                        AssaultLocationId = c.Int(nullable: false),
                        AttackerRelationshipId = c.Int(nullable: false),
                        AlcoholAndOrDrugId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AssaultRecordId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AssaultRecords");
        }
    }
}
