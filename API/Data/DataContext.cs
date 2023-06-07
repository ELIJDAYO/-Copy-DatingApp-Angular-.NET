using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    // service in application
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        // represents tables inside db
        public DbSet<AppUser> Users {get;set;}
    }
}