using Microsoft.EntityFrameworkCore;

namespace SignalRApi.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) :base(opt)
        {
            
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
