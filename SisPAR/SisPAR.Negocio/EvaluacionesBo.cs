namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Evaluaciones
    /// </summary>
    public class EvaluacionesBo
    {
        /// <summary>
        /// Instancia de la clase EvaluacionesDa
        /// </summary>
        private readonly EvaluacionesDa _evaluacionesDa = new EvaluacionesDa();

        /// <summary>
        /// Método que crea una Evaluación
        /// </summary>
        /// <param name="evaluacion">Datos de la evaluacion</param>
        /// <returns>Id de evaluacion</returns>
        public int CrearEvaluacion(EVA_EVALUACION evaluacion)
        {
            return _evaluacionesDa.CrearEvaluacion(evaluacion);
        }

        /// <summary>
        /// Método que obtiene todas las Evaluaciones
        /// </summary>
        /// <returns></returns>
        public List<EVA_EVALUACION> ObtenerEvaluaciones()
        {
            return _evaluacionesDa.ObtenerEvaluaciones();
        }

        /// <summary>
        /// Método que obtiene una Evaluacion
        /// </summary>
        /// <param name="idEvaluacion">Id de Evaluacion</param>
        /// <returns>Evaluacion</returns>
        public EVA_EVALUACION ObtenerEvaluacion(int idEvaluacion)
        {
            return _evaluacionesDa.ObtenerEvaluacion(idEvaluacion);
        }

        /// <summary>
        /// Método que actualiza una Evaluacion
        /// </summary>
        /// <param name="evaluacion">Datos de la Evaluacion</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEvaluacion(EVA_EVALUACION evaluacion)
        {
            return _evaluacionesDa.ActualizarEvaluacion(evaluacion);
        }

        /// <summary>
        /// Método que elimina una Evaluacion
        /// </summary>
        /// <param name="idEvaluacion">Id de la Evaluacion</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEvaluacion(int idEvaluacion)
        {
            return _evaluacionesDa.EliminarEvaluacion(idEvaluacion);
        }
    }
}
