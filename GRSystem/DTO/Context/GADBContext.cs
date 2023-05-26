using Microsoft.EntityFrameworkCore;
using RO_Garantias.DTO;

namespace GRSystem.DTO.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class GADBCONTEXT : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public GADBCONTEXT(DbContextOptions<GADBCONTEXT> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<CLIENTESRODTO> CLIENTES { get; private set; }
    }
}
