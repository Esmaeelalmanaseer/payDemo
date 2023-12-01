using Microsoft.EntityFrameworkCore;
using payDemo.Models;

namespace payDemo.Data
{
    public class payDataContext:DbContext
    {
        public payDataContext(DbContextOptions options ) : base(options) 
        {
            
        }
        public DbSet<Paydetals> paydetals { get; set; }
    }
}
