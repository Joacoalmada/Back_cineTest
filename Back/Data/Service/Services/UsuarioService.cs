using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.Service.Interfaces;

namespace Back.Data.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> EliminarUsuario(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task<bool> GuardarUsuario(Usuario usuario)
        {
            return _repository.SaveAsync(usuario);
        }

        public Task<Usuario>? Login(string correo, string contrasena)
        {
            return _repository.Login(correo, contrasena);
        }

        public Task<Usuario>? ObtenerUsuarioPorId(int id)
        {
            return _repository.GetByIdAsync(id);
        }

       

        public Task<List<Usuario>> ObtenerUsuarios()
        {
            return _repository.GetAllAsync();
        }
    }
}
