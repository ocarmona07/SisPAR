﻿
namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Usuarios
    /// </summary>
    public class UsuariosBo
    {
        /// <summary>
        /// Instancia de la clase Usuarios
        /// </summary>
        private readonly UsuariosDa _usuariosDa = new UsuariosDa();

        /// <summary>
        /// Método que crea Usuarios
        /// </summary>
        /// <param name="usuarios">Datos de usuarios</param>
        /// <returns>Id de usuarios</returns>
        public int CrearUsuario(USU_USUARIO usuarios)
        {
            return _usuariosDa.CrearUsuario(usuarios);
        }

        /// <summary>
        /// Método que obtiene los Usuarios
        /// </summary>
        /// <returns></returns>
        public List<USU_USUARIO> ObtenerUsuarios()
        {
            return _usuariosDa.ObtenerUsuarios();
        }

        /// <summary>
        /// Método que obtiene Usuarios
        /// </summary>
        /// <param name="idUsuarios">Id de Usuarios</param>
        /// <returns>Usuarios</returns>
        public USU_USUARIO ObtenerUsuario(int idUsuarios)
        {
            return _usuariosDa.ObtenerUsuario(idUsuarios);
        }

        /// <summary>
        /// Método que actualiza Usuarios
        /// </summary>
        /// <param name="usuarios">Datos de Usuarios</param>
        /// <returns>Id de usuarios</returns>
        public int ActualizarUsuario(USU_USUARIO usuarios)
        {
            return _usuariosDa.ActualizarUsuario(usuarios);
        }

        /// <summary>
        /// Método que elimina Usuarios
        /// </summary>
        /// <param name="idUsuario">Id de Usuarios</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarUsuario(int idUsuario)
        {
            return _usuariosDa.EliminarUsuario(idUsuario);
        }

        /// <summary>
        /// Método que valida el ingreso del usuario
        /// </summary>
        /// <param name="rutUsuario">Rut del usuario</param>
        /// <returns>Validación usuario</returns>
        public bool ComprobarUsuarioFront(int rutUsuario)
        {
            var comprobar = _usuariosDa.ObtenerUsuarios().Count(usu => usu.USU_RUT.Equals(rutUsuario));
            return comprobar > 0;
        }

        /// <summary>
        /// Método que valida el ingreso del usuario
        /// </summary>
        /// <param name="rutUsuario">Rut del usuario</param>
        /// <param name="password">Contraseña del usuario</param>
        /// <returns>Validación usuario</returns>
        public bool ComprobarUsuarioBack(int rutUsuario, string password)
        {
            var comprobar = _usuariosDa.ObtenerUsuarios().Count(usu => usu.USU_RUT.Equals(rutUsuario) && usu.USU_PASSWORD.Equals(password));
            return comprobar > 0;
        }

        /// <summary>
        /// Método que obtiene el nombre de un Usuario por su RUT
        /// </summary>
        /// <param name="rutUsuarios">rut de Usuario</param>
        /// <returns>Nombre Usuarios</returns>
        public string ObtenerUsuarioPorRut(int rutUsuarios)
        {
            var usuario = _usuariosDa.ObtenerUsuarios().First(usu => usu.USU_RUT.Equals(rutUsuarios));
            return usuario.USU_NOMBRE + " " + usuario.USU_APELLIDO;
        }
    }
}
