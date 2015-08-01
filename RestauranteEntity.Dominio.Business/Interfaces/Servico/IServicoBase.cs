using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteEntity.Dominio.Business.Interfaces.Servico
{
    public interface IServicoBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> BuscarTudo();
        TEntity BuscarPorId(int id);
        void Inserir(TEntity obj);
        void Atualizar(TEntity obj);
        void Deletar(TEntity obj);
    }
}
