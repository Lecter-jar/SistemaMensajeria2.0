<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListarComunas.aspx.cs" Inherits="ListarComunas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 760px;
            text-align: right;
        }
        .auto-style4 {
            margin-left: 404px;
        font-size: medium;
    }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            color: #000066;
            font-size: xx-large;
        }
    .auto-style7 {
        color: #000066;
    }
    .auto-style8 {
        font-size: medium;
    }
        .auto-style9 {
            text-align: center;
        }
        .auto-style10 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td colspan="2" class="auto-style6"><strong>Listado de Comunas</strong></td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:TextBox ID="txtBuscarComuna" placeholder="Buscar Comuna" runat="server" Width="174px" CssClass="auto-style8"></asp:TextBox>
            </td>
            <td class="auto-style5" aria-checked="mixed">
                <asp:Button ID="btnBuscar"  runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="88px" BackColor="Black" BorderColor="#CCCCCC" BorderStyle="Double" Font-Bold="False" Font-Italic="False" Font-Names="Arial Narrow" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" ForeColor="White"  />
            </td>
        </tr>
        <tr>
            <td class="auto-style10" colspan="2">
                <strong>
                <asp:Label ID="lblMensaje" runat="server" CssClass="auto-style7"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="dgListar" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3"
                    EnableModelValidation="True" ForeColor="Black" GridLines="Vertical" OnRowCancelingEdit="rowCancelEditEvent" OnRowDeleting="rowDeletingEvent" 
                    OnRowEditing="rowEditingEvent" AutoGenerateColumns="False"
                    CssClass="auto-style4" Width="449px" DataKeyNames="idComuna" OnRowUpdating="rowUpdatingEvent">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:TemplateField HeaderText="Nombre">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtNombre" runat="server" Text='<%#Bind("nombre") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblNombre" runat="server" Text='<%#Bind("nombre") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />

                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />

                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

