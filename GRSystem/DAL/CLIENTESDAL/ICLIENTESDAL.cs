using GRSystem.DTO;

namespace GRSystem.DAL.CLIENTESDAL
{
    public interface ICLIENTESDAL
    {
        Task<CLIENTESRODTO?> getCliente(int Id);        
        Task<CLIENTESRODTO?> getClienteROByCGC(string Cgc);
    }
}
