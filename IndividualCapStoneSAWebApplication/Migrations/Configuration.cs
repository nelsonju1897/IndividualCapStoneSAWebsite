namespace IndividualCapStoneSAWebApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IndividualCapStoneSAWebApplication.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IndividualCapStoneSAWebApplication.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.AlcoholAndOrDrugs.AddOrUpdate
                (
                new Models.AlcoholAndOrDrugs { AlcoholAndOrDrugsId = 1, AlcoholAndOrDrugsName = "Alcohol" },
                new Models.AlcoholAndOrDrugs { AlcoholAndOrDrugsId = 2, AlcoholAndOrDrugsName = "Drugs" }
                );
            context.AssaultLocation.AddOrUpdate
                (
                new Models.AssaultLocation { AssaultLocationId = 1, AssaultLocationName = "My Home"},
                new Models.AssaultLocation { AssaultLocationId = 2, AssaultLocationName = "Social Gathering" },
                new Models.AssaultLocation { AssaultLocationId = 3, AssaultLocationName = "Park" },
                new Models.AssaultLocation { AssaultLocationId = 4, AssaultLocationName = "School" },
                new Models.AssaultLocation { AssaultLocationId = 5, AssaultLocationName = "Relatives Home" },
                new Models.AssaultLocation { AssaultLocationId = 6, AssaultLocationName = "Work" },
                new Models.AssaultLocation { AssaultLocationId = 7, AssaultLocationName = "Other" }
                );
            context.AssaultType.AddOrUpdate
                (
                new Models.AssaultType { AssaultTypeId = 1, AssaultTypeName = "Attempted Rape"},
                new Models.AssaultType { AssaultTypeId = 1, AssaultTypeName = "Fondling or Unwanted Sexual Touching" },
                new Models.AssaultType { AssaultTypeId = 1, AssaultTypeName = "Forced sexual acts on the perpetrators body" },
                new Models.AssaultType { AssaultTypeId = 1, AssaultTypeName = "Rape" }
                );
            context.AttackerRelationship.AddOrUpdate
                (
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Boyfriend" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Girlfriend" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Mother" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Father" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Male Date" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Female Date" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Brother" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Sister" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Uncle" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Aunt" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Male Relative: Other" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Femaile Relative: Other" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Male Stranger" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Female Stranger" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Male Friend" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Femaile Friend" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Male Acquaintance" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Female Acquaintance" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Male Community Member" },
                new Models.AttackerRelationship { AttackerRelationshipId = 1, AttackerRelationshipName = "Female Community Member" }

                );

        }
    }
}
