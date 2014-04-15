namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Preguntas
    /// </summary>
    public class PreguntasDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        private PreguntasDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea una Pregunta
        /// </summary>
        /// <param name="pregunta">Datos de la Pregunta</param>
        /// <returns>Id de confirmación</returns>
        public int CrearPregunta(PRE_PREGUNTA pregunta)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.PRE_PREGUNTA.AddObject(pregunta);
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
        /// Método que obtiene todas las Preguntas
        /// </summary>
        /// <returns>Lista de Preguntas</returns>
        public List<PRE_PREGUNTA> ObtenerPreguntas()
        {
            var listaRetorno = new List<PRE_PREGUNTA>();
            try
            {
                listaRetorno = _dbSisParEntities.PRE_PREGUNTA.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene una Pregunta por su Id
        /// </summary>
        /// <param name="idPregunta">ID de la Pregunta</param>
        /// <returns>Pregunta</returns>
        public PRE_PREGUNTA ObtenerPregunta(int idPregunta)
        {
            var retorno = new PRE_PREGUNTA();
            try
            {
                retorno = _dbSisParEntities.PRE_PREGUNTA.Single(req => idPregunta.Equals(req.PRE_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza una Pregunta
        /// </summary>
        /// <param name="pregunta">Datos de la Pregunta</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarPregunta(PRE_PREGUNTA pregunta)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.PRE_PREGUNTA.Attach(pregunta);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(pregunta, EntityState.Modified);
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
        /// Método que elimina una Pregunta
        /// </summary>
        /// <param name="pregunta">Datos de la Pregunta</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarPregunta(PRE_PREGUNTA pregunta)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.PRE_PREGUNTA.DeleteObject(pregunta);
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
