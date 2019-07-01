using C3LNegG3AndaurGotschlichValenzuela;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            recargarDatos();
        }
    }

    public void cancelarEdicion()
    {
        GridView1.EditIndex = -1;
        recargarDatos();
    }

    public void recargarDatos()
    {
        C3LNegG3AndaurGotschlichValenzuela.Usuario objusuario = new C3LNegG3AndaurGotschlichValenzuela.Usuario();
        objusuario.Id = 0;
        objusuario.listar(objusuario);
        GridView1.DataSource = objusuario.Ds;
        GridView1.DataBind();

    }

    protected void btnfiltrar_Click(object sender, EventArgs e)
    {
        C3LNegG3AndaurGotschlichValenzuela.Usuario objusuario = new C3LNegG3AndaurGotschlichValenzuela.Usuario();
        objusuario.Id = int.Parse(txtfiltrarUsuario.Text.ToString());
        objusuario.listar(objusuario);
        GridView1.DataSource = objusuario.Ds;
        GridView1.DataBind();
    }

    protected void btnfiltrar_Click1(object sender, EventArgs e)
    {
        recargarDatos();
    }


    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        cancelarEdicion();
    }

    protected void RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        C3LNegG3AndaurGotschlichValenzuela.Usuario objusuario = new C3LNegG3AndaurGotschlichValenzuela.Usuario();
        objusuario.Id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values["idUsuario"].ToString());
        objusuario.eliminar(objusuario);
        recargarDatos();
    }

    protected void rowEditingEvent(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        recargarDatos();
    }

    protected void rowUpdatingEvent(object sender, GridViewUpdateEventArgs e)
    {
        C3LNegG3AndaurGotschlichValenzuela.Usuario objusuario = new C3LNegG3AndaurGotschlichValenzuela.Usuario();
        objusuario.Id = int.Parse(GridView1.DataKeys[e.RowIndex].Values["idUsuario"].ToString());
        objusuario.Rut = (GridView1.Rows[e.RowIndex].FindControl("txtRut") as TextBox).Text.ToUpper();
        objusuario.PrimerNombre = (GridView1.Rows[e.RowIndex].FindControl("txtPrimerNombre") as TextBox).Text.ToUpper();
        objusuario.SegundoNombre = (GridView1.Rows[e.RowIndex].FindControl("txtSegundoNombre") as TextBox).Text.ToUpper();
        objusuario.ApellidoMaterno = (GridView1.Rows[e.RowIndex].FindControl("txtApeMaterno") as TextBox).Text.ToUpper();
        objusuario.ApellidoPaterno = (GridView1.Rows[e.RowIndex].FindControl("txtApePaterno") as TextBox).Text.ToUpper();
        objusuario.Calle = (GridView1.Rows[e.RowIndex].FindControl("txtCalle") as TextBox).Text.ToUpper();
        objusuario.NumeroDomicilio = int.Parse((GridView1.Rows[e.RowIndex].FindControl("txtNumeroDomicilio") as TextBox).Text.ToUpper());
        objusuario.Banco = (GridView1.Rows[e.RowIndex].FindControl("txtBanco") as TextBox).Text.ToUpper();
        objusuario.IdComuna = int.Parse(((GridView1.Rows[e.RowIndex].FindControl("txtComuna") as TextBox).Text.ToUpper()));
        objusuario.Region = (GridView1.Rows[e.RowIndex].FindControl("txtRegion") as TextBox).Text.ToUpper();
        objusuario.modificar(objusuario);
        if (!objusuario.Exito)
        {
            Labelerror.Text = objusuario.Mensaje;
        }
        cancelarEdicion();
        recargarDatos();
    }
}