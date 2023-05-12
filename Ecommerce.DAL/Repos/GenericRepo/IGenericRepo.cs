using Ecommerce.DAL.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Repos.GenericRepo
{
    public interface IGenericRepo<T>
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> GetEntityWithSpecification(ISpecification<T> specification);
        Task<IReadOnlyList<T>> GetAllDataAsync(ISpecification<T> specification);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}
