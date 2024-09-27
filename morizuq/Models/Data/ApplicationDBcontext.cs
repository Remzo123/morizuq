using Microsoft.EntityFrameworkCore;

namespace morizuq.Models.Data
{
    public class ApplicationDBcontext:DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
