namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Evaluaciones
    /// </summary>
    public class EvaluacionesDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        private EvaluacionesDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea una Evaluación
        /// </summary>
        /// <param name="evaluacion">Datos de la Evaluación</param>
        /// <returns>Id de confirmación</returns>
        public int CrearEvaluacion(EVA_EVALUACION evaluacion)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EVA_EVALUACION.AddObject(evaluacion);
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
        /// Método que obtiene todas las Evaluaciones
        /// </summary>
        /// <returns>Lista de Evaluaciones</returns>
        public List<EVA_EVALUACION> ObtenerEvaluaciones()
        {
            var listaRetorno = new List<EVA_EVALUACION>();
            try
            {
                listaRetorno = _dbSisParEntities.EVA_EVALUACION.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene una Evaluación por su Id
        /// </summary>
        /// <param name="idEvaluacion">ID de la Evaluación</param>
        /// <returns>Evaluación</returns>
        public EVA_EVALUACION ObtenerEvaluacion(int idEvaluacion)
        {
            var retorno = new EVA_EVALUACION();
            try
            {
                retorno = _dbSisParEntities.EVA_EVALUACION.Single(req => idEvaluacion.Equals(req.EVA_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza una Evaluación
        /// </summary>
        /// <param name="evaluacion">Datos de la Evaluación</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEvaluacion(EVA_EVALUACION evaluacion)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EVA_EVALUACION.Attach(evaluacion);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(evaluacion, EntityState.Modified);
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
        /// Método que elimina una Evaluación
        /// </summary>
        /// <param name="evaluacion">Datos de la Evaluación</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEvaluacion(EVA_EVALUACION evaluacion)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EVA_EVALUACION.DeleteObject(evaluacion);
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
