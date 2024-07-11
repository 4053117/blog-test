using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using blog_test.Models;

namespace blog_test.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<blog_test.Models.Blog> Blog { get; set; } = default!;
        public DbSet<blog_test.Models.Post> Post { get; set; } = default!;
    }
}
