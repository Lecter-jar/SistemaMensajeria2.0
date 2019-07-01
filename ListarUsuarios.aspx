<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="ListarUsuarios.aspx.cs" Inherits="ListarUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 258px;
        }
        .auto-style2 {
            width: 100%;
            height: 190px;
        }
        .auto-style3 {
            height: 43px;
            text-align: left;
            width: 253px;
        }
        .auto-style4 {
            height: 43px;
            text-align: right;
            width: 485px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            width: 485px;
        }
        .auto-style7 {
            width: 253px;
        }
        .auto-style8 {
            text-align: center;
            height: 122px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style1">
    Listar Usuarios<table class="auto-style2">
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="txtfiltrarUsuario" runat="server" CssClass="auto-style5" Height="24px" Width="182px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnfiltrar" runat="server" OnClick="btnfiltrar_Click1" Text="Filtrar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style8" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="idUsuario" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="RowDeleting" OnRowEditing="rowEditingEvent" OnRowUpdating="rowUpdatingEvent" Width="237px">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:TemplateField HeaderText="idUsuario">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtidUsuario" runat="server" Text='<%#Bind("idUsuario") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblid" runat="server" Text='<%#Bind("idUsuario") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Rut">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtRut" runat="server" Text='<%#Bind("Rut") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblrut" runat="server" Text='<%#Bind("Rut") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Primer Nombre">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtPrimerNombre" runat="server" Text='<%#Bind("Primer_nombre") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblprimerNombre" runat="server" Text='<%#Bind("Primer_nombre") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                             <asp:TemplateField HeaderText="Segundo Nombre">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtSegundoNombre" runat="server" Text='<%#Bind("Segundo_nombre") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblsegundoNombre" runat="server" Text='<%#Bind("Segundo_nombre") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                             <asp:TemplateField HeaderText="Apellido materno">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtApeMaterno" runat="server" Text='<%#Bind("Apellido_materno") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblapematerno" runat="server" Text='<%#Bind("Apellido_materno") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Apellido paterno">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtApePaterno" runat="server" Text='<%#Bind("Apellido_paterno") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblapepaterno" runat="server" Text='<%#Bind("Apellido_paterno") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Calle">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtCalle" runat="server" Text='<%#Bind("Calle") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblcalle" runat="server" Text='<%#Bind("Calle") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Numero Domicilio">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtNumeroDomicilio" runat="server" Text='<%#Bind("Numero_domicilio") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblnumeroDomicilio" runat="server" Text='<%#Bind("Numero_domicilio") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Banco">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtBanco" runat="server" Text='<%#Bind("Banco") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblbanco" runat="server" Text='<%#Bind("Banco") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Comuna">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtComuna" runat="server" Text='<%#Bind("Comuna") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblcomuna" runat="server" Text='<%#Bind("Comuna") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                            <asp:TemplateField HeaderText="Region">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtRegion" runat="server" Text='<%#Bind("Region") %>' ></asp:TextBox>
                                </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblregion" runat="server" Text='<%#Bind("Region") %>' ></asp:Label>
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
                <td class="auto-style6">
                    <asp:Label ID="Labelerror" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
        </table>
    </p>
    <p class="auto-style1">
        &nbsp;</p>
</asp:Content>

