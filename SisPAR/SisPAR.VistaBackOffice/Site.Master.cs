using System.Web.UI.WebControls;

namespace SisPAR.VistaBackOffice
{
    using System;
    using System.Configuration;

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

            //if (Session["Usuario"] == null) Response.Redirect("Home.aspx");
            //if (String.IsNullOrEmpty(Session["Usuario"].ToString())) Response.Redirect("Home.aspx");
            lblUsuarioConectado.Text = "Yo"; //Session["Usuario"].ToString();
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

                case "finalizar":
                    Response.Redirect("Home.aspx");
                    break;

                case "test":
                    Session["Usuario"] = "";
                    break;
            }
        }
    }
}