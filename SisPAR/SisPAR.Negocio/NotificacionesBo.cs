namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Notificaciones
    /// </summary>
    public class NotificacionesBo
    {
        /// <summary>
        /// Instancia de la clase Notificaciones
        /// </summary>
        private readonly NotificacionesDa _notificacionesDa = new NotificacionesDa();

        /// <summary>
        /// Método que crea Notificaciones
        /// </summary>
        /// <param name="notificaciones">Datos de notificaciones</param>
        /// <returns>Id de notificaciones</returns>
        public int CrearNotificacion(NOT_NOTIFICACION notificaciones)
        {
            return _notificacionesDa.CrearNotificacion(notificaciones);
        }

        /// <summary>
        /// Método que obtiene las Notificaciones
        /// </summary>
        /// <returns></returns>
        public List<NOT_NOTIFICACION> ObtenerNotificaciones()
        {
            return _notificacionesDa.ObtenerNotificaciones();
        }

        /// <summary>
        /// Método que obtiene Notificaciones
        /// </summary>
        /// <param name="idNotificaciones">Id de Notificaciones</param>
        /// <returns>Notificaciones</returns>
        public NOT_NOTIFICACION ObtenerNotificacion(int idNotificaciones)
        {
            return _notificacionesDa.ObtenerNotificacion(idNotificaciones);
        }

        /// <summary>
        /// Método que actualiza un Notificaciones
        /// </summary>
        /// <param name="notificaciones">Datos de Notificaciones</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarNotificacion(NOT_NOTIFICACION notificaciones)
        {
            return _notificacionesDa.ActualizarNotificacion(notificaciones);
        }

        /// <summary>
        /// Método que elimina Notificaciones
        /// </summary>
        /// <param name="notificaciones">Datos de Notificaciones</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarNotificacion(NOT_NOTIFICACION notificaciones)
        {
            return _notificacionesDa.EliminarNotificacion(notificaciones);
        }
    }
}
