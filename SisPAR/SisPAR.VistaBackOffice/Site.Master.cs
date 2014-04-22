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
            lblUsuarioConectado.Text = "Usuario Test";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            }
        }
    }
}