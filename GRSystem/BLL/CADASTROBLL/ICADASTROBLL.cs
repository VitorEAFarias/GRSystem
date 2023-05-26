using GRSystem.DTO;

namespace GRSystem.BLL.CADASTROBLL
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICADASTROBLL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cgc"></param>
        /// <returns></returns>
        Task<CADASTRODTO?> getClienteROByCGC(string Cgc);
    }
}
