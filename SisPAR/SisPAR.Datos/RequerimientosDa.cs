namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Requerimientos
    /// </summary>
    public class RequerimientosDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        public RequerimientosDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea un Requerimiento
        /// </summary>
        /// <param name="requerimiento">Datos del Requerimiento</param>
        /// <returns>Id de confirmación</returns>
        public int CrearRequerimiento(REQ_REQUERIMIENTO requerimiento)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.REQ_REQUERIMIENTO.AddObject(requerimiento);
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
        /// Método que obtiene todos los Requerimientos
        /// </summary>
        /// <returns>Lista de Requerimientos</returns>
        public List<REQ_REQUERIMIENTO> ObtenerRequerimientos()
        {
            var listaRetorno = new List<REQ_REQUERIMIENTO>();
            try
            {
                listaRetorno = _dbSisParEntities.REQ_REQUERIMIENTO.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene un requerimiento por su Id
        /// </summary>
        /// <param name="idRequerimiento">ID del requerimiento</param>
        /// <returns>Requerimiento</returns>
        public REQ_REQUERIMIENTO ObtenerRequerimiento(int idRequerimiento)
        {
            var retorno = new REQ_REQUERIMIENTO();
            try
            {
                retorno = _dbSisParEntities.REQ_REQUERIMIENTO.Single(req => idRequerimiento.Equals(req.REQ_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Requerimiento
        /// </summary>
        /// <param name="requerimiento">Datos del Requerimiento</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarRequerimiento(REQ_REQUERIMIENTO requerimiento)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.REQ_REQUERIMIENTO.Attach(requerimiento);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(requerimiento, EntityState.Modified);
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
        /// Método que elimina un Requerimiento
        /// </summary>
        /// <param name="requerimiento">Datos del Requerimiento</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarRequerimiento(REQ_REQUERIMIENTO requerimiento)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.REQ_REQUERIMIENTO.DeleteObject(requerimiento);
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
