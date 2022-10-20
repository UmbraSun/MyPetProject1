using DBO_DAL.Entities;
using DBO_DAL.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PcAssemblyAssistant.DbContext
{
    /// <summary>
    /// MSSQL DbContext
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<CPUCoreAndArchitecture> CPUCoreAndArchitectures { get; set; }
        public DbSet<CPUFrequencyAndOverclockingCapability> CPUFrequencyAndOverclockingCapabilities { get; set; }
        public DbSet<CPUGeneralParametrs> CPUGeneralParametrs { get; set; }
        public DbSet<CPUGraphicsCore> CPUGraphicsCores { get; set; }
        public DbSet<CPURAMoptions> CPURAMoptions { get; set; }
        public DbSet<CPUThermalCharacteristicks> CPUThermalCharacteristicks { get; set; }

        /// <summary>
        /// Model builder
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var userEntity = builder.Entity<User>();
            userEntity.HasIndex(x => x.Email).IsUnique();

            var country = builder.Entity<Country>();
            country.HasIndex(x => x.Name).IsUnique();

            var cpu = builder.Entity<CPU>();
            cpu.HasIndex(x => x.Name).IsUnique();
            cpu.HasOne(x => x.CoreAndArchitecture);
            cpu.HasOne(x => x.FrequencyAndOverclockingCapability);
            cpu.HasOne(x => x.Parametrs);
            cpu.HasOne(x => x.GPU);
            cpu.HasOne(x => x.RAMoptions);
            cpu.HasOne(x => x.ThermalCharacteristicks);
            cpu.HasOne(x => x.Country);

            var cpuCoreAndArch = builder.Entity<CPUCoreAndArchitecture>();

            var cpuFrenqAndOverclock = builder.Entity<CPUFrequencyAndOverclockingCapability>();

            var cpuGeneralParams = builder.Entity<CPUGeneralParametrs>();

            var cpuGraphCore = builder.Entity<CPUGraphicsCore>();

            var cpuRAMopt = builder.Entity<CPURAMoptions>();

            var cpuThermalChar = builder.Entity<CPUThermalCharacteristicks>();
        }
    }
}
