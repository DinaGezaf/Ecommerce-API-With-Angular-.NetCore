using AutoMapper;
using Ecommerce.BL.Dtos.Product;
using Ecommerce.BL.Helpers;
using Ecommerce.DAL;
using Ecommerce.DAL.Data.Context;
using Ecommerce.DAL.Data.Models;
using Ecommerce.DAL.Repos.GenericRepo;
using Ecommerce.DAL.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Managers.Product_Manager
{
    public class ProductManager:IProductManager
    {
        private readonly IProductRepo _productsRepo;
        private IGenericRepo<Product> _productRepo;
        private readonly IMapper _mapper;
        public ProductManager(IProductRepo productsRepo, IGenericRepo<Product> productRepo, IMapper mapper)
        {
            _productsRepo = productsRepo;
            _productRepo = productRepo;
            _mapper = mapper;
        }
        public async Task<Pagination<ProductReadDto>> GetAll(ProductSpecParams productSpecParams)
        {
            var specific = new ProductWithTypesAndBrandsSpecificaction(productSpecParams);
            var countSpec = new ProductWithFiltersForCount(productSpecParams);
            var totalItems = await _productRepo.CountAsync(countSpec);
            IReadOnlyList<Product> ProductsFromDB = await _productRepo.GetAllDataAsync(specific);
            var data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductReadDto>>(ProductsFromDB);
            Console.WriteLine(data);
            return new Pagination<ProductReadDto>(productSpecParams.PageIndex,productSpecParams.PageSize, totalItems, data);
           
        }
        public async Task<ProductReadDto> GetById(int id)
        {
            var specific = new ProductWithTypesAndBrandsSpecificaction(id);
            var ProductFromDB = await _productRepo.GetEntityWithSpecification(specific);
            if (ProductFromDB is null)
            {
                return null;
            }
            return _mapper.Map<Product, ProductReadDto>(ProductFromDB);
        }
        public IEnumerable<ProductBrandReadDto> GetAllProductBrands()
        {
            IEnumerable<ProductBrand> ProductsFromDB = _productsRepo.GetProductBrands();

            return ProductsFromDB.Select(d => new ProductBrandReadDto
            {
                Id = d.Id,
                Name = d.Name
            });
        }
        public IEnumerable<ProductTypeReadDto> GetAllProductTypes()
        {
            IEnumerable<ProductType> ProductsFromDB = _productsRepo.GetProductTypes();

            return ProductsFromDB.Select(d => new ProductTypeReadDto
            {
                Id = d.Id,
                Name = d.Name
            });
        }
    }
}
