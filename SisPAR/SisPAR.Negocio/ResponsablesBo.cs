namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Responsables
    /// </summary>
    public class ResponsablesBo
    {
        /// <summary>
        /// Instancia de la clase Responsables
        /// </summary>
        private readonly ResponsablesDa _responsablesDa = new ResponsablesDa();

        /// <summary>
        /// Método que crea Responsables
        /// </summary>
        /// <param name="responsables">Datos de responsables</param>
        /// <returns>Id de responsables</returns>
        public int CrearResponsable(RES_RESPONSABLE responsables)
        {
            return _responsablesDa.CrearResponsable(responsables);
        }
        
        /// <summary>
        /// Método que obtiene los Responsables
        /// </summary>
        /// <returns></returns>
        public List<RES_RESPONSABLE> ObtenerResponsables()
        {
            return _responsablesDa.ObtenerResponsables();
        }

        /// <summary>
        /// Método que obtiene Responsables
        /// </summary>
        /// <param name="idResponsables">Id de Responsables</param>
        /// <returns>Responsables</returns>
        public RES_RESPONSABLE ObtenerResponsable(int idResponsables)
        {
            return _responsablesDa.ObtenerResponsable(idResponsables);
        }

        /// <summary>
        /// Método que actualiza un Responsables
        /// </summary>
        /// <param name="responsables">Datos de Responsables</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarResponsable(RES_RESPONSABLE responsables)
        {
            return _responsablesDa.ActualizarResponsable(responsables);
        }

        /// <summary>
        /// Método que elimina Responsables
        /// </summary>
        /// <param name="responsables">Datos de Responsables</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarResponsable(RES_RESPONSABLE responsables)
        {
            return _responsablesDa.EliminarResponsable(responsables);
        }
    }
}
