using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PcAssemblyAssistant.AppStart;
using DAL.DbContext;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace PcAssemblyAssistant.Extentions
{
    /// <summary>
    /// class for pipeline extention
    /// </summary>
    public static class PipelineExtention
    {
        /// <summary>
        /// pipeline extention
        /// </summary>
        /// <param name="app">this app</param>
        /// <returns></returns>
        public static async Task PipelineExt(this WebApplication app)
        {
            // database initializer
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                await db.Database.EnsureCreatedAsync();
                await db.Database.MigrateAsync();
            }
            // role and user initializer
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var userManager = services.GetRequiredService<UserManager<User>>();
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

                    await RoleInitializer.InitializerAsync(userManager, roleManager);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occured while seeding the database");
                    return;
                }
            }
            // development pipeline (swagger and etc.)
            if (app.Environment.IsDevelopment())
            {
                #region swagger
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.DisplayRequestDuration();
                    options.OAuthAppName("Swagger");
                    options.DefaultModelRendering(ModelRendering.Example);
                    options.DefaultModelsExpandDepth(-1);
                    options.DisplayOperationId();
                    options.DocExpansion(DocExpansion.None);
                    options.EnableDeepLinking();
                    options.EnableFilter();
                    options.ShowExtensions();
                    options.InjectStylesheet("/swagger-ui/swagger-custom-styles.css");
                    options.InjectJavascript("/swagger-ui/swagger-custom-script.js", "text/javascript");
                });
                #endregion
            }
            // https redirect
            app.UseHttpsRedirection();
            // static files
            app.UseStaticFiles();
            // authentication and authorization pipeline
            app.UseAuthentication();
            app.UseAuthorization();
            // map pipeline
            app.MapControllers();
        }
    }
}
