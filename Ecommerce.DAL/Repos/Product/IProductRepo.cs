using Ecommerce.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAll();
        public Product? GetById(int id);
        public IEnumerable<ProductBrand> GetProductBrands();
        public IEnumerable<ProductType> GetProductTypes();
        public void Add(Product entity);
        public void Update(Product entity);
        public void Delete(Product entity);
    }
}
