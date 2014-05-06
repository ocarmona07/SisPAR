namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Urgencias
    /// </summary>
    public class UrgenciasBo
    {
        /// <summary>
        /// Instancia de la clase Urgencias
        /// </summary>
        private readonly UrgenciasDa _urgenciasDa = new UrgenciasDa();

        /// <summary>
        /// Método que crea Urgencias
        /// </summary>
        /// <param name="urgencias">Datos de urgencias</param>
        /// <returns>Id de urgencias</returns>
        public int CrearUrgencia(URG_URGENCIA urgencias)
        {
            return _urgenciasDa.CrearUrgencia(urgencias);
        }
        
        /// <summary>
        /// Método que obtiene los Urgencias
        /// </summary>
        /// <returns></returns>
        public List<URG_URGENCIA> ObtenerUrgencias()
        {
            return _urgenciasDa.ObtenerUrgencias();
        }

        /// <summary>
        /// Método que obtiene Urgencias
        /// </summary>
        /// <param name="idUrgencias">Id de Urgencias</param>
        /// <returns>Urgencias</returns>
        public URG_URGENCIA ObtenerUrgencia(int idUrgencias)
        {
            return _urgenciasDa.ObtenerUrgencia(idUrgencias);
        }

        /// <summary>
        /// Método que actualiza Urgencias
        /// </summary>
        /// <param name="urgencias">Datos de Urgencias</param>
        /// <returns>Id de urgencias</returns>
        public int ActualizarUrgencia(URG_URGENCIA urgencias)
        {
            return _urgenciasDa.ActualizarUrgencia(urgencias);
        }

        /// <summary>
        /// Método que elimina Urgencias
        /// </summary>
        /// <param name="idUrgencia">Id de Urgencia</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarUrgencia(int idUrgencia)
        {
            return _urgenciasDa.EliminarUrgencia(idUrgencia);
        }
    }
}
