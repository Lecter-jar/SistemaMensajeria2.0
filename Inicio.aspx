<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>
    <asp:Label ID="Label1" runat="server" Text="Label" style="color: #000000; font-size: xx-large; ">Bienvenidos al sitio web de Mensajeria</asp:Label>
    </h1>
    <p ><asp:Label ID="Label2" runat="server" Text="Label">Este es un sistema web que gestiona los servicios de mensajeria de un proveedor de dichos servicios. En este podrá encontrar diversas funcionalidades listadas a continuación...</asp:Label></p>
    <h4 >
        <asp:Label ID="Label3" runat="server" Text="Label">Funcionalidades:</asp:Label></h4>
    <p style="font-weight: 700">  <asp:Label ID="Label4" runat="server" Text="Label" style="text-align: left">1.</asp:Label> &nbsp;Registrar un nuevo usuario: <span class="auto-style1">Podrá acceder a un formulario en donde registrará un nuevo usuario ingresando los datos solicitados</span></p>
    <p  style="font-weight: 700">  <asp:Label ID="Label5" runat="server" Text="Label" style="text-align: left">2.</asp:Label> &nbsp;Modificar/eliminar/listar usuario: <span class="auto-style1">podrá ver la lista de los usuarios del sistema, en ella puede modificar los datos de un usuario y/o eliminarlo.</span></p>
    <p style="font-weight: 700">  <asp:Label ID="Label6" runat="server" Text="Label" style="text-align: left">3.</asp:Label> &nbsp;RECARGA: <span class="auto-style1">EN ESTA SECCIÓN puede realizar una nueva recarga a su móvil y listar las recargas que se han efectuado a un teléfono</span></p>
    <p  style="font-weight: 700">  <asp:Label ID="Label7" runat="server" Text="Label" style="text-align: left">4.</asp:Label> &nbsp;mensajes: <span class="auto-style1">aquí podrá enviar mensajes y ver el historial de mensajes que ha enviado </span></p>
    <p  style="font-weight: 700">  <asp:Label ID="Label8" runat="server" Text="Label" style="text-align: left">5.</asp:Label> &nbsp;conexión: <span class="auto-style1">en esta sección podrá dar de alta en el sistema un teléfono o también darlo de baja mediante el desconectarlo</span></p>
    <p style="font-weight: 700">  <asp:Label ID="Label9" runat="server" Text="Label" style="text-align: left">6.</asp:Label> &nbsp;desvíos: <span class="auto-style1">aquí podrá activar o desactivar los desvios de mensajes, a su vez escoger a que teléfono desviará dicho mensaje</span></p>
    <p style="font-weight: 700">  <asp:Label ID="Label10" runat="server" Text="Label" style="text-align: left">7.</asp:Label> &nbsp;teléfono: <span class="auto-style1">en esta sección podrá registrar un nuevo teléfono asi como modificarlo, listarlos y eliminar</span></p>
    <p  style="font-weight: 700">  <asp:Label ID="Label11" runat="server" Text="Label" style="text-align: left">8.</asp:Label> &nbsp;comuna: <span class="auto-style1">en esta sección podrá ingresar mediante un formulario una nueva comuna, modificarla, listarlas y eliminarla si es necesario</span></p>
    <p  style="font-weight: 700">  <asp:Label ID="Label12" runat="server" Text="Label" style="text-align: left">9.</asp:Label> &nbsp;administrador: <span class="auto-style1">en esta sección el administrador podrá acceder a las estadísticas del sistema, consultar datos de usuarios, teléfonos, etc.</span></p>
    <p " style="font-weight: 700">  <strong>  <asp:Label ID="Label13" runat="server" Text="Label" style="text-align: left">10.</asp:Label> &nbsp;nosotros:</strong> <span class="auto-style1">en esta sección podrá acceder a toda la información relacionada con respecto a los dueños de la página</span></p>
</asp:Content>

