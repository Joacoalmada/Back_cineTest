using Back.Data.Models;
using Back.Data.VM;

namespace Back.Data.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllAsync();
        Task<Usuario>? GetByIdAsync(int id);
        Task<Usuario>? Login(string correo, string contrasena);
        Task<bool> SaveAsync(Usuario usuario);
        Task<bool> DeleteAsync(int id);
        Task<(bool exito, string mensaje)> RegisterAsync(UsuarioVM modelo);
    }
}
