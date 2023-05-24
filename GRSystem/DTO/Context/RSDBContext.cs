using Innofactor.EfCoreJsonValueConverter;
using Microsoft.EntityFrameworkCore;

namespace GRSystem.DTO.Context
{
    public class RSDBContext : DbContext
    {
        public RSDBContext(DbContextOptions<RSDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<CLIENTESDTO> CLIENTES { get; private set; }
    }
}
