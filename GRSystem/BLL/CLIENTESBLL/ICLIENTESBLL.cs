using GRSystem.DTO;

namespace GRSystem.BLL.CLIENTESBLL
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICLIENTESBLL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<CLIENTESRODTO?> getCliente(int Id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cgc"></param>
        /// <returns></returns>
        Task<CLIENTESRODTO?> getClienteROByCGC(string Cgc);
    }
}
