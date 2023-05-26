using GRSystem.DTO.Context;
using RO_Garantias.DTO;

namespace RO_Garantias.DAL.CLIENTESDAL
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
    }
}
