
using DBO_DAL.Identity;
using Microsoft.AspNetCore.Identity;

namespace PcAssemblyAssistant.AppStart
{
    /// <summary>
    /// class for role initialization
    /// </summary>
    public class RoleInitializer
    {
        /// <summary>
        /// role initializer
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        /// <returns></returns>
        public static async Task InitializerAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string paswword = "Aa12345$";

            if (await roleManager.FindByNameAsync("admin") == null)
                await roleManager.CreateAsync(new IdentityRole("admin"));
            if (await roleManager.FindByNameAsync("user") == null)
                await roleManager.CreateAsync(new IdentityRole("user"));

            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                User admin = new User
                {
                    Email = adminEmail,
                    UserName = adminEmail,
                    FullName = adminEmail
                };

                var result = await userManager.CreateAsync(admin, paswword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                    await userManager.AddToRoleAsync(admin, "user");
                }
            }
        }
    }
}
