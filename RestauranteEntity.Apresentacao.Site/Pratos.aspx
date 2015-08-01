<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Pratos.aspx.cs" Inherits="RestauranteEntity.Apresentacao.Site.Pratos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h3>Pratos</h3>
        <div class="row">
            <div class="col-lg-8">
                <div class="panel panel-group">
                   
                    <div class="panel-body">
                        <div class="form-inline">
                            <div class="form-group">

                                <label>Buscar por</label>
                                <asp:TextBox ID="txtBuscaPor" runat="server" CssClass="form-control" placeholter="Buque pelo nome do prato"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Tipo</label>
                                <asp:DropDownList runat="server" CssClass="form-control" ID="ddlTipo">
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:Button Text="Buscar" CssClass="btn btn-primary" OnClick="Buscar" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4">
                <a href="CadastroPratos.aspx" class="btn btn-primary">Novo Prato</a>
            </div>
        </div>
        <br />
        <div class="well">
            <div class="row">

                <asp:GridView runat="server" ID="gridPrato" AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText="Codigo Prato">
                            <ItemTemplate>
                                <asp:LinkButton Text='<%# DataBinder.Eval(Container.DataItem,"PratoId") %>' CommandArgument='<%# DataBinder.Eval(Container.DataItem,"PratoId") %>' OnCommand="Alterar" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Nome" DataField="Nome" />
                        <asp:TemplateField HeaderText="Descrição">
                            <ItemTemplate>
                                <div style="overflow: scroll">
                                    <%# DataBinder.Eval(Container.DataItem,"Descricao") %>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Tipo.Nome" HeaderText="Tipo" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton Text="Deletar" OnClientClick="return confirm('Deseja mesmo remover este item?');" runat="server" OnCommand="Deletar" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"PratoId") %>'/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:Label Text="" ID="lblErroMsg" runat="server" />
            </div>
        </div>
    </section>

</asp:Content>
