namespace IndividualCapStoneSAWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlcoholAndOrDrugs",
                c => new
                    {
                        AlcoholAndOrDrugsId = c.Int(nullable: false, identity: true),
                        AlcoholAndOrDrugsName = c.String(),
                    })
                .PrimaryKey(t => t.AlcoholAndOrDrugsId);
            
            CreateTable(
                "dbo.AssaultLocations",
                c => new
                    {
                        AssaultLocationId = c.Int(nullable: false, identity: true),
                        AssaultLocationName = c.String(),
                    })
                .PrimaryKey(t => t.AssaultLocationId);
            
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
                .PrimaryKey(t => t.AssaultRecordId)
                .ForeignKey("dbo.AlcoholAndOrDrugs", t => t.AlcoholAndOrDrugId, cascadeDelete: true)
                .ForeignKey("dbo.AssaultLocations", t => t.AssaultLocationId, cascadeDelete: true)
                .ForeignKey("dbo.AssaultTypes", t => t.AssaultTypeId, cascadeDelete: true)
                .ForeignKey("dbo.AttackerRelationships", t => t.AttackerRelationshipId, cascadeDelete: true)
                .ForeignKey("dbo.Survivors", t => t.SurvivorId, cascadeDelete: true)
                .Index(t => t.SurvivorId)
                .Index(t => t.AssaultTypeId)
                .Index(t => t.AssaultLocationId)
                .Index(t => t.AttackerRelationshipId)
                .Index(t => t.AlcoholAndOrDrugId);
            
            CreateTable(
                "dbo.AssaultTypes",
                c => new
                    {
                        AssaultTypeId = c.Int(nullable: false, identity: true),
                        AssaultTypeName = c.String(),
                    })
                .PrimaryKey(t => t.AssaultTypeId);
            
            CreateTable(
                "dbo.AttackerRelationships",
                c => new
                    {
                        AttackerRelationshipId = c.Int(nullable: false, identity: true),
                        AttackerRelationshipName = c.String(),
                    })
                .PrimaryKey(t => t.AttackerRelationshipId);
            
            CreateTable(
                "dbo.Survivors",
                c => new
                    {
                        SurvivorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmergencyContactNumber = c.String(),
                        EmailAddress = c.String(),
                        isSponsor = c.Boolean(nullable: false),
                        ApplicationId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SurvivorId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationId)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.MessageBoards",
                c => new
                    {
                        MessageBoardId = c.Int(nullable: false, identity: true),
                        MessageBoardName = c.String(),
                        MessageBoardEntry = c.String(),
                        SurvivorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MessageBoardId)
                .ForeignKey("dbo.Survivors", t => t.SurvivorId, cascadeDelete: true)
                .Index(t => t.SurvivorId);
            
            CreateTable(
                "dbo.PrivateJournals",
                c => new
                    {
                        PrivateJournalId = c.Int(nullable: false, identity: true),
                        PrivateJournalName = c.String(),
                        JournalEntry = c.String(),
                        SurvivorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PrivateJournalId)
                .ForeignKey("dbo.Survivors", t => t.SurvivorId, cascadeDelete: true)
                .Index(t => t.SurvivorId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorId = c.Int(nullable: false, identity: true),
                        SurvivorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SponsorId)
                .ForeignKey("dbo.Survivors", t => t.SurvivorId, cascadeDelete: true)
                .Index(t => t.SurvivorId);
            
            CreateTable(
                "dbo.SponsorGroups",
                c => new
                    {
                        SponsorGroupId = c.Int(nullable: false, identity: true),
                        SponsorId = c.Int(nullable: false),
                        SurvivorId = c.Int(),
                    })
                .PrimaryKey(t => t.SponsorGroupId)
                .ForeignKey("dbo.Sponsors", t => t.SponsorId, cascadeDelete: true)
                .ForeignKey("dbo.Survivors", t => t.SurvivorId)
                .Index(t => t.SponsorId)
                .Index(t => t.SurvivorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SponsorGroups", "SurvivorId", "dbo.Survivors");
            DropForeignKey("dbo.SponsorGroups", "SponsorId", "dbo.Sponsors");
            DropForeignKey("dbo.Sponsors", "SurvivorId", "dbo.Survivors");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.PrivateJournals", "SurvivorId", "dbo.Survivors");
            DropForeignKey("dbo.MessageBoards", "SurvivorId", "dbo.Survivors");
            DropForeignKey("dbo.AssaultRecords", "SurvivorId", "dbo.Survivors");
            DropForeignKey("dbo.Survivors", "ApplicationId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AssaultRecords", "AttackerRelationshipId", "dbo.AttackerRelationships");
            DropForeignKey("dbo.AssaultRecords", "AssaultTypeId", "dbo.AssaultTypes");
            DropForeignKey("dbo.AssaultRecords", "AssaultLocationId", "dbo.AssaultLocations");
            DropForeignKey("dbo.AssaultRecords", "AlcoholAndOrDrugId", "dbo.AlcoholAndOrDrugs");
            DropIndex("dbo.SponsorGroups", new[] { "SurvivorId" });
            DropIndex("dbo.SponsorGroups", new[] { "SponsorId" });
            DropIndex("dbo.Sponsors", new[] { "SurvivorId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.PrivateJournals", new[] { "SurvivorId" });
            DropIndex("dbo.MessageBoards", new[] { "SurvivorId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Survivors", new[] { "ApplicationId" });
            DropIndex("dbo.AssaultRecords", new[] { "AlcoholAndOrDrugId" });
            DropIndex("dbo.AssaultRecords", new[] { "AttackerRelationshipId" });
            DropIndex("dbo.AssaultRecords", new[] { "AssaultLocationId" });
            DropIndex("dbo.AssaultRecords", new[] { "AssaultTypeId" });
            DropIndex("dbo.AssaultRecords", new[] { "SurvivorId" });
            DropTable("dbo.SponsorGroups");
            DropTable("dbo.Sponsors");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PrivateJournals");
            DropTable("dbo.MessageBoards");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Survivors");
            DropTable("dbo.AttackerRelationships");
            DropTable("dbo.AssaultTypes");
            DropTable("dbo.AssaultRecords");
            DropTable("dbo.AssaultLocations");
            DropTable("dbo.AlcoholAndOrDrugs");
        }
    }
}
