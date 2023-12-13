using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;

namespace Business.Profiles;

public class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<CreateCategoryRequest, Category>();
        CreateMap<Category, CreatedCategoryResponse>();
    }
}


