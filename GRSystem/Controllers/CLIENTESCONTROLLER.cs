using Microsoft.AspNetCore.Mvc;
using RO_Garantias.BLL.CLIENTESBLL;

namespace RO_Garantias.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CLIENTESCONTROLLER : ControllerBase
    {
        private readonly ILogger<CLIENTESCONTROLLER> _logger;
        private readonly ICLIENTESBLL _cliente;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Logger"></param>
        /// <param name="Cliente"></param>
        public CLIENTESCONTROLLER(ILogger<CLIENTESCONTROLLER> Logger, ICLIENTESBLL Cliente)
        {
            _logger = Logger;
            _cliente = Cliente;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public async Task<IActionResult> getCliente(int Id)
        {
            try
            {
                var getCliente = await _cliente.getCliente(Id);

                if (getCliente != null)
                {
                    return Ok(new { message = "Cliente encontrado!!!", result = true, data = getCliente });
                }
                else
                {
                    return BadRequest(new { message = "Categoria não encontrada", result = false });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}