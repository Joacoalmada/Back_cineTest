﻿using Back.Data.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TpFuncionesController : ControllerBase
    {
        private readonly ITpFuncionesService _service;

        public TpFuncionesController(ITpFuncionesService service)
        {
            _service = service;
        }

        // GET: api/<TpFuncionesController>
   
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _service.ObtenerFunciones());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}
