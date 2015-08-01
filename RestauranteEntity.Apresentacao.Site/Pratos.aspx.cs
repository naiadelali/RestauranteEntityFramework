using RestauranteEntity.Dominio.Business;
using RestauranteEntity.Dominio.Business.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestauranteEntity.Apresentacao.Site
{
    public partial class Pratos : System.Web.UI.Page
    {
        private readonly PratoServico _servicoPrato = new PratoServico();
        private readonly TipoServico _servicoTipo = new TipoServico();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    ViewState["ListaPratos"] = null;
                    IniciarTipoPrato();
                    IniciarPratos();
                }
            }
            catch (Exception ex)
            {

                lblErroMsg.Text = "<div class='alert alert-danger'>" + ex.Message + "</div>";
            }

        }

        private void IniciarPratos()
        {
            var pratos = _servicoPrato.BuscarTudoComTipo();

            if (pratos != null || pratos.Count() > 0)
            {
                ViewState["ListaPratos"] = pratos;
                gridPrato.DataSource = pratos;
                gridPrato.DataBind();

            }
        }

        private void IniciarTipoPrato()
        {
            try
            {

                ddlTipo.DataSource = _servicoTipo.BuscarTudo();
                ddlTipo.DataValueField = "TipoId";
                ddlTipo.DataTextField = "Nome";
                ddlTipo.DataBind();
                ddlTipo.Items.Add(new ListItem("Todos", "0"));
                ddlTipo.SelectedValue = "0";

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível iniciar os tipos. " + ex.Message);
            }
        }

        protected void Alterar(object sender, CommandEventArgs e)
        {
            var id = e.CommandArgument.ToString();

            Response.Redirect("CadastroPratos.aspx?prato=" + id, false);
        }

        protected void Deletar(object sender, CommandEventArgs e)
        {
            var id = e.CommandArgument;
            var prato = _servicoPrato.BuscarPorId(Convert.ToInt32(id));
            _servicoPrato.Deletar(prato);
        }

        protected void Buscar(object sender, EventArgs e)
        {
            var pratos = _servicoPrato.BuscarTudoComTipo();
            if (!string.IsNullOrEmpty(txtBuscaPor.Text))

               pratos= pratos.Where(p => p.Nome == txtBuscaPor.Text);


            if (ddlTipo.SelectedValue != "0")
               pratos= pratos.Where(p => p.TipoId == Convert.ToInt32(ddlTipo.SelectedValue));

            gridPrato.DataSource = pratos;
            gridPrato.DataBind();

            Response.Redirect("Pratos.aspx", false);

        }
    }
}