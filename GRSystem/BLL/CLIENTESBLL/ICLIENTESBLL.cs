using RO_Garantias.DTO;

namespace RO_Garantias.BLL.CLIENTESBLL
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
    }
}
