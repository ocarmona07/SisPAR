namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Estados
    /// </summary>
    public class EstadosDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        public EstadosDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea un Estado
        /// </summary>
        /// <param name="estado">Datos del Estado</param>
        /// <returns>Id de confirmación</returns>
        public int CrearEstado(EST_ESTADOS estado)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EST_ESTADOS.AddObject(estado);
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
        /// Método que obtiene todos los Estados
        /// </summary>
        /// <returns>Lista de Estados</returns>
        public List<EST_ESTADOS> ObtenerEstados()
        {
            var listaRetorno = new List<EST_ESTADOS>();
            try
            {
                listaRetorno = _dbSisParEntities.EST_ESTADOS.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene un Estado por su Id
        /// </summary>
        /// <param name="idEstado">ID del Estado</param>
        /// <returns>Estado</returns>
        public EST_ESTADOS ObtenerEstado(int idEstado)
        {
            var retorno = new EST_ESTADOS();
            try
            {
                retorno = _dbSisParEntities.EST_ESTADOS.Single(req => idEstado.Equals(req.EST_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza un Estado
        /// </summary>
        /// <param name="estado">Datos del Estado</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEstado(EST_ESTADOS estado)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EST_ESTADOS.Attach(estado);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(estado, EntityState.Modified);
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
        /// Método que elimina un Estado
        /// </summary>
        /// <param name="idEstado">Id del Estado</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEstado(int idEstado)
        {
            var idRetorno = -1;
            try
            {
                object deletedObject;
                _dbSisParEntities.TryGetObjectByKey(new EntityKey("SisPAREntities.EST_ESTADOS", "EST_ID", idEstado), out deletedObject);
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
