using AutoMapper;
using Sample.Core.Recipes.Data.Entities;

namespace Sample.Core.Recipes.Application.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, Index.Result.Customer>();
        }
    }
}