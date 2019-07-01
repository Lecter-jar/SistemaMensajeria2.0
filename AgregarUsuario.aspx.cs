using C3LNegG3AndaurGotschlichValenzuela;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgregarUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            iniciarLlenadoComuna();


            // probando

            //git

        }
    }


    private void iniciarLlenadoComuna()
    {
        Comuna objcomuna = new Comuna();

        objcomuna.Nombre = "";

        objcomuna.listar(objcomuna);

        DropDownListcomuna.Items.Add("Seleccionar comuna");

        foreach (DataRow row in objcomuna.Ds.Tables[0].Rows)
        {
            DropDownListcomuna.Items.Add(Convert.ToString(row[1]));
        }

    }

    public int obtenerIdComuna(string nombreComuna)
    {
        Comuna objcomuna = new Comuna();
        int idcomuna = 0;
        objcomuna.Nombre = nombreComuna;

        objcomuna.listar(objcomuna);
        foreach (DataRow filas in objcomuna.Ds.Tables["Table"].Rows)
        {
            idcomuna = int.Parse(filas["idComuna"].ToString());

        }

        return idcomuna;
    }


    protected void btnagregarUsuario_Click(object sender, EventArgs e)
    {
        C3LNegG3AndaurGotschlichValenzuela.Usuario objusuario = new C3LNegG3AndaurGotschlichValenzuela.Usuario();
        objusuario.Rut = txtrut.Text;
        objusuario.PrimerNombre = txtprimernombre.Text;
        objusuario.SegundoNombre = txtsegundonombre.Text;
        objusuario.ApellidoMaterno = txtapematerno.Text;
        objusuario.ApellidoPaterno = txtapepaterno.Text;
        objusuario.Calle = txtcalle.Text;
        objusuario.NumeroDomicilio = int.Parse(txtnumerodom.Text);
        objusuario.Banco = DropDownListbanco.SelectedItem.Text;
        objusuario.IdComuna = obtenerIdComuna(DropDownListcomuna.SelectedItem.Text);
        objusuario.Region = DropDownListregion.SelectedItem.Text;

        objusuario.ingresar(objusuario);
        if (objusuario.Exito == true)
        {
            LabelIngreo.Visible = true;
            LabelIngreo.Text = "Usuario Ingresado";
            txtrut.Text = "";
            txtprimernombre.Text = "";
            txtsegundonombre.Text = "";
            txtapematerno.Text = "";
            txtapepaterno.Text = "";
            txtcalle.Text = "";
            txtnumerodom.Text = "";    

        }
        else
        {
            LabelIngreo.Visible = true;
            LabelIngreo.Text = "Error al ingresar";
        }
    }
}