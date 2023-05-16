using Microsoft.EntityFrameworkCore;

namespace Wearingweb.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options) { }

        public DbSet<AddItem> Items { get; set; }

    }
}
