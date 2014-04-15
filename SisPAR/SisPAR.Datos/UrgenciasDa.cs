namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Urgencias
    /// </summary>
    public class UrgenciasDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        private UrgenciasDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea una Urgencia
        /// </summary>
        /// <param name="urgencia">Datos de la Urgencia</param>
        /// <returns>Id de confirmación</returns>
        public int CrearUrgencia(URG_URGENCIA urgencia)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.URG_URGENCIA.AddObject(urgencia);
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
        /// Método que obtiene todas las Urgencias
        /// </summary>
        /// <returns>Lista de Urgencias</returns>
        public List<URG_URGENCIA> ObtenerUrgencias()
        {
            var listaRetorno = new List<URG_URGENCIA>();
            try
            {
                listaRetorno = _dbSisParEntities.URG_URGENCIA.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene una Urgencia por su Id
        /// </summary>
        /// <param name="idUrgencia">ID de la Urgencia</param>
        /// <returns>Urgencia</returns>
        public URG_URGENCIA ObtenerUrgencia(int idUrgencia)
        {
            var retorno = new URG_URGENCIA();
            try
            {
                retorno = _dbSisParEntities.URG_URGENCIA.Single(req => idUrgencia.Equals(req.URG_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza una Urgencia
        /// </summary>
        /// <param name="urgencia">Datos de la Urgencia</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarUrgencia(URG_URGENCIA urgencia)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.URG_URGENCIA.Attach(urgencia);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(urgencia, EntityState.Modified);
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
        /// Método que elimina una Urgencia
        /// </summary>
        /// <param name="urgencia">Datos de la Urgencia</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarUrgencia(URG_URGENCIA urgencia)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.URG_URGENCIA.DeleteObject(urgencia);
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
