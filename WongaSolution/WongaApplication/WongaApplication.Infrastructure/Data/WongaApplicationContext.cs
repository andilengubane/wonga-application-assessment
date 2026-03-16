using Microsoft.EntityFrameworkCore;
using WongaApplication.Domain.Entities;

namespace WongaApplication.Infrastructure.Data
{
    public class WongaApplicationContext : DbContext
    {
        public WongaApplicationContext() { }
        public WongaApplicationContext(DbContextOptions<WongaApplicationContext> option)
               : base(option)
        {
        }
        public DbSet<UserEntitiy> User { get; set; }
    }
}
