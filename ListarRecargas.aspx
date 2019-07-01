<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="ListarRecargas.aspx.cs" Inherits="ListarRecargas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 760px;
            text-align: right;
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
        .auto-style10 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td colspan="2" class="auto-style6"><strong>Listado de Recargas</strong></td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5" aria-checked="mixed">
                &nbsp;</td>
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
                <asp:GridView align="center" ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3"
                     ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" DataKeyNames="idRecarga" DataSourceID="SqlDataSource1" EnableModelValidation="True">
                    <Columns>
                        <asp:BoundField DataField="idRecarga" HeaderText="idRecarga" ReadOnly="True" InsertVisible="False" SortExpression="idRecarga"></asp:BoundField>
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha"></asp:BoundField>
                        <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto"></asp:BoundField>
                        <asp:BoundField DataField="Numero" HeaderText="Numero" SortExpression="Numero"></asp:BoundField>
                    </Columns>
                </asp:GridView>
                <%-- <asp:GridView ID="dgListar" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3"
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

                </asp:GridView>--%>
                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:DB_PAAC3GN3ANDAURGOTSCHLICHVALENZUELAConnectionString %>' SelectCommand="SELECT [idRecarga], [Fecha], [Monto], [Numero] FROM [Recarga]"></asp:SqlDataSource>
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

