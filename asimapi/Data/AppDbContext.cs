


using asimapi.Model;
using Microsoft.EntityFrameworkCore;

namespace asimapi.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base (options)
        {
            
        }
        public DbSet<SignupForm> SignupForm { get; set; }
    }
}
