using Ecommerce.DAL.Data.Context;
using Ecommerce.DAL.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Repos.GenericRepo
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly StoreContext _storeContext;
        public GenericRepo(StoreContext storeContext) 
        {
            _storeContext = storeContext;
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _storeContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _storeContext.Set<T>().FindAsync(id);
        }

        public async Task<T> GetEntityWithSpecification(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllDataAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).ToListAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> specification)
        {
            return SpecificationEvaluator<T>.GetQuery(_storeContext.Set<T>().AsQueryable(), specification);
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }
    }
}
