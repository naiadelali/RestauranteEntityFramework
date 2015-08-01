using RestauranteEntity.Dominio;
using RestauranteEntity.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteEntity.Infra.Data.Repositorios
{
    public class PratoRepositorio: RepositorioBase<Prato>, IPratoRepositorio
    {

        public IEnumerable<Prato> BuscarTudoComTipo()
        {
            using (DataContexto contexto = new DataContexto())
            {
                return contexto.Pratos.Include("Tipo").ToList();
            }
        }
    }
}
