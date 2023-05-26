using GRSystem.DTO.Context;
using Microsoft.EntityFrameworkCore;
using GRSystem.DTO;

namespace GRSystem.DAL.CLIENTESDAL
{
    /// <summary>
    /// 
    /// </summary>
    public class CLIENTESDAL : ICLIENTESDAL
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly GADBCONTEXT _context;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public CLIENTESDAL(GADBCONTEXT context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<CLIENTESRODTO?> getCliente(int Id)
        {
            return await _context.CLIENTES.FindAsync(Id);
        }

        /// <summary>
        /// Consulta a view CLIENTES_REIS_OFFICE
        /// </summary>
        /// <param name="Cgc"></param>
        /// <returns></returns>
        public async Task<CLIENTESRODTO?> getClienteROByCGC(string Cgc)
        {
            return await _context.CLIENTES.FromSqlRaw("SELECT * FROM CLIENTES_REIS_OFFICE WHERE CNPJ = ' " + Cgc + " '").FirstOrDefaultAsync();
        }
    }
}
