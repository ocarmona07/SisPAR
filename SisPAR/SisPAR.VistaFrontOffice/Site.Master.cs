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
            
            if (Session["Usuario"] == null) Response.Redirect("Home.aspx");
            if (String.IsNullOrEmpty(Session["Usuario"].ToString())) Response.Redirect("Home.aspx");
            lblUsuarioConectado.Text = Session["Usuario"].ToString();
        }

        /// <summary>
        /// Método que cierra la sesión del usuario conectado
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void LinkSalir(object sender, EventArgs e)
        {
            Session["Usuario"] = string.Empty;
            Response.Redirect("Home.aspx");
        }
    }
}
