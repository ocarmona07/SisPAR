namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Responsables
    /// </summary>
    public class ResponsablesDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        public ResponsablesDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea un Responsable
        /// </summary>
        /// <param name="resonsable">Datos del Responsable</param>
        /// <returns>Id de confirmación</returns>
        public int CrearResponsable(RES_RESPONSABLE resonsable)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.RES_RESPONSABLE.AddObject(resonsable);
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
        /// Método que obtiene todos los Responsables
        /// </summary>
        /// <returns>Lista de Responsables</returns>
        public List<RES_RESPONSABLE> ObtenerResponsables()
        {
            var listaRetorno = new List<RES_RESPONSABLE>();
            try
            {
                listaRetorno = _dbSisParEntities.RES_RESPONSABLE.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene un Responsable por su Id
        /// </summary>
        /// <param name="idResponsable">ID del Responsable</param>
        /// <returns>Responsable</returns>
        public RES_RESPONSABLE ObtenerResponsable(int idResponsable)
        {
            var retorno = new RES_RESPONSABLE();
            try
            {
                retorno = _dbSisParEntities.RES_RESPONSABLE.Single(req => idResponsable.Equals(req.RES_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Responsable
        /// </summary>
        /// <param name="resonsable">Datos del Responsable</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarResponsable(RES_RESPONSABLE resonsable)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.RES_RESPONSABLE.Attach(resonsable);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(resonsable, EntityState.Modified);
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
        /// Método que elimina un Responsable
        /// </summary>
        /// <param name="resonsable">Datos del Responsable</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarResponsable(RES_RESPONSABLE resonsable)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.RES_RESPONSABLE.DeleteObject(resonsable);
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
