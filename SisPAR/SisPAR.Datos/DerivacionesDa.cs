namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Derivaciones
    /// </summary>
    public class DerivacionesDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        public DerivacionesDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea una Derivación
        /// </summary>
        /// <param name="derivacion">Datos de la Derivación</param>
        /// <returns>Id de confirmación</returns>
        public int CrearDerivacion(DER_DERIVACION derivacion)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.DER_DERIVACION.AddObject(derivacion);
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
        /// Método que obtiene todas las Derivaciones
        /// </summary>
        /// <returns>Lista de Derivaciones</returns>
        public List<DER_DERIVACION> ObtenerDerivaciones()
        {
            var listaRetorno = new List<DER_DERIVACION>();
            try
            {
                listaRetorno = _dbSisParEntities.DER_DERIVACION.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene una Derivación por su Id
        /// </summary>
        /// <param name="idDerivacion">ID de la Derivación</param>
        /// <returns>Derivación</returns>
        public DER_DERIVACION ObtenerDerivacion(int idDerivacion)
        {
            var retorno = new DER_DERIVACION();
            try
            {
                retorno = _dbSisParEntities.DER_DERIVACION.Single(req => idDerivacion.Equals(req.DER_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza una Derivación
        /// </summary>
        /// <param name="derivacion">Datos de la Derivación</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarDerivacion(DER_DERIVACION derivacion)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.DER_DERIVACION.Attach(derivacion);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(derivacion, EntityState.Modified);
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
        /// Método que elimina una Derivación
        /// </summary>
        /// <param name="idDerivacion">Id de la Derivación</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarDerivacion(int idDerivacion)
        {
            var idRetorno = -1;
            try
            {
                object deletedObject;
                _dbSisParEntities.TryGetObjectByKey(new EntityKey("SisPAREntities.DER_DERIVACION", "DER_ID", idDerivacion), out deletedObject);
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
