<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AgregarComuna.aspx.cs" Inherits="AgregarComuna" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 20px;
        }
        .auto-style3 {
            height: 20px;
            width: 473px;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            text-align: left;
            height: 29px;
        }
        .auto-style7 {
            color: #000066;
            font-size: xx-large;
        }
        .auto-style8 {
            text-align: right;
            height: 29px;
            width: 515px;
        }
        .auto-style9 {
            height: 20px;
            width: 515px;
        }
        .auto-style10 {
            width: 515px;
        }
        .auto-style11 {
        font-size: large;
    }
        .auto-style12 {
            color: #000066;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td colspan="3" class="auto-style7"><strong>Agregar comuna</strong></td>
        </tr>
        <tr>
            <td colspan="3" class="auto-style7">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="3">
                <strong>
                <asp:Label ID="lblMensaje" runat="server" Visible="False" Font-Italic="False" Height="20px" CssClass="auto-style12" ForeColor="#000066"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"><span class="auto-style11">Nombre:</span>&nbsp;
            </td>
            <td class="auto-style6" colspan="2">&nbsp; 
                <asp:TextBox ID="txtNombre" runat="server" Width="241px" placeholder="Ingrese la Comuna" CssClass="input100" style="font-size: large"></asp:TextBox>
                <em>
                <asp:RequiredFieldValidator ID="RegularExpressionValidatortxtNombre" ControlToValidate="txtNombre" runat="server" ErrorMessage="*Ingrese una comuna"></asp:RequiredFieldValidator>
                </em>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <strong>
                <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" BackColor="Black" BorderColor="Gray" CssClass="auto-style11" Font-Names="Arial" ForeColor="White" />
                </strong>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

