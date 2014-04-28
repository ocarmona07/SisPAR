namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Preguntas
    /// </summary>
    public class PreguntasBo
    {
        /// <summary>
        /// Instancia de la clase Preguntas
        /// </summary>
        private readonly PreguntasDa _preguntasDa = new PreguntasDa();

        /// <summary>
        /// Método que crea Preguntas
        /// </summary>
        /// <param name="preguntas">Datos de preguntas</param>
        /// <returns>Id de preguntas</returns>
        public int CrearPregunta(PRE_PREGUNTA preguntas)
        {
            return _preguntasDa.CrearPregunta(preguntas);
        }
        
        /// <summary>
        /// Método que obtiene las Preguntas
        /// </summary>
        /// <returns></returns>
        public List<PRE_PREGUNTA> ObtenerPreguntas()
        {
            return _preguntasDa.ObtenerPreguntas();
        }

        /// <summary>
        /// Método que obtiene Preguntas
        /// </summary>
        /// <param name="idPreguntas">Id de Preguntas</param>
        /// <returns>Preguntas</returns>
        public PRE_PREGUNTA ObtenerPregunta(int idPreguntas)
        {
            return _preguntasDa.ObtenerPregunta(idPreguntas);
        }

        /// <summary>
        /// Método que actualiza un Preguntas
        /// </summary>
        /// <param name="preguntas">Datos de Preguntas</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarPregunta(PRE_PREGUNTA preguntas)
        {
            return _preguntasDa.ActualizarPregunta(preguntas);
        }

        /// <summary>
        /// Método que elimina Preguntas
        /// </summary>
        /// <param name="preguntas">Datos de Preguntas</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarPregunta(PRE_PREGUNTA preguntas)
        {
            return _preguntasDa.EliminarPregunta(preguntas);
        }
    }
}
