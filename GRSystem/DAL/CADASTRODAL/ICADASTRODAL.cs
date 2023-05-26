using GRSystem.DTO;

namespace GRSystem.DAL.CADASTRODAL
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICADASTRODAL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<CADASTRODTO> checkRegisterUser(int Id);
    }
}
