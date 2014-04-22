namespace SisPAR.VistaBackOffice
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Clase principal de Inicio
    /// </summary>
    public partial class Home : System.Web.UI.Page
    {
        /// <summary>
        /// Método que se ejecuta al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCopyright.Text = ConfigurationManager.AppSettings["Copyright"];
        }
    }
}