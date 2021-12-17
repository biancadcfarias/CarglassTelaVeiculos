using Carglass.TI.Domain.Contracts.Repositories;
using Carglass.TI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carglass.TI.Data.EF.Repositories
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly StoreDataContext _ctx;

        public EFRepository(StoreDataContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TEntity> Get()
        {
            return _ctx.Set<TEntity>().ToList();
        }

        public TEntity Get(int id)
        {
            return _ctx.Set<TEntity>().Find(id);
        }


        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await _ctx.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _ctx.Set<TEntity>().FindAsync(id);
        }


        public void Add(TEntity entity)
        {
            _ctx.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _ctx.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _ctx.Set<TEntity>().Update(entity);
        }

        
    }
}
