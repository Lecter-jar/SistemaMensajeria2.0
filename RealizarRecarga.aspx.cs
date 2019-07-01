using C3LNegG3AndaurGotschlichValenzuela;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RealizarRecarga : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //Text = "Agregar" BackColor = "Black" BorderColor = "Gray" CssClass = "auto-style11" Font - Names = "Arial" ForeColor = "White"
        //    Recarga objRecarga = new Recarga();
        //objRecarga.Monto = int.Parse(txtMonto.Text);
        //objRecarga.IdTelefono = int.Parse(cmbTelefono.SelectedValue);

        //objRecarga.ingresar(objRecarga);
        //lblMensaje.Text = "*" + objRecarga.Mensaje + "*";
        //lblMensaje.Visible = true;
        //txtMonto.Text = "";
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime hoy = DateTime.Now;
        Recarga objRecarga = new Recarga();
        objRecarga.Fecha = DateTime.Now;
        objRecarga.Monto = int.Parse(txtMonto.Text);
        objRecarga.Numero = int.Parse(cmbTelefono.SelectedValue);
        //objRecarga.Fecha = hoy.ToString("dd/MM/yyyy");
        


        objRecarga.ingresar(objRecarga);
        lblMensaje.Text = "*" + objRecarga.Mensaje + "*";
        lblMensaje.Visible = true;
        txtMonto.Text = "";

        //DateTime hoy = DateTime.Now;

        //string miVariable = hoy.ToString("dd/MM/yyyy");
    }
}