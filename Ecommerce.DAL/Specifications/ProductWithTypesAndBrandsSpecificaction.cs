using Ecommerce.DAL.Data.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Specifications
{
    public class ProductWithTypesAndBrandsSpecificaction : BaseSpecification<Product>
    {
        public ProductWithTypesAndBrandsSpecificaction(ProductSpecParams productSpecParams)
            : base(x =>
            (string.IsNullOrEmpty(productSpecParams.Search) || x.Title.ToLower().Contains(productSpecParams.Search)) &&
            (!productSpecParams.BrandId.HasValue || x.ProductBrandId==productSpecParams.BrandId)&&
            (!productSpecParams.TypeId.HasValue || x.ProductTypeId == productSpecParams.TypeId)) 
        {
            AddIncludes(x => x.ProductBrand);
            AddIncludes(x => x.ProductType);
            AddOrderBy(x => x.Title);
            ApplyPaging(productSpecParams.PageSize * (productSpecParams.PageIndex -1), productSpecParams.PageSize);

            if (!string.IsNullOrEmpty(productSpecParams.Sort))
            {
                switch(productSpecParams.Sort)
                {
                    case "PriceAsc":
                        AddOrderBy(p => p.Price); break;
                    case "PriceDesc":
                        AddOrderByDescending(p => p.Price); break;
                    default:
                        AddOrderBy(p => p.Title); break;

                }
            }
        }
        public ProductWithTypesAndBrandsSpecificaction(int id):base(x=>x.Id==id)
        {
            AddIncludes(x => x.ProductBrand);
            AddIncludes(x => x.ProductType);
        }
    }
}
