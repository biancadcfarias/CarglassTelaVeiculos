using Carglass.TI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carglass.TI.Domain.Contracts.Repositories
{
    public interface IRepository<TEntity> where TEntity: Entity
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);

        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> GetAsync(int id);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
