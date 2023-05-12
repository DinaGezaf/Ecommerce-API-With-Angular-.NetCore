using Ecommerce.DAL.Data.Context;
using Ecommerce.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL
{
    public class ProductRepo:IProductRepo
    {
        private readonly StoreContext _context;
        public ProductRepo(StoreContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAll()
        {
            return _context.Set<Product>().Include(p=>p.ProductBrand).Include(p=>p.ProductType).ToList();
        }

        public Product? GetById(int id)
        {
            return _context.Set<Product>().Include(p => p.ProductBrand).Include(p => p.ProductType).FirstOrDefault(p=>p.Id==id);
        }
        public void Add(Product entity)
        {
            _context.Add(entity);
        }
        public void Update(Product entity)
        {
            _context.Update(entity);
        }
        public void Delete(Product entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<ProductBrand> GetProductBrands()
        {
            return _context.ProductBrands.ToList();
        }

        public IEnumerable<ProductType> GetProductTypes()
        {
            return _context.ProductTypes.ToList();

        }
    }
}
