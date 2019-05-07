using Microsoft.EntityFrameworkCore;
using StudentDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StudentDB.DAL
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private EstudanteContext _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(EstudanteContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async virtual Task<IEnumerable<TEntity>> Get(
                Expression<Func<TEntity, bool>> filter = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        // Part 3
        public virtual TEntity GetPorId(object id)
        {
            return _dbSet.Find(id);
        }

        public  virtual Task Inclui(TEntity entity)
        {
          return _dbSet.AddAsync(entity);
        }

        public virtual void Atualiza(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }


        public virtual void Exclui(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Exclui(entityToDelete);
        }

        public virtual void Exclui(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }

        public Task Salvar()
        {
           return _context.SaveChangesAsync();
        }
    }
}