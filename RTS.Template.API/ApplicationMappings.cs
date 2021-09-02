//-----------------------------------------------------------------------
// <copyright file="ApplicationMappings.cs" company="Real Technology Solutions">
//     Author: blindgarret
//     Copyright (c) 2020 Real Technology Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using AutoMapper;
using RTS.Template.API.Dtos;
using RTS.Template.DataModels.Models;

namespace RTS.Template.API
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
