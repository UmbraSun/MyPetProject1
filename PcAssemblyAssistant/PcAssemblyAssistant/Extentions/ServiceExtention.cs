using BLL.Infrastructure;
using DAL.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using DAL.DbContext;
using System.Reflection;
using System.Text;
using DAL.Interfaces;
using DAL.UnitOfWork;
using BLL.Interfaces;
using BLL.Services;

namespace PcAssemblyAssistant.Extensions
{
    /// <summary>
    /// class for service extention
    /// </summary>
    public static class ServiceExtention
    {
        /// <summary>
        /// IServiceCollection extention 
        /// </summary>
        /// <param name="collection">extention for this</param>
        /// <param name="configuration">application configuraion</param>
        public static void AddServiceExt(this IServiceCollection collection,
            ConfigurationManager configuration)
        {
            collection.AddControllers();
            // mapper
            collection.AddAutoMapper(typeof(AutoMapperProfileBLL));
            // db context
            collection.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                // Performs repeated requests to the database after a failure(Connection Resilience)
                opt => opt.EnableRetryOnFailure()));
            // identity and token provider
            collection.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            // Unit of Work
            collection.AddScoped<IUnitOfWork, UnitOfWork>();
            // Scoped
            collection.AddScoped<ICPUService, CPUService>();
            // authentication with jwt and jwt settings
            collection.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,

                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                };
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            collection.AddEndpointsApiExplorer();
            collection.AddSwaggerGen(options =>
            {
                options.DescribeAllParametersInCamelCase();
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "bearer",
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    },
                });
                options.CustomSchemaIds(t => t.FullName?.Replace("+", "."));
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });
        }
    }
}
