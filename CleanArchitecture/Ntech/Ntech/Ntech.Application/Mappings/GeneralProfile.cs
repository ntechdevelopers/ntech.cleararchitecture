using Ntech.Application.Features.Products.Commands.CreateProduct;
using Ntech.Application.Features.Products.Queries.GetAllProducts;
using AutoMapper;
using Ntech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntech.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
