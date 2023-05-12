using Ecommerce.BL;
using Ecommerce.BL.Dtos.Product;
using Ecommerce.BL.Helpers;
using Ecommerce.BL.Managers.Product_Manager;
using Ecommerce.DAL.Data.Context;
using Ecommerce.DAL.Data.Models;
using Ecommerce.DAL.Repos.GenericRepo;
using Ecommerce.DAL.Specifications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseAPIController
    {
        private IProductManager _productManager;
        private IGenericRepo<ProductBrand> _productBrandRepo;
        private IGenericRepo<ProductType> _productTypeRepo;
        private IGenericRepo<Product> _productRepo;
        public ProductController(IProductManager productManager,
            IGenericRepo<ProductBrand> productBrandRepo, IGenericRepo<ProductType> productTypeRepo,
            IGenericRepo<Product> productRepo)
        {
            _productManager= productManager;
            _productBrandRepo= productBrandRepo;
            _productTypeRepo= productTypeRepo;
            _productRepo= productRepo;
        }
        [HttpGet]
        public async Task<ActionResult<Pagination<ProductReadDto>>> GetAllProducts([FromQuery]ProductSpecParams productSpecParams)
        {

            Pagination < ProductReadDto > products = await _productManager.GetAll(productSpecParams);
            return Ok(products);
        }
        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<ProductReadDto>> GetProduct(int id)
        {
            var product = await _productManager.GetById(id);
            return Ok(product);
        }
        [HttpGet]
        [Route("Brands")]
        public async Task<ActionResult<IEnumerable<ProductBrandReadDto>>> GetProductBrands()
        {
            var productbrands = await _productBrandRepo.GetAllAsync();
            return Ok(productbrands);
        }
        [HttpGet]
        [Route("Types")]
        public async Task<ActionResult<ProductReadDto>> GetProductTypes()
        {
            var productTypes = await _productTypeRepo.GetAllAsync();
            return Ok(productTypes);
        }
    }
}
