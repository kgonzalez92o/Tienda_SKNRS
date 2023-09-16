using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda_Snkrs_api.Datos;
using Tienda_Snkrs_api.Models;
using Tienda_Snkrs_api.Models.Dto;

namespace Tienda_Snkrs_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SnkrsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<SnkrDto>> GetSnkrs()
        {
            if(SnkrStore.listaSnkr == null)
            {
                return BadRequest();
            }
            return Ok( SnkrStore.listaSnkr);
        }

        [HttpGet("id")]
        public ActionResult<SnkrDto> GetSnkrID(int id)
        {
            if (id==0)
            {
                return BadRequest();
            }

            var snkr = SnkrStore.listaSnkr.FirstOrDefault(s => s.Id == id);
            if (snkr == null)
            {
                return NotFound();
            }
            return Ok(snkr);
        }
    }
}
