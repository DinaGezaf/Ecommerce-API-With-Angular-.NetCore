using AutoMapper;
using Ecommerce.BL.Dtos.Product;
using Ecommerce.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Helpers
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductReadDto>()
                .ForMember(d=>d.PictureUrl,o=>o.MapFrom<ProductURLResolver>());
        }
    }
}
