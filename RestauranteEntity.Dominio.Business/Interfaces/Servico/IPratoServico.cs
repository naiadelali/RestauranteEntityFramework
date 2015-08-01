using RestauranteEntity.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteEntity.Dominio.Business.Interfaces.Servico
{
    public interface IPratoServico : IServicoBase<Prato>
    {
        IEnumerable<Prato> BuscarTudoComTipo();
    }
}
