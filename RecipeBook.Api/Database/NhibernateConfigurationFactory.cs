using System;
using System.Collections.Generic;
using System.Data;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;

namespace RecipeBook.Api.Database
{
    /// <summary>
    /// Factory used to build NHibernate configurations
    /// </summary>
    public static class NhibernateConfigurationFactory
    {
        /// <summary>
        /// Creates an NHibernate configuration
        /// </summary>
        /// <typeparam name="TDialect">NHibernate Dialect to use</typeparam>
        /// <typeparam name="TDriver">NHibernate Driver to use</typeparam>
        /// <param name="connectionString">Connection string for DB</param>
        /// <param name="types">A set of datamapping types</param>
        /// <param name="sqlInterceptor">Interceptor for SQL statements</param>
        /// <returns><see cref="Configuration"/></returns>
        public static Configuration Create<TDialect, TDriver>(string connectionString, IEnumerable<Type> types, IInterceptor sqlInterceptor = null)
            where TDialect : Dialect
            where TDriver : DriverBase
        {
            var config = new Configuration();
            config.DataBaseIntegration(dbi =>
            {
                dbi.Dialect<TDialect>();
                dbi.Driver<TDriver>();
                dbi.ConnectionProvider<DriverConnectionProvider>();
                dbi.ConnectionString = connectionString;
                dbi.IsolationLevel = IsolationLevel.ReadCommitted;
                dbi.Timeout = 60;
                dbi.LogSqlInConsole = true;
                dbi.LogFormattedSql = true;
            });

            var mapper = new ModelMapper();
            mapper.AddMappings(types);
            config.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());
            config.Interceptor = sqlInterceptor;

            return config;
        }
    }
}
