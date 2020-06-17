using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MentorHub.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Sessions> Sessions { get; set; }
        public DbSet<Occupations> Occupations { get; set; }
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