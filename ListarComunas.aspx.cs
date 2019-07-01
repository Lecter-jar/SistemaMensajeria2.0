using C3LNegG3AndaurGotschlichValenzuela;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarComunas : System.Web.UI.Page
{
    
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
        Comuna objComuna = new Comuna();
        objComuna.Nombre = txtBuscarComuna.Text;
        objComuna.listar(objComuna);
        dgListar.DataSource = objComuna.Ds;
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
        Comuna objComuna = new Comuna();
        objComuna.Id = Convert.ToInt16(dgListar.DataKeys[e.RowIndex].Values["idComuna"].ToString());
        objComuna.eliminar(objComuna);
        lblMensaje.Text = "*"+objComuna.Mensaje+"*";
        recargarDatos();

    }

    protected void rowEditingEvent(object sender, GridViewEditEventArgs e)
    {
        dgListar.EditIndex = e.NewEditIndex;
        recargarDatos();

    }
    protected void rowUpdatingEvent(object sender, GridViewUpdateEventArgs e)
    {
        Comuna objComuna = new Comuna();
        objComuna.Id = Convert.ToInt16(dgListar.DataKeys[e.RowIndex].Values["idComuna"].ToString());
        objComuna.Nombre = (dgListar.Rows[e.RowIndex].FindControl("txtNombre") as TextBox).Text.ToUpper();
        objComuna.modificar(objComuna);
        lblMensaje.Text = "*" + objComuna.Mensaje + "*";

        cancelarEdicion();
        recargarDatos();
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        recargarDatos();
    }
}