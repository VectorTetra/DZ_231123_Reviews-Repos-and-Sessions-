using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Models
{
    public class ReviewContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public ReviewContext(DbContextOptions<ReviewContext> options)
            : base(options)
        { 
            Database.EnsureCreated(); 
        }
    }
}
