using RO_Garantias.DAL.CLIENTESDAL;
using RO_Garantias.DTO;

namespace RO_Garantias.BLL.CLIENTESBLL
{
    /// <summary>
    /// 
    /// </summary>
    public class CLIENTESBLL : ICLIENTESBLL
    {
        private readonly ICLIENTESDAL _cliente;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cliente"></param>
        public CLIENTESBLL(ICLIENTESDAL Cliente)
        {
            _cliente = Cliente;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<CLIENTESRODTO?> getCliente(int Id)
        {
            try
            {
                var getCliente = await _cliente.getCliente(Id);

                if (getCliente != null)
                {
                    return getCliente;
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
