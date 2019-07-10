using C3LNegG3AndaurGotschlichValenzuela;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarUsuarios : System.Web.UI.Page
{

    UsuarioADO objUsuarioADO = new UsuarioADO();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            recargarDatos();
        }
        Labelerror.Text = "";
    }

    public void cancelarEdicion()
    {
        GridView1.EditIndex = -1;
        recargarDatos();
    }

    public void recargarDatos()
    {
        
        GridView1.DataSource = objUsuarioADO.getUsuarios();
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
        try
        {
            C3LNegG3AndaurGotschlichValenzuela.Usuario usuario = new C3LNegG3AndaurGotschlichValenzuela.Usuario();
            usuario.Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["idUsuario"].ToString());
            objUsuarioADO.eliminar(usuario.Id);
            Labelerror.Text = objUsuarioADO.Mensaje;
            recargarDatos();
        }
        catch (Exception ex)
        {
            Labelerror.Text = objUsuarioADO.Mensaje + ex;


        }

    }

    protected void rowEditingEvent(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        recargarDatos();
    }

    protected void rowUpdatingEvent(object sender, GridViewUpdateEventArgs e)
    {
        
        Usuario usuario = new Usuario(); // se instancia un obj usuario

        int id = int.Parse(GridView1.DataKeys[e.RowIndex].Values["idUsuario"].ToString()); // se obtiene el id segun el gridview obtenido

        // se asignan los valores obtenidos del gridview 
        String rut = (GridView1.Rows[e.RowIndex].FindControl("txtRut") as TextBox).Text.ToUpper();
        String primerNombre = (GridView1.Rows[e.RowIndex].FindControl("txtPrimerNombre") as TextBox).Text.ToUpper();
        String segundoNombre = (GridView1.Rows[e.RowIndex].FindControl("txtSegundoNombre") as TextBox).Text.ToUpper();
        String apeMaterno = (GridView1.Rows[e.RowIndex].FindControl("txtApeMaterno") as TextBox).Text.ToUpper();
        String apePaterno = (GridView1.Rows[e.RowIndex].FindControl("txtApePaterno") as TextBox).Text.ToUpper();
        String calle = (GridView1.Rows[e.RowIndex].FindControl("txtCalle") as TextBox).Text.ToUpper();
        String numeroDomicilio = (GridView1.Rows[e.RowIndex].FindControl("txtNumeroDomicilio") as TextBox).Text.ToUpper();
        int idBanco = int.Parse(GridView1.DataKeys[e.RowIndex].Values["Banco"].ToString());
        int idComuna = int.Parse(GridView1.DataKeys[e.RowIndex].Values["Comuna"].ToString());
        int idRegion = int.Parse(GridView1.DataKeys[e.RowIndex].Values["Region"].ToString());


        usuario = objUsuarioADO.buscar(id); // se obtiene el usuario segun el id

        // se asignan los nuevos valores
        usuario.Rut = rut;
        usuario.Primer_nombre = primerNombre;
        usuario.Segundo_nombre = segundoNombre;
        usuario.Apellido_materno = apeMaterno;
        usuario.Apellido_paterno = apePaterno;
        usuario.Calle = calle;
        usuario.Numero_domicilio = numeroDomicilio;
        usuario.Banco = idBanco;
        usuario.Comuna = idComuna;
        usuario.Region = idRegion;

        objUsuarioADO.modificarUsuario(usuario); // se modifican los atributos del usuario encontrado

        cancelarEdicion();
        recargarDatos();
    }
}