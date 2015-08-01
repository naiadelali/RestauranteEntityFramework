using RestauranteEntity.Dominio.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestauranteEntity.Dominio.Model;
namespace RestauranteEntity.Apresentacao.Site
{
    public partial class CadastroPratos : System.Web.UI.Page
    {
        private readonly PratoServico _servicoPrato = new PratoServico();
        private readonly TipoServico _servicoTipo = new TipoServico();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {

                   
                  
                }
            }
            catch (Exception ex)
            {

                lblErroMsg.Text = "<div class='alert alert-danger'>" + ex.Message + "</div>";
            }
        }

        protected override void OnInit(EventArgs e)
        {
            IniciarTipoPrato();
            VerificaPrato();
            base.OnInit(e);
        }
        private void VerificaPrato()
        {
            if (Request.QueryString["prato"] == null)
            {
                btnCofirmar.Text = "Inserir";
                btnCofirmar.Click += new EventHandler(Inserir);
               
            }
            else
            {
                int id = Convert.ToInt32(Request.QueryString["prato"]);
                var prato = _servicoPrato.BuscarPorId(id);

                if (prato != null)
                {
                    lblPratoId.Value = prato.PratoId.ToString();
                    txtNomePrato.Text = prato.Nome;
                    txtDescricao.Text = prato.Descricao;
                    ddlTipo.SelectedValue = prato.TipoId.ToString();
                    btnCofirmar.Text = "Alterar";
                    btnCofirmar.Click += new EventHandler(Alterar);
                }
                else
                    throw new Exception("Erro ao carregar o prato");
            }
        }

        protected void Alterar(object sender, EventArgs e)
        {
            try
            {
                Prato prato = new Prato()
                {
                    PratoId = Convert.ToInt32(lblPratoId.Value),
                    Nome = txtNomePrato.Text,
                    Descricao = txtDescricao.Text,
                    TipoId = Convert.ToInt32(ddlTipo.SelectedValue)
                };

                _servicoPrato.Atualizar(prato);
                lblErroMsg.Text = "<div class='alert alert-success'>Prato atualizado com sucesso!</div>";
            }
            catch (Exception ex)
            {

                lblErroMsg.Text = "<div class='alert alert-danger'>Não foi possível modificar o prato! " + ex.Message + "</div>";
            }
        }

        protected void Inserir(object sender, EventArgs e)
        {
            try
            {
                Prato prato = new Prato()
                {
                    Descricao = txtDescricao.Text,
                    Nome = txtNomePrato.Text,
                    TipoId = Convert.ToInt32(ddlTipo.SelectedValue)
                };
                _servicoPrato.Inserir(prato);
                lblErroMsg.Text = "<div class='alert alert-success'>Prato inserido com sucesso!</div>";
            }
            catch (Exception ex)
            {

                lblErroMsg.Text = "<div class='alert alert-danger'>Não foi possível inserir o prato! " + ex.Message + "</div>";
            }
        }

        private void IniciarTipoPrato()
        {
            var tipos = _servicoTipo.BuscarTudo();

            if (tipos != null || tipos.Count() > 0)
            {
                ddlTipo.DataSource = tipos;
                ddlTipo.DataTextField = "Nome";
                ddlTipo.DataValueField = "TipoId";
                ddlTipo.DataBind();
            }
        }
    }
}