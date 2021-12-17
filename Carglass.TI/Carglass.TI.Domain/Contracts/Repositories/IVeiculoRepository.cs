using Carglass.TI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carglass.TI.Domain.Contracts.Repositories
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        IEnumerable<Veiculo> GetByName(string name);
        IEnumerable<Veiculo> GetWithMarca();
        
        
        Task<IEnumerable<Veiculo>> GetWithMarcaAsync();



    }
}
