using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteEntity;
namespace RestauranteEntity.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntity>:IRepositorioBase<TEntity> where TEntity:class
    {
        public IEnumerable<TEntity> BuscarTudo()
        {
            using (DataContexto contexto = new DataContexto())
            {
                return contexto.Set<TEntity>().ToList();
            }
        }

        public TEntity BuscarPorId(int id)
        {
            using (DataContexto contexto = new DataContexto())
            {
                return contexto.Set<TEntity>().Find(id);
            }
        }

        public void Inserir(TEntity obj)
        {
            using (DataContexto contexto = new DataContexto())
            {
                contexto.Set<TEntity>().Add(obj);
                contexto.SaveChanges();
            }
        }

        public void Atualizar(TEntity obj)
        {
            using (DataContexto contexto = new DataContexto())
            {
                contexto.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Deletar(TEntity obj)
        {
            using (DataContexto contexto = new DataContexto())
            {
                contexto.Entry(obj).State  = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();

            }
        }


     

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
