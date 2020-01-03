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
            context.ContactInfo.AddOrUpdate
                (
                new Models.ContactInfo { ContactId = 1, ContactNumber = "(920) 288-8500", Name = "Aurora Fertility Services-Aurora BayCare Medical Center", Location = "2845 Greenbrier Rd Ste 350, Green Bay, WI 54311", Type = "Clinic"  },
                new Models.ContactInfo { ContactId = 2, ContactNumber = "(414) 805-7376", Name = "Froedtert and Medical College of Wisconsin", Location = "W129N7055 Northfield Dr Bldg B Ste 500, Menomonee Falls, WI 53051", Type = "Clinic" },
                new Models.ContactInfo { ContactId = 3, ContactNumber = "(608)824-6160", Name = "Generations Fertility Care", Location = "2365 Deming Way Middleton, WI 53562", Type = "Clinic" },
                new Models.ContactInfo { ContactId = 4, ContactNumber = "(608) 824-0075", Name = "Wisconsin Fertility Institute", Location = "3146 Deming Way Middleton, WI 53562", Type = "Clinic" },
                new Models.ContactInfo { ContactId = 5, ContactNumber = "(414) 289-9668", Name = "Reproductive Specialty Center", Location = "2350 N Lake Dr Ste 504 Milwaukee, WI 53211", Type = "Clinic" },
                new Models.ContactInfo { ContactId = 6, ContactNumber = "(414) 329-4300", Name = "Aurora Fertility Services- West Allis Memorial Hospital", Location = "8901 W Lincoln Ave 2nd Fl West Allis, WI 53227", Type = "Clinic" },
                new Models.ContactInfo { ContactId = 7, ContactNumber = "(608) 251-7273", Name = "Rape Crisis Center Sexual Assault HotLines", Location = "2801 Coho Street, Madison WI, 53713", Type = "HotLine" },
                new Models.ContactInfo { ContactId = 8, ContactNumber = "(800) 924-9918", Name = "The Bridge to Hope: Domestic Violence/Sexual Assault Services", Location = "2110 4TH AVENUE NORTHEAST, MENOMONIE WI, 54751", Type = "HotLine" },
                new Models.ContactInfo { ContactId = 8, ContactNumber = "(715) 634-9360", Name = "OakWoodHaven Domestic Abuse Shelter", Location = "13394 West Trepania Road, Hayward WI, 54843", Type = "Shelter" },
                new Models.ContactInfo { ContactId = 8, ContactNumber = "(800) 924-2624", Name = "Family Advocates Domestic Violence/Sexual Assault Services", Location = "250 N COURT ST, PLATTEVILLE WI, 53818", Type = "Shelter" }
                );
            context.AlcoholAndOrDrugs.AddOrUpdate
                (
                new Models.AlcoholAndOrDrugs { AlcoholAndOrDrugsId = 1, AlcoholAndOrDrugsName = "Alcohol" },
                new Models.AlcoholAndOrDrugs { AlcoholAndOrDrugsId = 2, AlcoholAndOrDrugsName = "Drugs" },
                new Models.AlcoholAndOrDrugs { AlcoholAndOrDrugsId = 3, AlcoholAndOrDrugsName = "Both"}
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
