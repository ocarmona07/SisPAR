namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Roles
    /// </summary>
    public class RolesDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        private RolesDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea un Roles
        /// </summary>
        /// <param name="rol">Datos del Rol</param>
        /// <returns>Id de confirmación</returns>
        public int CrearRoles(ROL_ROL rol)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.ROL_ROL.AddObject(rol);
                idRetorno = _dbSisParEntities.SaveChanges();
                _dbSisParEntities.Dispose();
                return idRetorno;
            }
            catch (Exception)
            {
                return idRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene todos los Roles
        /// </summary>
        /// <returns>Lista de Roles</returns>
        public List<ROL_ROL> ObtenerRoles()
        {
            var listaRetorno = new List<ROL_ROL>();
            try
            {
                listaRetorno = _dbSisParEntities.ROL_ROL.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene un Rol por su Id
        /// </summary>
        /// <param name="idRol">ID del Rol</param>
        /// <returns>Rol</returns>
        public ROL_ROL ObtenerRol(int idRol)
        {
            var retorno = new ROL_ROL();
            try
            {
                retorno = _dbSisParEntities.ROL_ROL.Single(req => idRol.Equals(req.ROL_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Rol
        /// </summary>
        /// <param name="rol">Datos del Rol</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarRol(ROL_ROL rol)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.ROL_ROL.Attach(rol);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(rol, EntityState.Modified);
                idRetorno = _dbSisParEntities.SaveChanges();
                _dbSisParEntities.Dispose();
                return idRetorno;
            }
            catch (Exception)
            {
                return idRetorno;
            }
        }

        /// <summary>
        /// Método que elimina un Rol
        /// </summary>
        /// <param name="rol">Datos del Rol</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarRol(ROL_ROL rol)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.ROL_ROL.DeleteObject(rol);
                idRetorno = _dbSisParEntities.SaveChanges();
                _dbSisParEntities.Dispose();
                return idRetorno;
            }
            catch (Exception)
            {
                return idRetorno;
            }
        }
    }
}
