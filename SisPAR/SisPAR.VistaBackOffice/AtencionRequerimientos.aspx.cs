namespace SisPAR.VistaBackOffice
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Clase principal de Atención de Requerimientos
    /// </summary>
    public partial class AtencionRequerimientos : System.Web.UI.Page
    {
        /// <summary>
        /// Método que se ejecuta al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            var dataTest = new DataTable("Tabla Test");
            dataTest.Columns.Add("Sistema");
            dataTest.Columns.Add("Responsable");
            dataTest.Columns.Add("Pendientes");
            dataTest.Columns.Add("NoAsignadas");

            dataTest.Rows.Add("SisQ", "Omar Carmona", 2, 0);

            gvRequerimientos.DataSource = dataTest;
            gvRequerimientos.DataBind();
        }
    }
}