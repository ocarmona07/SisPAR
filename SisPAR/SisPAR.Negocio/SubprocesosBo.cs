namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Subprocesos
    /// </summary>
    public class SubprocesosBo
    {
        /// <summary>
        /// Instancia de la clase Subprocesos
        /// </summary>
        private readonly SubprocesosDa _subprocesosDa = new SubprocesosDa();

        /// <summary>
        /// Método que crea Subprocesos
        /// </summary>
        /// <param name="subprocesos">Datos de subprocesos</param>
        /// <returns>Id de subprocesos</returns>
        public int CrearSubproceso(SPO_SUBPROCESO subprocesos)
        {
            return _subprocesosDa.CrearSubproceso(subprocesos);
        }
        
        /// <summary>
        /// Método que obtiene los Subprocesos
        /// </summary>
        /// <returns></returns>
        public List<SPO_SUBPROCESO> ObtenerSubprocesos()
        {
            return _subprocesosDa.ObtenerSubprocesos();
        }

        /// <summary>
        /// Método que obtiene Subprocesos
        /// </summary>
        /// <param name="idSubprocesos">Id de Subprocesos</param>
        /// <returns>Roles</returns>
        public SPO_SUBPROCESO ObtenerSubproceso(int idSubprocesos)
        {
            return _subprocesosDa.ObtenerSubproceso(idSubprocesos);
        }

        /// <summary>
        /// Método que actualiza Subprocesos
        /// </summary>
        /// <param name="subprocesos">Datos de Subprocesos</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarSubproceso(SPO_SUBPROCESO subprocesos)
        {
            return _subprocesosDa.ActualizarSubproceso(subprocesos);
        }

        /// <summary>
        /// Método que elimina Subprocesos
        /// </summary>
        /// <param name="subprocesos">Datos de Subprocesos</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarSubproceso(SPO_SUBPROCESO subprocesos)
        {
            return _subprocesosDa.EliminarSubproceso(subprocesos);
        }
    }
}
