namespace SisPAR.VistaBackOffice
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

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
            CargarEventos();
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
            //tblConsultas.Visible = false;

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
            //tblConsultas.Visible = false;

            btnSolicitud.Enabled = true;
            btnSolicitud.CssClass = "tablaTabs tablaTabsActivo";
            btnEvento.Enabled = false;
            btnEvento.CssClass = "tablaTabs tablaTabsInactivo";
            btnConsultas.Enabled = true;
            btnConsultas.CssClass = "tablaTabs tablaTabsActivo";
        }

        private void CargarEventos()
        {
            var dataTest = new DataTable("Tabla Test");
            dataTest.Columns.Add("Sistema");
            dataTest.Columns.Add("Responsable");
            dataTest.Columns.Add("Pendientes");
            dataTest.Columns.Add("NoAsignadas");

            dataTest.Rows.Add("SisQ", "Omar Carmona", 2, 0);

            gvEventos.DataSource = dataTest;
            gvEventos.DataBind();
        }
    }
}