namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Procesos
    /// </summary>
    public class ProcesosDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        private ProcesosDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea un Proceso
        /// </summary>
        /// <param name="proceso">Datos del Proceso</param>
        /// <returns>Id de confirmación</returns>
        public int CrearProceso(PRO_PROCESO proceso)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.PRO_PROCESO.AddObject(proceso);
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
        /// Método que obtiene todos los Procesos
        /// </summary>
        /// <returns>Lista de Procesos</returns>
        public List<PRO_PROCESO> ObtenerProcesos()
        {
            var listaRetorno = new List<PRO_PROCESO>();
            try
            {
                listaRetorno = _dbSisParEntities.PRO_PROCESO.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene un Proceso por su Id
        /// </summary>
        /// <param name="idProceso">ID del Proceso</param>
        /// <returns>Proceso</returns>
        public PRO_PROCESO ObtenerProceso(int idProceso)
        {
            var retorno = new PRO_PROCESO();
            try
            {
                retorno = _dbSisParEntities.PRO_PROCESO.Single(req => idProceso.Equals(req.PRO_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Proceso
        /// </summary>
        /// <param name="proceso">Datos del Proceso</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarProceso(PRO_PROCESO proceso)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.PRO_PROCESO.Attach(proceso);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(proceso, EntityState.Modified);
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
        /// Método que elimina un Proceso
        /// </summary>
        /// <param name="proceso">Datos del Proceso</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarProceso(PRO_PROCESO proceso)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.PRO_PROCESO.DeleteObject(proceso);
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
