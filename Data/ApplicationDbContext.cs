using GiftOfTheGivers.Models;
using Microsoft.EntityFrameworkCore;

namespace GiftOfTheGivers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VolunteerApplication> VolunteerApplications { get; set; }



        public DbSet<Donation> Donations { get; set; }
    }
}