using Ecommerce.BL.Dtos.Product;
using Ecommerce.BL.Helpers;
using Ecommerce.DAL.Data.Models;
using Ecommerce.DAL.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL
{
    public interface IProductManager
    {
        public  Task<Pagination<ProductReadDto>> GetAll(ProductSpecParams productSpecParams);
        public  Task<ProductReadDto> GetById(int id);
        public IEnumerable<ProductBrandReadDto> GetAllProductBrands();
        public IEnumerable<ProductTypeReadDto> GetAllProductTypes();
    }
}
