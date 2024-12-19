using Microsoft.EntityFrameworkCore;

namespace ASP.NET_PROJECT.Models.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Item> Items {  get; set; }
         
    }
}
