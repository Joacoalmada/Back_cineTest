using Back.Data.Models;
using Back.Data.Repository.Interfaces;
using Back.Data.VM;
using Microsoft.EntityFrameworkCore;

namespace Back.Data.Repository.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CineDBContext _context;

        public UsuarioRepository(CineDBContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var usuario = GetByIdAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(await usuario);
                return await _context.SaveChangesAsync() != 0;
            }
            return false;
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario>? GetByIdAsync(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == id);
            if (usuario != null)
            {
                return usuario;
            }
            return null;
        }

       
        public async Task<Usuario>? Login(string correo, string contrasena)
        {
            var login = await _context.Usuarios.Where(l => l.Email== correo && l.Contrasena == contrasena).FirstOrDefaultAsync();
            if (login != null)
            {
                return login;
            }
            return null;
        }

        public async Task<(bool exito, string mensaje)> RegisterAsync(UsuarioVM modelo)
        {
            if (modelo.Contrasena != modelo.RepetirContraseña)
            {
                return (false, "Las contraseñas no coinciden");
            }

            Usuario Usuario = new Usuario
            {
                Nombre = modelo.Nombre,
                Apellido = modelo.Apellido,
                Email = modelo.Email,
                Contrasena = modelo.Contrasena
            };

            await _context.Usuarios.AddAsync(Usuario);
            await _context.SaveChangesAsync();

            if (Usuario.IdUsuario != 0)
            {
                return (true, "Usuario registrado exitosamente");
            }

            return (false, "No se pudo crear el usuario");
        }

        public async Task<bool> SaveAsync(Usuario usuario)
        {
            if (usuario.IdUsuario == 0) 
            {
                _context.Usuarios.Add(usuario);
            }
            else
            {
                _context.Usuarios.Update(usuario);
            }
            return await _context.SaveChangesAsync() != 0;
        }
    }
}
