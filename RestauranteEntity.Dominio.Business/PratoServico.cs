using RestauranteEntity.Dominio.Business.Interfaces.Servico;
using RestauranteEntity.Dominio.Model;
using RestauranteEntity.Infra.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteEntity.Dominio.Business
{
    public class PratoServico: ServicoBase<Prato>, IPratoServico
    {
        private readonly PratoRepositorio _pratoRepositorio = new PratoRepositorio();
        public IEnumerable<Prato> BuscarTudoComTipo()
        {
            return _pratoRepositorio.BuscarTudoComTipo();
        }
    }
}
