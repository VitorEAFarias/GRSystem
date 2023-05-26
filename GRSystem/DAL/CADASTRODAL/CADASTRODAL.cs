using Microsoft.EntityFrameworkCore;
using GRSystem.DTO;
using GRSystem.DTO.Context;

namespace GRSystem.DAL.CADASTRODAL
{
    /// <summary>
    /// 
    /// </summary>
    public class CADASTRODAL
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly GADBCONTEXT _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public CADASTRODAL(GADBCONTEXT context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id_Cliente"></param>
        /// <returns></returns>
        public async Task<CADASTRODTO?> getCliente(int Id_Cliente)
        {
            return await _context.CADASTRO.FromSqlRaw("SELECT * FROM CADASTRO WHERE ID_CLIENTE = ' " + Id_Cliente + " '").FirstOrDefaultAsync();
        }
    }
}
