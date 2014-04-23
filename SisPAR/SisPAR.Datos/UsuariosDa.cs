namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Usuarios
    /// </summary>
    public class UsuariosDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        public UsuariosDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea un Usuario
        /// </summary>
        /// <param name="usuario">Datos del Usuario</param>
        /// <returns>Id de confirmación</returns>
        public int CrearUsuario(USU_USUARIO usuario)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.USU_USUARIO.AddObject(usuario);
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
        /// Método que obtiene todos los Usuarios
        /// </summary>
        /// <returns>Lista de Usuarios</returns>
        public List<USU_USUARIO> ObtenerUsuarios()
        {
            var listaRetorno = new List<USU_USUARIO>();
            try
            {
                listaRetorno = _dbSisParEntities.USU_USUARIO.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene un Usuario por su Id
        /// </summary>
        /// <param name="idUsuario">ID del Usuario</param>
        /// <returns>Usuario</returns>
        public USU_USUARIO ObtenerUsuario(int idUsuario)
        {
            var retorno = new USU_USUARIO();
            try
            {
                retorno = _dbSisParEntities.USU_USUARIO.Single(req => idUsuario.Equals(req.USU_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Usuario
        /// </summary>
        /// <param name="usuario">Datos del Usuario</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarUsuario(USU_USUARIO usuario)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.USU_USUARIO.Attach(usuario);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(usuario, EntityState.Modified);
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
        /// Método que elimina un Usuario
        /// </summary>
        /// <param name="usuario">Datos del Usuario</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarUsuario(USU_USUARIO usuario)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.USU_USUARIO.DeleteObject(usuario);
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
