using System;
using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class UsuarioRepo
    {
        private List<Usuario> _usuarios = new List<Usuario>
        {
            new Usuario 
            { 
                IdUsuario = 1, 
                Nombre = "DT", 
                Apellido = "Pro", 
                Email = "dt@grandt.com", 
                FechaNacimiento = new DateTime(2000, 1, 1), 
                Pass = "123", 
                Administrador = true 
            }
        };

        public List<Usuario> ObtenerTodos()
        {
            return _usuarios;
        }

        public Usuario? ObtenerPorId(int idUsuario)
        {
            foreach (Usuario usuario in _usuarios)
            {
                if (usuario.IdUsuario == idUsuario)
                {
                    return usuario;
                }
            }
            return null;
        }

        public Usuario? ValidarLogin(string email, string contraseña)
        {
        foreach (Usuario usuario in _usuarios)
            {
                if (usuario.Email == email && usuario.Pass == contraseña)
                {
                    return usuario;
                }
            }
            return null;
        }
        public void Agregar(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }
    }
}