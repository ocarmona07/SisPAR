namespace SisPAR.VistaBackOffice
{
    using System;
    using System.Data;

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