namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Historial de Requerimientos
    /// </summary>
    public class HistorialReqDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        private HistorialReqDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea Historial de Requerimientos
        /// </summary>
        /// <param name="historialReq">Datos del Historial</param>
        /// <returns>Id de confirmación</returns>
        public int CrearHistorialRequerimiento(HRE_HISTORIAL_REQUERIMIENTO historialReq)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.HRE_HISTORIAL_REQUERIMIENTO.AddObject(historialReq);
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
        /// Método que obtiene todos los Historiales de Requerimientos
        /// </summary>
        /// <returns>Lista de Historiales</returns>
        public List<HRE_HISTORIAL_REQUERIMIENTO> ObtenerHistorialesRequerimientos()
        {
            var listaRetorno = new List<HRE_HISTORIAL_REQUERIMIENTO>();
            try
            {
                listaRetorno = _dbSisParEntities.HRE_HISTORIAL_REQUERIMIENTO.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene un Historial de Requerimientos por su Id
        /// </summary>
        /// <param name="idHistorialReq">ID del Historial</param>
        /// <returns>Historial de Requerimientos</returns>
        public HRE_HISTORIAL_REQUERIMIENTO ObtenerHistorialRequerimiento(int idHistorialReq)
        {
            var retorno = new HRE_HISTORIAL_REQUERIMIENTO();
            try
            {
                retorno = _dbSisParEntities.HRE_HISTORIAL_REQUERIMIENTO.Single(req => idHistorialReq.Equals(req.HRE_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Historial de Requerimiento
        /// </summary>
        /// <param name="historialReq">Datos del Historial</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarHistorialRequerimiento(HRE_HISTORIAL_REQUERIMIENTO historialReq)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.HRE_HISTORIAL_REQUERIMIENTO.Attach(historialReq);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(historialReq, EntityState.Modified);
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
        /// Método que elimina un Historial de Requerimientos
        /// </summary>
        /// <param name="historialReq">Datos del Historial</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarHistorialRequerimientos(HRE_HISTORIAL_REQUERIMIENTO historialReq)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.HRE_HISTORIAL_REQUERIMIENTO.DeleteObject(historialReq);
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
