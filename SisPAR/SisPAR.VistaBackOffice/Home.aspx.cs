namespace SisPAR.VistaBackOffice
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
        /// Método que valida el ingreso al sistema
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Argumentos del evento</param>
        protected void EntrarOnClick(object sender, EventArgs e)
        {
            int zero;
            if (!int.TryParse(tbUsuario.Text, out zero))
            {
                lblPasswordError.Text = "El campo Usuario debe ser numérico";
                return;
            }

            if (new UsuariosBo().ComprobarUsuarioBack(int.Parse(tbUsuario.Text), tbPassword.Text))
            {
                Session["UsuarioBack"] = new UsuariosBo().ObtenerUsuarioPorRut(int.Parse(tbUsuario.Text));
                Response.Redirect("SolicitudesPendientes.aspx");
            }
            else
            {
                lblPasswordError.Text = " Usuario o Contraseña incorrecta";
            }
        }
    }
}