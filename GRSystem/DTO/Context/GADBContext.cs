using Microsoft.EntityFrameworkCore;

namespace GRSystem.DTO.Context
{
    public class GADBContext : DbContext
    {
        public GADBContext(DbContextOptions<GADBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
