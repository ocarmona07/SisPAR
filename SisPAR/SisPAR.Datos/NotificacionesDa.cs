namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Notificaciones
    /// </summary>
    public class NotificacionesDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        private NotificacionesDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea una Notificación
        /// </summary>
        /// <param name="notificacion">Datos de la Notificación</param>
        /// <returns>Id de confirmación</returns>
        public int CrearNotificacion(NOT_NOTIFICACION notificacion)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.NOT_NOTIFICACION.AddObject(notificacion);
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
        /// Método que obtiene todas las Notificaciones
        /// </summary>
        /// <returns>Lista de Notificaciones</returns>
        public List<NOT_NOTIFICACION> ObtenerNotificaciones()
        {
            var listaRetorno = new List<NOT_NOTIFICACION>();
            try
            {
                listaRetorno = _dbSisParEntities.NOT_NOTIFICACION.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene una Notificación por su Id
        /// </summary>
        /// <param name="idNotificacion">ID de la Notificación</param>
        /// <returns>Notificacion</returns>
        public NOT_NOTIFICACION ObtenerNotificacion(int idNotificacion)
        {
            var retorno = new NOT_NOTIFICACION();
            try
            {
                retorno = _dbSisParEntities.NOT_NOTIFICACION.Single(req => idNotificacion.Equals(req.NOT_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza una Notificación
        /// </summary>
        /// <param name="notificacion">Datos de la Notificación</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarNotificacion(NOT_NOTIFICACION notificacion)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.NOT_NOTIFICACION.Attach(notificacion);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(notificacion, EntityState.Modified);
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
        /// Método que elimina una Notificación
        /// </summary>
        /// <param name="notificacion">Datos de la Notificación</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarNotificacion(NOT_NOTIFICACION notificacion)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.NOT_NOTIFICACION.DeleteObject(notificacion);
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
