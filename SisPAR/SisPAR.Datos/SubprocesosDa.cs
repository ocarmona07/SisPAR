namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Subprocesos
    /// </summary>
    public class SubprocesosDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        public SubprocesosDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea un Subproceso
        /// </summary>
        /// <param name="subproceso">Datos del Subproceso</param>
        /// <returns>Id de confirmación</returns>
        public int CrearSubproceso(SPO_SUBPROCESO subproceso)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.SPO_SUBPROCESO.AddObject(subproceso);
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
        /// Método que obtiene todos los Subprocesos
        /// </summary>
        /// <returns>Lista de Subprocesos</returns>
        public List<SPO_SUBPROCESO> ObtenerSubprocesos()
        {
            var listaRetorno = new List<SPO_SUBPROCESO>();
            try
            {
                listaRetorno = _dbSisParEntities.SPO_SUBPROCESO.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene un Subproceso por su Id
        /// </summary>
        /// <param name="idSubproceso">ID del Subproceso</param>
        /// <returns>Subproceso</returns>
        public SPO_SUBPROCESO ObtenerSubproceso(int idSubproceso)
        {
            var retorno = new SPO_SUBPROCESO();
            try
            {
                retorno = _dbSisParEntities.SPO_SUBPROCESO.Single(req => idSubproceso.Equals(req.SPO_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Subproceso
        /// </summary>
        /// <param name="subproceso">Datos del Subproceso</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarSubproceso(SPO_SUBPROCESO subproceso)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.SPO_SUBPROCESO.Attach(subproceso);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(subproceso, EntityState.Modified);
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
        /// Método que elimina un Subproceso
        /// </summary>
        /// <param name="idSubproceso">Id del Subproceso</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarSubproceso(int idSubproceso)
        {
            var idRetorno = -1;
            try
            {
                object deletedObject;
                _dbSisParEntities.TryGetObjectByKey(new EntityKey("SisPAREntities.SPO_SUBPROCESO", "SPO_ID", idSubproceso), out deletedObject);
                _dbSisParEntities.DeleteObject(deletedObject);
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
