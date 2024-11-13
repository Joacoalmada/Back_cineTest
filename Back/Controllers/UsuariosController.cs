using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;
using Back.Data.VM;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _service;
        private readonly IUsuarioRepository _repo;

        public UsuariosController(IUsuarioService service , IUsuarioRepository repo)
        {
            _service = service;
            _repo = repo;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _service.ObtenerUsuarios());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                if(id > 0)
                {
                    return Ok(await _service.ObtenerUsuarioPorId(id));
                }
                else
                {
                    return BadRequest("Dato requerido ingresado incorrectamente");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<UsuariosController>
        [HttpGet("Login")]
        public async Task<IActionResult> Get([FromQuery]string correo, [FromQuery]string contrasena)
        {
            try
            {
                if(ValidarNombre(correo, contrasena))
                {
                    var login = await _service.Login(correo, contrasena);
                    if (login == null) 
                    {
                        return StatusCode(401,"Correo o Contraseña incorrecta, Intente nuevamente");
                    }
                    else 
                    {
                        return Ok(login);
                    }
                    
                }
                else
                {
                    return BadRequest("Datos requeridos ingresados incorrectamente");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        private bool ValidarNombre(string correo, string contrasena)
        {
            return !string.IsNullOrEmpty(correo) && !string.IsNullOrEmpty(contrasena);
        }

        // POST api/<UsuariosController>
        [HttpPost("Registrar")]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                if (ValidarUsuario(usuario))
                {
                    if (_service.GuardarUsuario(usuario).Result)
                    {
                        return Ok("Usuario guardado correctamente!");
                    }
                    else
                    {
                        return StatusCode(500, "No se ha podido guardar el usuario");
                    }
                }
                else
                {
                    return BadRequest("Datos requeridos ingresados incorrectamente");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        private bool ValidarUsuario(Usuario usuario)
        {
            return ValidarNombre(usuario.Email, usuario.Contrasena) && ValidarCampoVacio(usuario.Apellido) && ValidarCampoVacio(usuario.Contrasena);
        }

        private bool ValidarCampoVacio(string campo)
        {
            return !string.IsNullOrEmpty(campo);
        }


        [HttpPost("RegisterUser")]
        public async Task<IActionResult> Register([FromBody] UsuarioVM modelo)
        {
            var (exito, mensaje) = await _repo.RegisterAsync(modelo);
            if (!exito)
            {
                return BadRequest(new { mensaje });
            }
            return Ok(new { mensaje });
        }


        // PUT api/<UsuariosController>/5
        [HttpPut("Modificar")]
        public IActionResult Put([FromBody] Usuario usuario)
        {
            try
            {
                if (ValidarUsuario(usuario))
                {
                    if (_service.GuardarUsuario(usuario).Result)
                    {
                        return Ok("Usuario actualizado correctamente!");
                    }
                    else
                    {
                        return StatusCode(500, "No se ha podido actualizar el usuario");
                    }
                }
                else
                {
                    return BadRequest("Datos requeridos ingresados incorrectamente");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("Borrar {id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if(id > 0)
                {
                    if (_service.EliminarUsuario(id).Result)
                    {
                        return Ok("Usuario eliminado correctamente!");
                    }
                    else
                    {
                        return StatusCode(500, "No se ha podido eliminar el usuario");
                    }
                }
                else
                {
                    return BadRequest("Dato requerido ingresado incorrectamente");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
