using Back.Data.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        public readonly IGeneroService _service;

        public GeneroController (IGeneroService service) 
        {
            _service = service;
        }

        // GET: api/<GeneroController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _service.ObtenerGeneros());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }   


    }
}
