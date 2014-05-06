namespace SisPAR.VistaBackOffice
{
    #region Librerías

    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Entidades;
    using Negocio;

    #endregion

    /// <summary>
    /// Clase principal de Gestión de Solicitudes
    /// </summary>
    public partial class GestionSolicitudes : Page
    {
        #region Page Load

        /// <summary>
        /// Método que se ejecuta al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-ES");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            tbEventoFecha.Attributes.Add("readonly", "readonly");
            tbConsultasFechaDesde.Attributes.Add("readonly", "readonly");
            tbConsultasFechaHasta.Attributes.Add("readonly", "readonly");

            var itemSeleccionar = new ListItem("Seleccionar", "0");

            if (IsPostBack) return;

            #region Tab Solicitud

            LimpiarSolicitud();
            var responsables = new ResponsablesBo().ObtenerResponsables();
            ddlSolicitudAsignado.DataSource = responsables;
            ddlSolicitudAsignado.DataTextField = "RES_USU_ID";
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
            ddlSolicitudResponsable.DataTextField = "RES_USU_ID";
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
            var requerimientos = new RequerimientosBo().ObtenerRequerimientos();
            ddlEventoRequerimiento.DataSource = requerimientos;
            ddlEventoRequerimiento.DataTextField = "REQ_ID";
            ddlEventoRequerimiento.DataValueField = "REQ_ID";
            ddlEventoRequerimiento.DataBind();
            ddlEventoRequerimiento.Items.Insert(0, itemSeleccionar);

            ddlEventoEstado.DataSource = estados;
            ddlEventoEstado.DataTextField = "EST_TIPO";
            ddlEventoEstado.DataValueField = "EST_ID";
            ddlEventoEstado.DataBind();
            ddlEventoEstado.Items.Insert(0, itemSeleccionar);

            #endregion

            #region Tab Consultas

            LimpiarConsultas();

            var itemTodos = new ListItem("Todos", "0");

            ddlConsultasEstado.DataSource = estados;
            ddlConsultasEstado.DataTextField = "EST_TIPO";
            ddlConsultasEstado.DataValueField = "EST_ID";
            ddlConsultasEstado.DataBind();
            ddlConsultasEstado.Items.Insert(0, itemTodos);

            ddlConsultasResponsables.DataSource = responsables;
            ddlConsultasResponsables.DataTextField = "RES_USU_ID";
            ddlConsultasResponsables.DataValueField = "RES_ID";
            ddlConsultasResponsables.DataBind();
            ddlConsultasResponsables.Items.Insert(0, itemTodos);

            tbConsultasFechaDesde.Text = "01/01/2014";
            tbConsultasFechaHasta.Text = DateTime.Today.ToShortDateString();

            #endregion
        }

        #endregion

        #region Eventos

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

            gvConsultas.DataSource = new EventosBo().ObtenerEventos();
            gvConsultas.DataBind();
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
            tbEventoFecha.Text = DateTime.Today.ToShortDateString();
            tbcCrearEvento.Visible = true;
        }

        /// <summary>
        /// Método que almacena un Evento
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void GuardarEvento(object sender, EventArgs e)
        {
            var guardaEvento = new EVE_EVENTO
            {
                EVE_REQ_ID = int.Parse(ddlEventoRequerimiento.SelectedValue),
                EVE_EST_ID = int.Parse(ddlEventoEstado.SelectedValue),
                EVE_RESPONSABLE = tbEventoNombreResponsable.Text,
                EVE_DESCRIPCION = tbEventoDescripcion.Text,
                EVE_FECHA = DateTime.Parse(tbEventoFecha.Text)
            };
            var rutaAdjuntos = ConfigurationManager.AppSettings["NotificacionAdjunto"];
            string mensaje;

            if (string.IsNullOrEmpty(hdnIdEvento.Value))
            {
                if (!Directory.Exists(rutaAdjuntos)) Directory.CreateDirectory(rutaAdjuntos);

                guardaEvento.EVE_ADJUNTO = fupEventoAdjunto.FileName;
                if (new EventosBo().CrearEvento(guardaEvento) > 0)
                {
                    fupEventoAdjunto.SaveAs(rutaAdjuntos + fupEventoAdjunto.FileName);
                    mensaje = "Evento guardado correctamente";
                    LimpiarEvento();
                }
                else
                    mensaje = "Error al guardar el evento";
            }
            else
            {
                guardaEvento.EVE_ID = int.Parse(hdnIdEvento.Value);
                guardaEvento.EVE_ADJUNTO = fupEventoAdjunto.HasFile
                    ? fupEventoAdjunto.FileName
                    : ibEventoAdjunto.CommandArgument;
                if (new EventosBo().ActualizarEvento(guardaEvento) > 0)
                {
                    if (fupEventoAdjunto.HasFile) fupEventoAdjunto.SaveAs(rutaAdjuntos + fupEventoAdjunto.FileName);
                    mensaje = "Evento modificado correctamente";
                    LimpiarEvento();
                }
                else
                    mensaje = "Error al modificar el evento";
            }

            ScriptManager.RegisterStartupScript(this, typeof(Page), "MensajeGuardado",
                @"<script language='javascript' type='text/javascript'>alert('" + mensaje + "');</script>", false);

        }

        /// <summary>
        /// Método que resetea los controles de la Creación de Eventos
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void LimpiarCrearEvento(object sender, EventArgs e)
        {
            hdnIdEvento.Value = string.Empty;
            ddlEventoRequerimiento.SelectedIndex = -1;
            ddlEventoEstado.SelectedIndex = -1;
            ibEventoAdjunto.Visible = false;
            rfvAdjunto.Enabled = true;
            tbEventoNombreResponsable.Text = string.Empty;
            tbEventoDescripcion.Text = string.Empty;
            tbEventoFecha.Text = DateTime.Today.ToShortDateString();
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
            btnEventoCrear.Text = "Crear";
            tbrBotonesEventos.Enabled = true;
            tbrGrillaEventos.Enabled = true;
        }

        /// <summary>
        /// Método que obtiene las acciones a realizar con los datos de la grilla
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void EventosRowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Editar":
                    CrearEvento(null, null);
                    var editarEvento = new EventosBo().ObtenerEvento(int.Parse(e.CommandArgument.ToString()));
                    hdnIdEvento.Value = e.CommandArgument.ToString();
                    ddlEventoRequerimiento.SelectedValue = editarEvento.EVE_REQ_ID.ToString(CultureInfo.InvariantCulture);
                    ddlEventoEstado.SelectedValue = editarEvento.EVE_EST_ID.ToString(CultureInfo.InvariantCulture);
                    ibEventoAdjunto.CommandArgument = editarEvento.EVE_ADJUNTO;
                    ibEventoAdjunto.ToolTip = "Archivo adjunto: " + editarEvento.EVE_ADJUNTO;
                    ibEventoAdjunto.Visible = true;
                    rfvAdjunto.Enabled = false;
                    tbEventoNombreResponsable.Text = editarEvento.EVE_RESPONSABLE;
                    tbEventoDescripcion.Text = editarEvento.EVE_DESCRIPCION;
                    tbEventoFecha.Text = editarEvento.EVE_FECHA.ToShortDateString();
                    btnEventoCrear.Text = "Modificar";
                    break;

                case "Eliminar":
                    var mensaje = new EventosBo().EliminarEvento(int.Parse(e.CommandArgument.ToString())) > 0
                        ? "Evento eliminado correctamente"
                        : "Error al eliminar el evento";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "MensajeEliminar",
                        @"<script language='javascript' type='text/javascript'>alert('" + mensaje + "');</script>",
                        false);
                    gvEventos.DataSource = new EventosBo().ObtenerEventos();
                    gvEventos.DataBind();
                    break;

                case "Descargar":
                    var rutaArchivo =
                        new FileInfo(ConfigurationManager.AppSettings["NotificacionAdjunto"] + e.CommandArgument);
                    Response.Clear();
                    Response.AddHeader("Content-Disposition",
                        "attachment; filename=" + HttpUtility.UrlEncode(rutaArchivo.Name));
                    Response.AddHeader("Content-Length", rutaArchivo.Length.ToString(CultureInfo.InvariantCulture));
                    Response.ContentType = "application/octet-stream";
                    Response.WriteFile(rutaArchivo.FullName);
                    Response.End();
                    break;
            }
        }

        /// <summary>
        /// Método que descarga el archivo adjunto del evento
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void EventoAdjuntoOnClick(object sender, ImageClickEventArgs e)
        {
            var rutaArchivo =
                new FileInfo(ConfigurationManager.AppSettings["NotificacionAdjunto"] + ibEventoAdjunto.CommandArgument);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(rutaArchivo.Name));
            Response.AddHeader("Content-Length", rutaArchivo.Length.ToString(CultureInfo.InvariantCulture));
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(rutaArchivo.FullName);
            Response.End();
        }

        /// <summary>
        /// Método que se ejecuta al filtrar la lista de consultas
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void ConsultasFiltrarOnClick(object sender, EventArgs e)
        {
            var listaEventos = new EventosBo().ObtenerEventos();
            IEnumerable<EVE_EVENTO> listaFiltrada = listaEventos;

            if (ddlConsultasResponsables.SelectedValue != "0")
            {
                listaFiltrada = listaEventos.Where(eve => ddlConsultasResponsables.SelectedValue.Equals(eve.EVE_RESPONSABLE));
            }

            if (ddlConsultasEstado.SelectedValue != "0")
            {
                listaFiltrada = listaFiltrada.Where(eve => ddlConsultasEstado.SelectedValue.Equals(eve.EVE_EST_ID.ToString(CultureInfo.InvariantCulture)));
            }

            var fechaDesde = Convert.ToDateTime(tbConsultasFechaDesde.Text);
            var fechaHasta = Convert.ToDateTime(tbConsultasFechaHasta.Text);
            gvConsultas.DataSource = listaFiltrada.Where(eve => eve.EVE_FECHA >= fechaDesde && eve.EVE_FECHA <= fechaHasta).ToList();
            gvConsultas.DataBind();
        }

        #endregion

        #region Métodos

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
            gvEventos.DataSource = new EventosBo().ObtenerEventos();
            gvEventos.DataBind();
        }

        /// <summary>
        /// Método que limpia los campos de la pestaña Consultas
        /// </summary>
        private void LimpiarConsultas()
        {
            ddlConsultasEstado.SelectedIndex = -1;
            ddlConsultasResponsables.SelectedIndex = -1;
            tbConsultasFechaDesde.Text = string.Empty;
            tbConsultasFechaHasta.Text = string.Empty;
        }

        #endregion
    }
}