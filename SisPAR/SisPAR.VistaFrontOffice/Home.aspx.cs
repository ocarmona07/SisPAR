namespace SisPAR.VistaFrontOffice
{
    using System;
    using System.Configuration;
    using Negocio;

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

        /// <summary>
        /// Método que valida el ingreso
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void EntrarOnClick(object sender, EventArgs e)
        {
            int zero;
            if (!int.TryParse(tbUsuario.Text, out zero)) return;
            
            if (new UsuariosBo().ComprobarUsuarioFront(int.Parse(tbUsuario.Text)))
            {
                Session["Usuario"] = new UsuariosBo().ObtenerUsuarioPorRut(int.Parse(tbUsuario.Text));
                Response.Redirect("Requerimientos.aspx");
            }
            else
            {
                lblUsuarioError.Text = " Usuario incorrecto";
            }
        }
    }
}