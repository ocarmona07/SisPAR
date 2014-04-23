namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Roles
    /// </summary>
    public class RolesBo
    {
        /// <summary>
        /// Instancia de la clase Roles
        /// </summary>
        private readonly RolesDa _rolesDa = new RolesDa();

        /// <summary>
        /// Método que crea Roles
        /// </summary>
        /// <param name="roles">Datos de roles</param>
        /// <returns>Id de roles</returns>
        public int CrearRoles(ROL_ROL roles)
        {
            return _rolesDa.CrearRoles(roles);
        }
        
        /// <summary>
        /// Método que obtiene los Roles
        /// </summary>
        /// <returns></returns>
        public List<ROL_ROL> ObtenerRoles()
        {
            return _rolesDa.ObtenerRoles();
        }

        /// <summary>
        /// Método que obtiene Roles
        /// </summary>
        /// <param name="idRoles">Id de Roles</param>
        /// <returns>Roles</returns>
        public ROL_ROL ObtenerRol(int idRoles)
        {
            return _rolesDa.ObtenerRol(idRoles);
        }

        /// <summary>
        /// Método que actualiza Roles
        /// </summary>
        /// <param name="roles">Datos de Roles</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarRol(ROL_ROL roles)
        {
            return _rolesDa.ActualizarRol(roles);
        }

        /// <summary>
        /// Método que elimina Roles
        /// </summary>
        /// <param name="roles">Datos de Roles</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarRol(ROL_ROL roles)
        {
            return _rolesDa.EliminarRol(roles);
        }
    }
}
