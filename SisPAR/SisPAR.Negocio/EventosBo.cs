namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Eventos
    /// </summary>
    public class EventosBo
    {
        /// <summary>
        /// Instancia de la clase EventosDa
        /// </summary>
        private readonly EventosDa _eventosDa = new EventosDa();

        /// <summary>
        /// Método que crea un Evento
        /// </summary>
        /// <param name="evento">Datos del evento</param>
        /// <returns>Id de evento</returns>
        public int CrearEvento(EVE_EVENTO evento)
        {
            return _eventosDa.CrearEvento(evento);
        }

        /// <summary>
        /// Método que obtiene todas los Eventos
        /// </summary>
        /// <returns></returns>
        public List<EVE_EVENTO> ObtenerEventos()
        {
            return _eventosDa.ObtenerEventos();
        }

        /// <summary>
        /// Método que obtiene un Eventos
        /// </summary>
        /// <param name="idEvento">Id de Evento</param>
        /// <returns>Evento</returns>
        public EVE_EVENTO ObtenerEvento(int idEvento)
        {
            return _eventosDa.ObtenerEvento(idEvento);
        }

        /// <summary>
        /// Método que actualiza una Eventos
        /// </summary>
        /// <param name="evento">Datos del Evento</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEvento(EVE_EVENTO evento)
        {
            return _eventosDa.ActualizarEvento(evento);
        }

        /// <summary>
        /// Método que elimina un Evento
        /// </summary>
        /// <param name="idEvento">Id del Evento</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEvento(int idEvento)
        {
            return _eventosDa.EliminarEvento(idEvento);
        }
    }
}
