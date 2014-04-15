namespace SisPAR
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// Clase principal de la MasterPage
    /// </summary>
    public partial class Site : System.Web.UI.MasterPage
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