namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Eventos
    /// </summary>
    public class EventosDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        private EventosDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea un Evento
        /// </summary>
        /// <param name="evento">Datos del Evento</param>
        /// <returns>Id de confirmación</returns>
        public int CrearEvento(EVE_EVENTO evento)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EVE_EVENTO.AddObject(evento);
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
        /// Método que obtiene todos los Eventos
        /// </summary>
        /// <returns>Lista de Eventos</returns>
        public List<EVE_EVENTO> ObtenerEventos()
        {
            var listaRetorno = new List<EVE_EVENTO>();
            try
            {
                listaRetorno = _dbSisParEntities.EVE_EVENTO.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene un Evento por su Id
        /// </summary>
        /// <param name="idEvento">ID del Evento</param>
        /// <returns>Evento</returns>
        public EVE_EVENTO ObtenerEvento(int idEvento)
        {
            var retorno = new EVE_EVENTO();
            try
            {
                retorno = _dbSisParEntities.EVE_EVENTO.Single(req => idEvento.Equals(req.EVE_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Evento
        /// </summary>
        /// <param name="evento">Datos del Evento</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEvento(EVE_EVENTO evento)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EVE_EVENTO.Attach(evento);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(evento, EntityState.Modified);
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
        /// Método que elimina un Evento
        /// </summary>
        /// <param name="evento">Datos del Evento</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEvento(EVE_EVENTO evento)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EVE_EVENTO.DeleteObject(evento);
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
