namespace SisPAR.VistaFrontOffice
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Clase principal de la MasterPage
    /// </summary>
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        /// <summary>
        /// Método que se ejecuta al inicio de la MasterPage
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCopyright.Text = ConfigurationManager.AppSettings["Copyright"];
        }
    }
}
