using RestauranteEntity.Dominio.Business.Interfaces.Servico;
using RestauranteEntity.Infra.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteEntity.Dominio.Business
{
    public class ServicoBase<TEntity>: IServicoBase<TEntity> where TEntity:class
    {
        private readonly RepositorioBase<TEntity> _repositorio = new RepositorioBase<TEntity>(); 

        
        public IEnumerable<TEntity> BuscarTudo()
        {
            return _repositorio.BuscarTudo();
        }

        public TEntity BuscarPorId(int id)
        {
            return _repositorio.BuscarPorId(id);
        }

        public void Inserir(TEntity obj)
        {
            _repositorio.Inserir(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _repositorio.Atualizar(obj);
        }

        public void Deletar(TEntity obj)
        {
            _repositorio.Deletar(obj);
        }
    }
}
