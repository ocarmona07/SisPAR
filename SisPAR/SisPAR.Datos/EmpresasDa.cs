namespace SisPAR.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos Empresas
    /// </summary>
    public class EmpresasDa
    {
        /// <summary>
        /// Entidades de SisPAR
        /// </summary>
        private readonly SisPAREntities _dbSisParEntities;

        /// <summary>
        /// Método que obtiene las entidades de SisPAR
        /// </summary>
        public EmpresasDa()
        {
            if (_dbSisParEntities == null)
            {
                _dbSisParEntities = new SisPAREntities();
            }
        }

        /// <summary>
        /// Método que crea una Empresa
        /// </summary>
        /// <param name="empresa">Datos de la Empresa</param>
        /// <returns>Id de confirmación</returns>
        public int CrearEmpresa(EPR_EMPRESA empresa)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EPR_EMPRESA.AddObject(empresa);
                idRetorno = _dbSisParEntities.SaveChanges();
                _dbSisParEntities.Dispose();
                return idRetorno;
            }
            catch (Exception)
            {
                return idRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene todas las Empresas
        /// </summary>
        /// <returns>Lista de Empresas</returns>
        public List<EPR_EMPRESA> ObtenerEmpresas()
        {
            var listaRetorno = new List<EPR_EMPRESA>();
            try
            {
                listaRetorno = _dbSisParEntities.EPR_EMPRESA.ToList();
                _dbSisParEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return listaRetorno;
            }
        }

        /// <summary>
        /// Método que obtiene una Empresa por su Id
        /// </summary>
        /// <param name="idEmpresa">ID de la Empresa</param>
        /// <returns>Empresa</returns>
        public EPR_EMPRESA ObtenerEmpresa(int idEmpresa)
        {
            var retorno = new EPR_EMPRESA();
            try
            {
                retorno = _dbSisParEntities.EPR_EMPRESA.Single(req => idEmpresa.Equals(req.EPR_ID));
                _dbSisParEntities.Dispose();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        /// <summary>
        /// Método que actualiza una Empresa
        /// </summary>
        /// <param name="empresa">Datos de la Empresa</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEmpresa(EPR_EMPRESA empresa)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EPR_EMPRESA.Attach(empresa);
                _dbSisParEntities.ObjectStateManager.ChangeObjectState(empresa, EntityState.Modified);
                idRetorno = _dbSisParEntities.SaveChanges();
                _dbSisParEntities.Dispose();
                return idRetorno;
            }
            catch (Exception)
            {
                return idRetorno;
            }
        }

        /// <summary>
        /// Método que elimina una Empresa
        /// </summary>
        /// <param name="empresa">Datos de la Empresa</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEmpresa(EPR_EMPRESA empresa)
        {
            var idRetorno = -1;
            try
            {
                _dbSisParEntities.EPR_EMPRESA.DeleteObject(empresa);
                idRetorno = _dbSisParEntities.SaveChanges();
                _dbSisParEntities.Dispose();
                return idRetorno;
            }
            catch (Exception)
            {
                return idRetorno;
            }
        }
    }
}
