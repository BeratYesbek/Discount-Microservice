using AutoMapper;
using GraphQL.GraphQL.Categories;
using GraphQL.GraphQL.Coupons;
using GraphQL.Models;

namespace GraphQL.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, AddCategoryInput>().ReverseMap();
        }
    }
}
