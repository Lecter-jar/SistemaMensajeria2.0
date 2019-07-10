<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="AgregarUsuario.aspx.cs" Inherits="AgregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .auto-style3 {
            text-align: center;
            width: 575px;
        }
        .auto-style4 {
            text-align: center;
            width: 575px;
            height: 26px;
        }
        .auto-style6 {
            width: 345px;
        }
        .auto-style7 {
            height: 26px;
            width: 345px;
        }
        .auto-style8 {
            text-align: center;
            width: 575px;
            height: 20px;
        }
        .auto-style9 {
            width: 345px;
            height: 20px;
        }
        </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p><strong>Agregar Usuario</strong></p>
    <asp:Panel ID="Panel1" runat="server" Height="500px">
        <table style="border: thin solid #000000; width: 100%; table-layout: auto; background-color: #B8DCDC;" border="1">
            <tr>
                <td class="auto-style3">rut</td>
                <td class="auto-style6">
                    &nbsp;<asp:TextBox ID="txtrut" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">primer nombre</td>
                <td class="auto-style6">
                    &nbsp;<asp:TextBox ID="txtprimernombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">segundo nombre</td>
                <td class="auto-style6">
                    &nbsp;<asp:TextBox ID="txtsegundonombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">apellido materno</td>
                <td class="auto-style6">
                    &nbsp;<asp:TextBox ID="txtapematerno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">apellido paterno</td>
                <td class="auto-style7">
                    &nbsp;<asp:TextBox ID="txtapepaterno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">calle</td>
                <td class="auto-style6">
                    &nbsp;<asp:TextBox ID="txtcalle" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">numero de domicilio</td>
                <td class="auto-style6">
                    &nbsp;<asp:TextBox ID="txtnumerodom" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    banco</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownListbanco" runat="server">
                        <asp:ListItem>BCI</asp:ListItem>
                        <asp:ListItem>BANCOESTADO</asp:ListItem>
                        <asp:ListItem>ITAU</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">comuna</td>
                <td class="auto-style9">
                    <asp:DropDownList ID="DropDownListcomuna" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">region</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownListregion" runat="server">
                        <asp:ListItem>METROPOLITANA</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnagregarUsuario" runat="server" Text="Agregar" OnClick="btnagregarUsuario_Click" BackColor="Black" ForeColor="White" />
                </td>
                <td class="auto-style6">
                    <asp:Label ID="LabelIngreo" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

