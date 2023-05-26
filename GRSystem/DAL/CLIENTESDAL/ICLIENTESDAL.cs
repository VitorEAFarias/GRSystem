using RO_Garantias.DTO;

namespace RO_Garantias.DAL.CLIENTESDAL
{
    public interface ICLIENTESDAL
    {
        Task<CLIENTESRODTO?> getCliente(int Id);
    }
}
