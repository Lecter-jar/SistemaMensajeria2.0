using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgregarUsuario : System.Web.UI.Page
{

    UsuarioADO usuarioAdo = new UsuarioADO(); // se instancia la clase usuario ado
    BancoADO bancoAdo = new BancoADO(); // se instancia la clase banco ado
    ComunaADO comunaAdo = new ComunaADO(); // se instancia la clase comuna ado
    RegionADO regionAdo = new RegionADO(); // se instancia la clase region ado


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            iniciarLlenadoBanco();
            iniciarLlenadoComuna();
            iniciarLlenadoRegion();

        }
    }

    private void iniciarLlenadoBanco()
    {

        DropDownListbanco.DataSource = comunaAdo.getComunas();
        DropDownListbanco.DataTextField = "Nombre";
        DropDownListbanco.DataValueField = "idBanco";
        DropDownListbanco.DataBind();

    }

    private void iniciarLlenadoComuna()
    {

        DropDownListcomuna.DataSource = comunaAdo.getComunas();
        DropDownListcomuna.DataTextField = "Nombre";
        DropDownListcomuna.DataValueField = "idComuna";
        DropDownListcomuna.DataBind();

    }

    private void iniciarLlenadoRegion()
    {

        DropDownListregion.DataSource = comunaAdo.getComunas();
        DropDownListregion.DataTextField = "Nombre";
        DropDownListregion.DataValueField = "idRegion";
        DropDownListregion.DataBind();

    }


    protected void btnagregarUsuario_Click(object sender, EventArgs e)
    {
        Banco banco = bancoAdo.buscarBancos(Convert.ToInt32(DropDownListbanco.SelectedValue));
        Comuna comuna = comunaAdo.buscarComunas(Convert.ToInt32(DropDownListcomuna.SelectedValue));
        Region region = regionAdo.buscarRegiones(Convert.ToInt32(DropDownListregion.SelectedValue));

        Usuario objusuario = new Usuario();
        objusuario.Rut = txtrut.Text;
        objusuario.Primer_nombre = txtprimernombre.Text;
        objusuario.Segundo_nombre = txtsegundonombre.Text;
        objusuario.Apellido_materno = txtapematerno.Text;
        objusuario.Apellido_paterno = txtapepaterno.Text;
        objusuario.Calle = txtcalle.Text;
        objusuario.Numero_domicilio = txtnumerodom.Text;
        objusuario.Banco = banco.idBanco;
        objusuario.Comuna = comuna.idComuna;
        objusuario.Region = region.idRegion;

        usuarioAdo.agregar(objusuario);

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


} // fin agregar usuario