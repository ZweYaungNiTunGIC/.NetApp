using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entity;
namespace WebApplication1.Data
{
    public class ApplicationDBContext : DbContext 
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { 
            
        }

        public DbSet<Student> Students { get; set; }
        
    }
}
