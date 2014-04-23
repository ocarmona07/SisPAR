
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
        /// <param name="usuarios">Datos de Usuarios</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarUsuario(USU_USUARIO usuarios)
        {
            return _usuariosDa.EliminarUsuario(usuarios);
        }

        /// <summary>
        /// Método que valida el ingreso del usuario
        /// </summary>
        /// <param name="usuario">Datos del usuario</param>
        /// <returns>Validación usuario</returns>
        public bool ComprobarUsuario(USU_USUARIO usuario)
        {
            var comprobar = _usuariosDa.ObtenerUsuarios().Count(usu => usuario.USU_RUT.Equals(usu.USU_RUT) && usuario.USU_PASSWORD.Equals(usu.USU_PASSWORD));
            return comprobar > 0;
        }
    }
}
