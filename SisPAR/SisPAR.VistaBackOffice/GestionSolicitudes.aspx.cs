namespace SisPAR.VistaBackOffice
{
    using System;
    using System.Data;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Web.UI.WebControls;
    using Negocio;

    /// <summary>
    /// Clase principal de Gestión de Solicitudes
    /// </summary>
    public partial class GestionSolicitudes : System.Web.UI.Page
    {
        /// <summary>
        /// Método que se ejecuta al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-ES");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            tbConsultasFechaDesde.Attributes.Add("readonly", "readonly");
            tbConsultasFechaHasta.Attributes.Add("readonly", "readonly");

            var itemSeleccionar = new ListItem("Seleccionar", "0");

            if (!IsPostBack)
            {
                #region Tab Solicitud

                LimpiarSolicitud();
                var responsables = new ResponsablesBo().ObtenerResponsables();
                var ddlResp = from resp in responsables
                              orderby resp.RES_ID
                              select new { resp.RES_ID, resp.USU_USUARIO.USU_NOMBRE };
                ddlSolicitudAsignado.DataSource = ddlResp;
                ddlSolicitudAsignado.DataTextField = "USU_NOMBRE";
                ddlSolicitudAsignado.DataValueField = "RES_ID";
                ddlSolicitudAsignado.DataBind();
                ddlSolicitudAsignado.Items.Insert(0, itemSeleccionar);

                var urgencias = new UrgenciasBo().ObtenerUrgencias();
                ddlSolicitudImpacto.DataSource = urgencias;
                ddlSolicitudImpacto.DataTextField = "URG_TIPO";
                ddlSolicitudImpacto.DataValueField = "URG_ID";
                ddlSolicitudImpacto.DataBind();
                ddlSolicitudImpacto.Items.Insert(0, itemSeleccionar);

                ddlSolicitudResponsable.DataSource = responsables;
                ddlSolicitudResponsable.DataTextField = "USU_NOMBRE";
                ddlSolicitudResponsable.DataValueField = "RES_ID";
                ddlSolicitudResponsable.DataBind();
                ddlSolicitudResponsable.Items.Insert(0, itemSeleccionar);

                var estados = new EstadosBo().ObtenerEstados();
                ddlSolicitudEstado.DataSource = estados;
                ddlSolicitudEstado.DataTextField = "EST_TIPO";
                ddlSolicitudEstado.DataValueField = "EST_ID";
                ddlSolicitudEstado.DataBind();
                ddlSolicitudEstado.Items.Insert(0, itemSeleccionar);

                var tipos = new ProcesosBo().ObtenerProcesos();
                ddlSolicitudTipo.DataSource = tipos;
                ddlSolicitudTipo.DataTextField = "PRO_NOMBRE";
                ddlSolicitudTipo.DataValueField = "PRO_ID";
                ddlSolicitudTipo.DataBind();
                ddlSolicitudTipo.Items.Insert(0, itemSeleccionar);

                var subtipos = new SubprocesosBo().ObtenerSubprocesos();
                ddlSolicitudSubtipo.DataSource = subtipos;
                ddlSolicitudSubtipo.DataTextField = "SPO_NOMBRE";
                ddlSolicitudSubtipo.DataValueField = "SPO_ID";
                ddlSolicitudSubtipo.DataBind();
                ddlSolicitudSubtipo.Items.Insert(0, itemSeleccionar);

                #endregion

                #region Tab Evento

                LimpiarEvento();

                #endregion

                #region Tab Consultas

                LimpiarConsultas();

                var itemTodos = new ListItem("Todos", "0");
                var empresas = new EmpresasBo().ObtenerEmpresas();
                ddlConsultasEmpresa.DataSource = empresas;
                ddlConsultasEmpresa.DataTextField = "EPR_RAZONSOCIAL";
                ddlConsultasEmpresa.DataValueField = "EPR_ID";
                ddlConsultasEmpresa.DataBind();
                ddlConsultasEmpresa.Items.Insert(0, new ListItem("Todas", "0"));

                ddlConsultasResponsables.DataSource = responsables;
                ddlConsultasResponsables.DataTextField = "USU_NOMBRE";
                ddlConsultasResponsables.DataValueField = "RES_ID";
                ddlConsultasResponsables.DataBind();
                ddlConsultasResponsables.Items.Insert(0, itemTodos);
                
                ddlConsultasProceso.DataSource = tipos;
                ddlConsultasProceso.DataTextField = "PRO_NOMBRE";
                ddlConsultasProceso.DataValueField = "PRO_ID";
                ddlConsultasProceso.DataBind();
                ddlConsultasProceso.Items.Insert(0, itemTodos);

                ddlConsultasSubproceso.DataSource = subtipos;
                ddlConsultasSubproceso.DataTextField = "SPO_NOMBRE";
                ddlConsultasSubproceso.DataValueField = "SPO_ID";
                ddlConsultasSubproceso.DataBind();
                ddlConsultasSubproceso.Items.Insert(0, itemTodos);

                tbConsultasFechaDesde.Text = "01/01/2014";
                tbConsultasFechaHasta.Text = DateTime.Today.ToShortDateString();

                #endregion
            }

            CargarTest();
        }

        /// <summary>
        /// Método que muestra la tabla Solicitud
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void TabSolicitud(object sender, EventArgs e)
        {
            tblSolicitud.Visible = true;
            tblEvento.Visible = false;
            tblConsultas.Visible = false;

            btnSolicitud.Enabled = false;
            btnSolicitud.CssClass = "tablaTabs tablaTabsInactivo";
            btnEvento.Enabled = true;
            btnEvento.CssClass = "tablaTabs tablaTabsActivo";
            btnConsultas.Enabled = true;
            btnConsultas.CssClass = "tablaTabs tablaTabsActivo";
        }

        /// <summary>
        /// Método que muestra la tabla Eventos
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void TabEvento(object sender, EventArgs e)
        {
            tblSolicitud.Visible = false;
            tblEvento.Visible = true;
            tblConsultas.Visible = false;

            btnSolicitud.Enabled = true;
            btnSolicitud.CssClass = "tablaTabs tablaTabsActivo";
            btnEvento.Enabled = false;
            btnEvento.CssClass = "tablaTabs tablaTabsInactivo";
            btnConsultas.Enabled = true;
            btnConsultas.CssClass = "tablaTabs tablaTabsActivo";
        }

        /// <summary>
        /// Método que muestra la tabla Consultas
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void TabConsultas(object sender, EventArgs e)
        {
            tblSolicitud.Visible = false;
            tblEvento.Visible = false;
            tblConsultas.Visible = true;

            btnSolicitud.Enabled = true;
            btnSolicitud.CssClass = "tablaTabs tablaTabsActivo";
            btnEvento.Enabled = true;
            btnEvento.CssClass = "tablaTabs tablaTabsActivo";
            btnConsultas.Enabled = false;
            btnConsultas.CssClass = "tablaTabs tablaTabsInactivo";
        }

        /// <summary>
        /// Método que habilita la Creación de Eventos
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void CrearEvento(object sender, EventArgs e)
        {
            tbrBotonesEventos.Enabled = false;
            tbrGrillaEventos.Enabled = false;
            LimpiarCrearEvento(null, null);
            tbcCrearEvento.Visible = true;
        }

        /// <summary>
        /// Método que almacena un Evento
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void GuardarEvento(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método que resetea los controles de la Creación de Eventos
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void LimpiarCrearEvento(object sender, EventArgs e)
        {
            ddlEventoRequerimiento.SelectedIndex = -1;
            ddlEventoEstado.Text = string.Empty;
            tbEventoNombreResponsable.Text = string.Empty;
            tbEventoDescripcion.Text = string.Empty;
            tbEventoFecha.Text = string.Empty;
        }

        /// <summary>
        /// Método que habilita la Creación de Eventos
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void CancelarEvento(object sender, EventArgs e)
        {
            tbcCrearEvento.Visible = false;
            LimpiarCrearEvento(null, null);
            tbrBotonesEventos.Enabled = true;
            tbrGrillaEventos.Enabled = true;
        }

        /// <summary>
        /// Método que limpia los campos de la pestaña Solicitud
        /// </summary>
        private void LimpiarSolicitud()
        {
            tbSolicitudSistema.Text = string.Empty;
            tbSolicitudFechaIngreso.Text = string.Empty;
            tbSolicitudModulo.Text = string.Empty;
            tbSolicitudFechaCierre.Text = string.Empty;
            tbSolicitudId.Text = string.Empty;
            tbSolicitudImpacto.Text = string.Empty;
            tbSolicitudSolicitante.Text = string.Empty;

            tbSolicitudGlosaUsuario.Text = string.Empty;
            tbSolicitudGlosaTecnica.Text = string.Empty;

            ddlSolicitudAsignado.SelectedIndex = -1;
            ddlSolicitudImpacto.SelectedIndex = -1;
            ddlSolicitudResponsable.SelectedIndex = -1;
            ddlSolicitudEstado.SelectedIndex = -1;
            ddlSolicitudTipo.SelectedIndex = -1;
            ddlSolicitudSubtipo.SelectedIndex = -1;
        }

        /// <summary>
        /// Método que limpia los campos de la pestaña Evento
        /// </summary>
        private void LimpiarEvento()
        {
            LimpiarCrearEvento(null, null);
            CancelarEvento(null, null);
        }

        /// <summary>
        /// Método que limpia los campos de la pestaña Consultas
        /// </summary>
        private void LimpiarConsultas()
        {
            ddlConsultasEmpresa.SelectedIndex = -1;
            ddlConsultasResponsables.SelectedIndex = -1;
            ddlConsultasProceso.SelectedIndex = -1;
            ddlConsultasSubproceso.SelectedIndex = -1;
            tbConsultasFechaDesde.Text = string.Empty;
            tbConsultasFechaHasta.Text = string.Empty;
        }

        private void CargarTest()
        {
            var dataTest = new DataTable("Tabla Test");
            dataTest.Columns.Add("Sistema");
            dataTest.Columns.Add("Responsable");
            dataTest.Columns.Add("Pendientes");
            dataTest.Columns.Add("NoAsignadas");

            dataTest.Rows.Add("SisQ", "Omar Carmona", 2, 0);

            gvEventos.DataSource = dataTest;
            gvEventos.DataBind();
            gvConsultas.DataSource = dataTest;
            gvConsultas.DataBind();
        }
    }
}