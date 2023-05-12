using Ecommerce.BL.Dtos.Product;
using Ecommerce.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.BL.Helpers
{
    public class ProductURLResolver : IValueResolver<Product, ProductReadDto, string>
    {
        private readonly IConfiguration _configuration;
        public ProductURLResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Resolve(Product source, ProductReadDto destination, string destMember, ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.PictureUrl))
            {
                //return _configuration["ApiUrl"] + source.PictureUrl;
                return source.PictureUrl;

            }
            return null;
        }
    }
}
