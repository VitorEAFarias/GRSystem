using GRSystem.DAL.CADASTRODAL;
using GRSystem.DAL.CLIENTESDAL;
using GRSystem.DTO;

namespace GRSystem.BLL.CADASTROBLL
{
    /// <summary>
    /// 
    /// </summary>
    public class CADASTROBLL : ICADASTROBLL
    {
        private readonly ICADASTRODAL _cadastro;
        private readonly ICLIENTESDAL _cliente;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cadastro"></param>
        /// <param name="Cliente"></param>
        public CADASTROBLL(ICADASTRODAL Cadastro, ICLIENTESDAL Cliente)
        {
            _cadastro = Cadastro;
            _cliente = Cliente;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cgc"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<CADASTRODTO?> getClienteROByCGC(string Cgc)
        {
            try
            {
                var getCgc = await _cliente.getClienteROByCGC(Cgc);

                if (Cgc != null)
                {
                    var checkUser = await _cadastro.checkRegisterUser(getCgc.CODCLI);

                    if (checkUser != null)
                    {
                        return checkUser;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
