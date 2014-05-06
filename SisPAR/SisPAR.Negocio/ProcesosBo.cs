namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Procesos
    /// </summary>
    public class ProcesosBo
    {
        /// <summary>
        /// Instancia de la clase Procesos
        /// </summary>
        private readonly ProcesosDa _procesosDa = new ProcesosDa();

        /// <summary>
        /// Método que crea Procesos
        /// </summary>
        /// <param name="procesos">Datos de procesos</param>
        /// <returns>Id de procesos</returns>
        public int CrearProceso(PRO_PROCESO procesos)
        {
            return _procesosDa.CrearProceso(procesos);
        }
        
        /// <summary>
        /// Método que obtiene los Procesos
        /// </summary>
        /// <returns></returns>
        public List<PRO_PROCESO> ObtenerProcesos()
        {
            return _procesosDa.ObtenerProcesos();
        }

        /// <summary>
        /// Método que obtiene Procesos
        /// </summary>
        /// <param name="idProcesos">Id de Procesos</param>
        /// <returns>Procesos</returns>
        public PRO_PROCESO ObtenerProceso(int idProcesos)
        {
            return _procesosDa.ObtenerProceso(idProcesos);
        }

        /// <summary>
        /// Método que actualiza un Procesos
        /// </summary>
        /// <param name="procesos">Datos de Procesos</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarProceso(PRO_PROCESO procesos)
        {
            return _procesosDa.ActualizarProceso(procesos);
        }

        /// <summary>
        /// Método que elimina Procesos
        /// </summary>
        /// <param name="idProcesos">Id de Proceso</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarProceso(int idProcesos)
        {
            return _procesosDa.EliminarProceso(idProcesos);
        }
    }
}
