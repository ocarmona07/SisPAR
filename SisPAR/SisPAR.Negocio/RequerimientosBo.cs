namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Requerimientos
    /// </summary>
    public class RequerimientosBo
    {
        /// <summary>
        /// Instancia de la clase Requerimientos
        /// </summary>
        private readonly RequerimientosDa _requerimientosDa = new RequerimientosDa();

        /// <summary>
        /// Método que crea Requerimientos
        /// </summary>
        /// <param name="requerimientos">Datos de requerimientos</param>
        /// <returns>Id de requerimientos</returns>
        public int CrearRequerimiento(REQ_REQUERIMIENTO requerimientos)
        {
            return _requerimientosDa.CrearRequerimiento(requerimientos);
        }
        
        /// <summary>
        /// Método que obtiene los Requerimientos
        /// </summary>
        /// <returns></returns>
        public List<REQ_REQUERIMIENTO> ObtenerRequerimientos()
        {
            return _requerimientosDa.ObtenerRequerimientos();
        }

        /// <summary>
        /// Método que obtiene Requerimientos
        /// </summary>
        /// <param name="idRequerimientos">Id de Requerimientos</param>
        /// <returns>Requerimientos</returns>
        public REQ_REQUERIMIENTO ObtenerRequerimiento(int idRequerimientos)
        {
            return _requerimientosDa.ObtenerRequerimiento(idRequerimientos);
        }

        /// <summary>
        /// Método que actualiza un Requerimientos
        /// </summary>
        /// <param name="requerimientos">Datos de Requerimientos</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarRequerimiento(REQ_REQUERIMIENTO requerimientos)
        {
            return _requerimientosDa.ActualizarRequerimiento(requerimientos);
        }

        /// <summary>
        /// Método que elimina Requerimientos
        /// </summary>
        /// <param name="idRequerimiento">Id de Requerimiento</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarRequerimiento(int idRequerimiento)
        {
            return _requerimientosDa.EliminarRequerimiento(idRequerimiento);
        }
    }
}
