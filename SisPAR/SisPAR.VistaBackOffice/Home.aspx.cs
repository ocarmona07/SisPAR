
using System.Globalization;

namespace SisPAR.VistaBackOffice
{
    using System;
    using System.Configuration;
    using Entidades;
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

        protected void EntrarOnClick(object sender, EventArgs e)
        {
            int zero;
            if (!int.TryParse(tbUsuario.Text, out zero)) return;

            var usuario = new USU_USUARIO
            {
                USU_RUT = int.Parse(tbUsuario.Text),
                USU_PASSWORD = tbPassword.Text
            };

            if (new UsuariosBo().ComprobarUsuario(usuario))
            {
                Session["Usuario"] = new UsuariosBo().ObtenerUsuarioPorRut(int.Parse(tbUsuario.Text));
                Response.Redirect("SolicitudesPendientes.aspx");
            }
            else
            {
                lblPasswordError.Text = " Usuario o Contraseña incorrecta";
            }
        }
    }
}