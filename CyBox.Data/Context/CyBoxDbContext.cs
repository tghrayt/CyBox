

using CyBox.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CyBox.Data.Context
{
    public class CyBoxDbContext : DbContext
    {
        public CyBoxDbContext(DbContextOptions<CyBoxDbContext> options) : base(options)
        {
                
        }

        public DbSet<User> Users { get; set; }
    }
}
