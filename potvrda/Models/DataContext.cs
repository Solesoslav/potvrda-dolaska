using Microsoft.EntityFrameworkCore;

namespace potvrda.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        public DbSet<OdgovoriRoditelja> Odgovori { get; set; }
    }
}
