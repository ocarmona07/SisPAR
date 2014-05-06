namespace SisPAR.Negocio
{
    using System.Collections.Generic;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase de Negocio Empresas
    /// </summary>
    public class EmpresasBo
    {
        /// <summary>
        /// Instancia de la clase EmpresasDa
        /// </summary>
        private readonly EmpresasDa _empresasDa = new EmpresasDa();

        /// <summary>
        /// Método que crea una Empresa
        /// </summary>
        /// <param name="empresas">Datos de la Empresa</param>
        /// <returns>Id de confirmación</returns>
        public int CrearEmpresa(EPR_EMPRESA empresas)
        {
            return _empresasDa.CrearEmpresa(empresas);
        }

        /// <summary>
        /// Método que obtiene todas las Empresas
        /// </summary>
        /// <returns>Lista de Empresas</returns>
        public List<EPR_EMPRESA> ObtenerEmpresas()
        {
            return _empresasDa.ObtenerEmpresas();
        }

        /// <summary>
        /// Método que obtiene una Empresa
        /// </summary>
        /// <param name="idEmpresa">Id de Empresa</param>
        /// <returns>Empresa</returns>
        public EPR_EMPRESA ObtenerEmpresa(int idEmpresa)
        {
            return _empresasDa.ObtenerEmpresa(idEmpresa);
        }

        /// <summary>
        /// Método que actualiza una Empresa
        /// </summary>
        /// <param name="empresa">Datos de la Empresa</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEmpresa(EPR_EMPRESA empresa)
        {
            return _empresasDa.ActualizarEmpresa(empresa);
        }

        /// <summary>
        /// Método que elimina una Empresas
        /// </summary>
        /// <param name="idEmpresa">Id de la Empresa</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEmpresa(int idEmpresa)
        {
            return _empresasDa.EliminarEmpresa(idEmpresa);
        }
    }
}
