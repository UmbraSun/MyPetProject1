using DBO.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PcAssemblyAssistant.DbContet
{
    /// <summary>
    /// MSSQL DbContext
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        /// <summary>
        /// Model builder
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var userEntity = builder.Entity<User>();
            userEntity.HasIndex(x => x.Email).IsUnique();
        }
    }
}
