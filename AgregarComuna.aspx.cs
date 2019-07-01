using C3LNegG3AndaurGotschlichValenzuela;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgregarComuna : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        Comuna objComuna = new Comuna();
        objComuna.Nombre = txtNombre.Text; 
        objComuna.ingresar(objComuna);
        lblMensaje.Text = "*"+objComuna.Mensaje+"*";
        lblMensaje.Visible = true;
        txtNombre.Text = "";
    }
}