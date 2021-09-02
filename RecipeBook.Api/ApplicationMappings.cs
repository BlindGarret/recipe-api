using AutoMapper;
using RecipeBook.Api.Dtos;
using RecipeBook.DataModels.Models;

namespace RecipeBook.Api
{
    /// <summary>
    /// Automapper class for mapping application models to data transfer objects
    /// </summary>
    public static class ApplicationMappings
    {
        /// <summary>
        /// Configure the mappings defined
        /// </summary>
        public static void ConfigureMappings(IMapperConfigurationExpression m)
        {
            m.CreateMap<Store, StoreDto>().ReverseMap();
        }
    }
}
