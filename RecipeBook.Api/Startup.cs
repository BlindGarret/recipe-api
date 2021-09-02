using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;
using NSwag;
using NSwag.Generation.Processors.Security;
using RecipeBook.Api.Database;
using RecipeBook.DataMappings;

namespace RecipeBook.Api
{
    /// <summary>
    /// API Bootstrapping Class
    /// </summary>
    public class Startup
    {
        private static readonly string CorsName = "_CorsSetup";

        /// <summary>
        /// Constructor
        /// </summary>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// API Configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configure Services for API
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            // Setup DB
            var config = NhibernateConfigurationFactory.Create<MySQL57Dialect, MySqlDataDriver>(
                Configuration.GetConnectionString("DefaultConnection"),
                typeof(DataMappingsAssemblyTarget).Assembly.GetExportedTypes(),
                new SqlDebugOutputInterceptor());
            var sessionFactory = config.BuildSessionFactory();
            services.AddSingleton(sessionFactory);
            services.AddScoped(_ => sessionFactory.OpenSession());

            // Add Automapper
            services.AddAutoMapper(ApplicationMappings.ConfigureMappings);

            // Add Services
            this.RegisterServices(services);

            // Update Schema
            var schemaUpdate = new SchemaUpdate(config);
            schemaUpdate.Execute(false, true);

            services.AddCors(opts =>
            {
                // Todo: Properly specificy CORS
                opts.AddPolicy(name: CorsName,
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000", "capacitor://localhost", "http://localhost");
                        builder.WithHeaders("pragma", "cache-control", "expires", "content-type", "Authorization");
                    });
            });
            services.AddControllers();

            services.AddSwaggerDocument(c =>
            {
                c.DocumentProcessors.Add(new SecurityDefinitionAppender("JWT Token",
                    new OpenApiSecurityScheme
                    {
                        Type = OpenApiSecuritySchemeType.ApiKey,
                        Name = "Authorization",
                        Description = "Copy 'Bearer ' + valid JWT token into field",
                        In = OpenApiSecurityApiKeyLocation.Header
                    }));
                c.OperationProcessors.Add(new OperationSecurityScopeProcessor("JWT Token"));


                c.PostProcess = d =>
                {
                    d.Info.Version = "v1";
                    d.Info.Title = "Unnamed API";
                };
            });

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecret"])),
                    ValidateIssuer = true,
                    ValidIssuer = Configuration["JwtIssuer"],
                    ValidateAudience = false,
                    ValidateLifetime = true
                };
            });
        }

        /// <summary>
        /// Configures the HTTP Pipeline
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHttpsRedirection();
            }

            app.UseRouting();
            app.UseCors(CorsName);
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers().RequireCors(CorsName);
            });
        }

        /// <summary>
        /// Registers services with DI
        /// </summary>
        private void RegisterServices(IServiceCollection services)
        {
        }
    }
}
