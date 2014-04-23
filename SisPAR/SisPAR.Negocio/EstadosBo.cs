namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Empresas
    /// </summary>
    public class EstadosBo
    {
        /// <summary>
        /// Instancia de la clase EstadosDa
        /// </summary>
        private readonly EstadosDa _estadosDa = new EstadosDa();

        /// <summary>
        /// Método que crea una Estado
        /// </summary>
        /// <param name="estado">Datos del Estado</param>
        /// <returns>Id de confirmación</returns>
        public int CrearEstado(EST_ESTADOS estado)
        {
            return _estadosDa.CrearEstado(estado);
        }

        /// <summary>
        /// Método que obtiene todos los Estados
        /// </summary>
        /// <returns>Lista de Estados</returns>
        public List<EST_ESTADOS> ObtenerEstados()
        {
            return _estadosDa.ObtenerEstados();
        }

        /// <summary>
        /// Método que obtiene un Estado
        /// </summary>
        /// <param name="idEstado">Id de Estado</param>
        /// <returns>Estado</returns>
        public EST_ESTADOS ObtenerEstado(int idEstado)
        {
            return _estadosDa.ObtenerEstado(idEstado);
        }

        /// <summary>
        /// Método que actualiza un Estado
        /// </summary>
        /// <param name="estado">Datos del Estado</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEstado(EST_ESTADOS estado)
        {
            return _estadosDa.ActualizarEstado(estado);
        }

        /// <summary>
        /// Método que elimina un Estado
        /// </summary>
        /// <param name="estado">Datos del Estado</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEstado(EST_ESTADOS estado)
        {
            return _estadosDa.EliminarEstado(estado);
        }
    }
}
