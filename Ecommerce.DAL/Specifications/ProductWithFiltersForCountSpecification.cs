using Ecommerce.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Specifications
{
    public class ProductWithFiltersForCount:BaseSpecification<Product>
    {
        public ProductWithFiltersForCount(ProductSpecParams productSpecParams)
            :base(x=>
            (string.IsNullOrEmpty(productSpecParams.Search) || x.Title.ToLower().Contains(productSpecParams.Search)) &&
            (!productSpecParams.BrandId.HasValue || x.ProductBrandId == productSpecParams.BrandId)&&
            (!productSpecParams.TypeId.HasValue || x.ProductTypeId == productSpecParams.TypeId)
            )
        {
            
        }
    }
}
