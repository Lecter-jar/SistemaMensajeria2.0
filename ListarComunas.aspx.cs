using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarComunas : System.Web.UI.Page
{
    ComunaADO objComuna = new ComunaADO();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            recargarDatos();
        }
        lblMensaje.Text = "";
    }
    public void recargarDatos()
    {
        dgListar.DataSource = objComuna.getComunas();
        dgListar.DataBind();
    }
    public void cancelarEdicion()
    {
        dgListar.EditIndex = -1;
        recargarDatos();
    }
    protected void rowCancelEditEvent(object sender, GridViewCancelEditEventArgs e)
    {
        cancelarEdicion();
    }

    protected void rowDeletingEvent(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            Comuna comuna = new Comuna();
            comuna.idComuna = Convert.ToInt16(dgListar.DataKeys[e.RowIndex].Values["idComuna"].ToString());
            objComuna.eliminarComuna(comuna.idComuna);
            lblMensaje.Text = "*" + objComuna.Mensaje + "*";
            recargarDatos();
        }catch(Exception ex)
        {
            lblMensaje.Text = "Error al eliminar comuna por favor revise que ningun usuario este asociado a esta comuna.";
        }
        

    }

    protected void rowEditingEvent(object sender, GridViewEditEventArgs e)
    {
        dgListar.EditIndex = e.NewEditIndex;
        recargarDatos();

    }
    protected void rowUpdatingEvent(object sender, GridViewUpdateEventArgs e)
    {
        
        int idComuna = Convert.ToInt16(dgListar.DataKeys[e.RowIndex].Values["idComuna"].ToString());
        String nombre = (dgListar.Rows[e.RowIndex].FindControl("txtNombre") as TextBox).Text;
        Comuna comuna = objComuna.buscarComunas(idComuna);
        comuna.Nombre = nombre;
        objComuna.modificarComuna(comuna);
        lblMensaje.Text = "*" + objComuna.Mensaje + "*";
        
        cancelarEdicion();
        recargarDatos();
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        
    }

    protected void rowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
}