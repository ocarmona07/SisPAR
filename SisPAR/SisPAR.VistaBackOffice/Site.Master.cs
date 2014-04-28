namespace SisPAR.VistaBackOffice
{
    using System;
    using System.Configuration;
    using System.Web.UI.WebControls;

    /// <summary>
    /// Clase principal de la MasterPage
    /// </summary>
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        /// <summary>
        /// Método que se ejecuta al iniciar la vista
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCopyright.Text = ConfigurationManager.AppSettings["Copyright"];

            if (Session["UsuarioBack"] == null) Response.Redirect("Home.aspx");
            if (String.IsNullOrEmpty(Session["UsuarioBack"].ToString())) Response.Redirect("Home.aspx");
            lblUsuarioConectado.Text = Session["UsuarioBack"].ToString();
        }

        /// <summary>
        /// Método que redirecciona los botones del menú
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "solicitudReq":
                    Response.Redirect("SolicitudesPendientes.aspx");
                    break;

                case "atencionReq":
                    Response.Redirect("AtencionRequerimientos.aspx");
                    break;

                case "gestionSol":
                    Response.Redirect("GestionSolicitudes.aspx");
                    break;

                case "finalizar":
                    Session["UsuarioBack"] = string.Empty;
                    Response.Redirect("Home.aspx");
                    break;
            }
        }
    }
}