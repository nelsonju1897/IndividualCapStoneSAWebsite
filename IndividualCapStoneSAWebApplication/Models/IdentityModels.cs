using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IndividualCapStoneSAWebApplication.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<AssaultRecord> AssaultRecords { get; set;}
        public DbSet<AlcoholAndOrDrugs> AlcoholAndOrDrugs { get; set; }
        public DbSet<AssaultLocation> AssaultLocation { get; set; }
        public DbSet<AssaultType> AssaultType { get; set; }
        public DbSet<AttackerRelationship> AttackerRelationship { get; set; }
        public DbSet<MessageBoard> MessageBoard { get; set; }
        public DbSet<PrivateJournal> PrivateJournal { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }
        public DbSet<SponsorGroup> SponsorGroup { get; set; }
        public DbSet<Survivor> Survivor { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}