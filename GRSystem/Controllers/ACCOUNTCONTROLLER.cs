using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GRSystem.BLL.CADASTROBLL;
using GRSystem.DTO;

namespace GRSystem.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ACCOUNTCONTROLLER : ControllerBase
    {
        private readonly ICADASTROBLL _cadastro;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cadastro"></param>
        public ACCOUNTCONTROLLER(ICADASTROBLL Cadastro)
        {
            _cadastro = Cadastro;    
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Register"></param>
        /// <returns></returns>
        //[HttpPost("Register")]
        //[AllowAnonymous]
        //public async Task<IActionResult> Register(CADASTRODTO Register)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cgc"></param>
        /// <returns></returns>
        [HttpGet("Cgc")]
        [AllowAnonymous]
        public async Task<IActionResult> ConsultRegister(string Cgc)
        {
            try
            {
                var getCgcRO = await _cadastro.getClienteROByCGC(Cgc);

                if (getCgcRO != null)
                {
                    return Ok(new { message = "Usuário ja cadastrado!!! Efetue o login com suas credenciais.", data = getCgcRO, result = true });
                }
                else
                {
                    return BadRequest(new { message = "È necessário ser cadastrado para acessar o sistema de garantias", result = false });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
