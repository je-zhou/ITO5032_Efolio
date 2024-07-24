using Microsoft.EntityFrameworkCore;
using _2._2.Models;

namespace _2._2.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
