using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StudentDB.DAL
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Atualiza(TEntity entityToUpdate);
        void Exclui(object id);
        void Exclui(TEntity entityToDelete);
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        TEntity GetPorId(object id);
        Task Inclui(TEntity entity);
        Task Salvar();
    }
}