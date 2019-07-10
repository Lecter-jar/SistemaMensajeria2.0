using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgregarComuna : System.Web.UI.Page
{
    private ComunaADO objComuna = new ComunaADO();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        Comuna nuevaComuna = new Comuna();   
        nuevaComuna.Nombre = txtNombre.Text; 
        objComuna.agregarComuna(nuevaComuna);
        lblMensaje.Text = "*"+objComuna.Mensaje+"*";
        lblMensaje.Visible = true;
        txtNombre.Text = "";
    }
}