<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroPratos.aspx.cs" Inherits="RestauranteEntity.Apresentacao.Site.CadastroPratos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h3>Cadastro de Pratos</h3>
        <div class="form-horizontal">
            <div class="form-group">
                 <asp:HiddenField ID="lblPratoId" runat="server" Value="" />
                <label>Nome do Prato: </label>
                <asp:TextBox runat="server" Placeholter="Nome do prato" MaxLength="150" ID="txtNomePrato" CssClass="form-control"/>
            </div>
            <div class="form-group">
                <label>Descrição: </label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" MaxLength="250" CssClass="form-control" Columns="3"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Tipo do Prato: </label>
                <asp:DropDownList runat="server" CssClass="form-group" ID="ddlTipo">              
                </asp:DropDownList>
            </div>
            <asp:Label Text="" ID="lblErroMsg" runat="server" />
            <div class="form-group">
                <asp:Button runat="server" ID="btnCofirmar" CssClass="btn btn-primary" Text="Inserir" />
                <a href="Pratos.aspx" class="btn btn-default" >Cancelar</a>
            </div>
            
        </div>
    </section>
</asp:Content>
