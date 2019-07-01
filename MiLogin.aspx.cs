using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        if (FormsAuthentication.Authenticate(txtUsuario.Text, txtClave.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(txtUsuario.Text, false);
        }
        else
        {
            lblMensaje.Text = "Usuario o clave incorrecto";
            lblMensaje.Visible = true;
            txtClave.Text = "";
        }
    }
}