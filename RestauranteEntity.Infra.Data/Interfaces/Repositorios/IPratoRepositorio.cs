using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteEntity.Dominio.Model;
namespace RestauranteEntity
{
    public interface IPratoRepositorio: IRepositorioBase<Prato>
    {
        IEnumerable<Prato> BuscarTudoComTipo();
    }
}
