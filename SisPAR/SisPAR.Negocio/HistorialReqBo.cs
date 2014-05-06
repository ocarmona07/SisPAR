namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio HistorialReq
    /// </summary>
    public class HistorialReqBo
    {
        /// <summary>
        /// Instancia de la clase HistorialReqDa
        /// </summary>
        private readonly HistorialReqDa _historialReqDa = new HistorialReqDa();

        /// <summary>
        /// Método que crea un HistorialReq
        /// </summary>
        /// <param name="historialReq">Datos del historialReq</param>
        /// <returns>Id de historialReq</returns>
        public int CrearHistorialRequerimiento(HRE_HISTORIAL_REQUERIMIENTO historialReq)
        {
            return _historialReqDa.CrearHistorialRequerimiento(historialReq);
        }

        /// <summary>
        /// Método que obtiene los HistorialReq
        /// </summary>
        /// <returns></returns>
        public List<HRE_HISTORIAL_REQUERIMIENTO> ObtenerHistorialesRequerimientos()
        {
            return _historialReqDa.ObtenerHistorialesRequerimientos();
        }

        /// <summary>
        /// Método que obtiene un HistorialReq
        /// </summary>
        /// <param name="idHistorialReq">Id de HistorialReq</param>
        /// <returns>HistorialReq</returns>
        public HRE_HISTORIAL_REQUERIMIENTO ObtenerHistorialRequerimiento(int idHistorialReq)
        {
            return _historialReqDa.ObtenerHistorialRequerimiento(idHistorialReq);
        }

        /// <summary>
        /// Método que actualiza un HistorialReq
        /// </summary>
        /// <param name="historialReq">Datos del HistorialReq</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarHistorialRequerimiento(HRE_HISTORIAL_REQUERIMIENTO historialReq)
        {
            return _historialReqDa.ActualizarHistorialRequerimiento(historialReq);
        }

        /// <summary>
        /// Método que elimina un HistorialReq
        /// </summary>
        /// <param name="idHistorialReq">Datos del HistorialReq</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarHistorialRequerimientos(int idHistorialReq)
        {
            return _historialReqDa.EliminarHistorialRequerimientos(idHistorialReq);
        }
    }
}
