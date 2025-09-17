using API.DTOs;
using AutoMapper;
using Models.Entities;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API.Mapping;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<ProductCreateDto, Product>()
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest => dest.ProductCategories, opt => opt.MapFrom(src =>
                src.CategoryIds.Select(id => new ProductCategories { CategoryId = id }).ToList()));

        CreateMap<ProductUpdateDto, Product>()
            .ForMember(dest => dest.ProductCategories, opt => opt.Ignore());

        CreateMap<Product, ProductReadDto>()
            .ForMember(dest => dest.CategoryNames, opt => opt.MapFrom(src =>
                src.ProductCategories.Select(pc => pc.Category.CategoryName).ToList()));
    }
}
