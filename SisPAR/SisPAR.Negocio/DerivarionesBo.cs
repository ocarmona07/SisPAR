namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Derivaciones
    /// </summary>
    public class DerivarionesBo
    {
        /// <summary>
        /// Instancia de la clase DerivacionesDa
        /// </summary>
        private readonly DerivacionesDa _derivacionesDa = new DerivacionesDa();

        /// <summary>
        /// Método que crea una Derivación
        /// </summary>
        /// <param name="derivacion">Datos de la derivación</param>
        /// <returns>Id de confirmación</returns>
        public int CrearDerivacion(DER_DERIVACION derivacion)
        {
            return _derivacionesDa.CrearDerivacion(derivacion);
        }

        /// <summary>
        /// Método que obtiene todas las Derivaciones
        /// </summary>
        /// <returns></returns>
        public List<DER_DERIVACION> ObtenerDerivaciones()
        {
            return _derivacionesDa.ObtenerDerivaciones();
        }

        /// <summary>
        /// Método que obtiene una Derivación
        /// </summary>
        /// <param name="idDerivacion">Id de Derivación</param>
        /// <returns>Derivación</returns>
        public DER_DERIVACION ObtenerDerivacion(int idDerivacion)
        {
            return _derivacionesDa.ObtenerDerivacion(idDerivacion);
        }

        /// <summary>
        /// Método que actualiza una derivación
        /// </summary>
        /// <param name="derivacion">Datos de la Derivación</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarDerivacion(DER_DERIVACION derivacion)
        {
            return _derivacionesDa.ActualizarDerivacion(derivacion);
        }

        /// <summary>
        /// Método que elimina una Derivación
        /// </summary>
        /// <param name="derivacion">Datos de la Derivación</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarDerivacion(DER_DERIVACION derivacion)
        {
            return _derivacionesDa.EliminarDerivacion(derivacion);
        }
    }
}
