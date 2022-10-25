using DAL.Entities;
using DAL.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.DbContext
{
    /// <summary>
    /// MSSQL DbContext
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Country> Countries { get; set; }

        #region CPU
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<CPUCoreAndArchitecture> CPUCoreAndArchitectures { get; set; }
        public DbSet<CPUFrequencyAndOverclockingCapability> CPUFrequencyAndOverclockingCapabilities { get; set; }
        public DbSet<CPUGeneralParametrs> CPUGeneralParametrs { get; set; }
        public DbSet<CPUGraphicsCore> CPUGraphicsCores { get; set; }
        public DbSet<CPURAMoptions> CPURAMoptions { get; set; }
        public DbSet<CPUThermalCharacteristicks> CPUThermalCharacteristicks { get; set; }
        #endregion

        #region Motherboard
        public DbSet<MB> MBs { get; set; }
        public DbSet<MbCPUandChipset> MbCPUandChipsets { get; set; }
        public DbSet<MBAudio> MBAudios { get; set; }
        public DbSet<MBBackPanel> MBBackPanels { get; set; }
        public DbSet<MBCollingAndPower> MBCollingAndPowers { get; set; }
        public DbSet<MBExpensionSlots> MBExpensionSlots { get; set; }
        public DbSet<MBFormFactor> MBFormFactor { get; set; }
        public DbSet<MBInternalConnectors> MBInternalConnectors { get; set; }
        public DbSet<MBRAM> MBRAMs { get; set; }
        public DbSet<MBStorageDevice> MBStorageDevices { get; set; }
        public DbSet<MBWeb> MBWebs { get; set; }
        #endregion

        #region GPU
        public DbSet<GPU> GPU { get; set; }
        public DbSet<GPUConnection> GPUConnections { get; set; }
        public DbSet<GPUCoolingSystem> GPUCoolingSystems { get; set; }
        public DbSet<GPUGeneralParametrs> GPUGeneralParametrs { get; set; }
        public DbSet<GPUImageOutput> GPUImageOutputs { get; set; }
        public DbSet<GPUVideoMemorySpecific> GPUVideoMemorySpecific { get; set; }
        public DbSet<GPUVideoProcessorSpecific> GPUVideoProcessorSpecifics { get; set; }
        #endregion

        #region RAM
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<RAMKitVolumeAndComposition> KitVolumeAndCompositions { get; set; }
        public DbSet<RAMPerformance> RAMPerformances { get; set; }
        public DbSet<RAMTimings> RAMTimings { get; set; }
        #endregion

        #region HDD
        public DbSet<HDD> HDDs { get; set; }
        public DbSet<HDDAdditionally> HDDAdditionallies { get; set; }
        public DbSet<HDDMechanicsAndReliability> HDDMechanicsAndReliabilities { get; set; }
        public DbSet<HDDStorageDevice> HDDStorageDevices { get; set; }
        #endregion

        #region SSD
        public DbSet<SSD> SSDs { get; set; }
        public DbSet<SSDMainCharacteristics> SSDMainCharacteristics { get; set; }
        public DbSet<SSDSpeedAndPowerConsumption> SSDSpeedAndPowerConsumptions { get; set; }
        #endregion

        #region PS
        public DbSet<PS> PSs { get; set; }
        public DbSet<PSCablesAndConnectors> PSCablesAndConnectors { get; set; }
        public DbSet<PSCertification> PSCertifications { get; set; }
        public DbSet<PSCoolingSystem> PSCoolingSystems { get; set; }
        public DbSet<PSElectricalParametrs> PSElectricalParametrs { get; set; }
        #endregion

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
            cpu.HasOne(x => x.CoreAndArchitecture).WithMany(x => x.CPU);
            cpu.HasOne(x => x.FrequencyAndOverclockingCapability).WithMany(x => x.CPU);
            cpu.HasOne(x => x.Parametrs).WithMany(x => x.CPU);
            cpu.HasOne(x => x.GPU).WithMany(x => x.CPU);
            cpu.HasOne(x => x.RAMoptions).WithMany(x => x.CPU);
            cpu.HasOne(x => x.ThermalCharacteristicks).WithMany(x => x.CPU);
            cpu.HasOne(x => x.Country);

            var mb = builder.Entity<MB>();
            mb.HasIndex(x => x.Name).IsUnique();
            mb.HasOne(x => x.MBAudio).WithMany(x => x.MB);
            mb.HasOne(x => x.MBBackPanel).WithMany(x => x.MB);
            mb.HasOne(x => x.MBCollingAndPower).WithMany(x => x.MB);
            mb.HasOne(x => x.MbCPUandChipset).WithMany(x => x.MB);
            mb.HasOne(x => x.MBExpensionSlots).WithMany(x => x.MB);
            mb.HasOne(x => x.MBFormFactor).WithMany(x => x.MB);
            mb.HasOne(x => x.MBInternalConnectors).WithMany(x => x.MB);
            mb.HasOne(x => x.MBStorageDevice).WithMany(x => x.MB);
            mb.HasOne(x => x.MBRAM).WithMany(x => x.MB);
            mb.HasOne(x => x.MBWeb).WithMany(x => x.MB);
            mb.HasOne(x => x.Country);

            var GPU = builder.Entity<GPU>();
            GPU.HasIndex(x => x.Name).IsUnique();
            GPU.HasOne(x => x.GPUConnection).WithMany(x => x.GPU);
            GPU.HasOne(x => x.GPUGeneralParametrs).WithMany(x => x.GPU);
            GPU.HasOne(x => x.GPUVideoProcessorSpecific).WithMany(x => x.GPU);
            GPU.HasOne(x => x.GPUCoolingSystem).WithMany(x => x.GPU);
            GPU.HasOne(x => x.GPUImageOutput).WithMany(x => x.GPU);
            GPU.HasOne(x => x.GPUImageOutput).WithMany(x => x.GPU);
            GPU.HasOne(x => x.GPUVideoMemorySpecific).WithMany(x => x.GPU);
            GPU.HasOne(x => x.GPUVideoProcessorSpecific).WithMany(x => x.GPU);

            var RAM = builder.Entity<RAM>();
            RAM.HasIndex(x => x.Name).IsUnique();
            RAM.HasOne(x => x.RAMKitVolumeAndComposition).WithMany(x => x.RAM);
            RAM.HasOne(x => x.RAMPerformance).WithMany(x => x.RAM);
            RAM.HasOne(x => x.RAMTimings).WithMany(x => x.RAM);

            var HDD = builder.Entity<HDD>();
            HDD.HasIndex(x => x.Name).IsUnique();
            HDD.HasOne(x => x.HDDMechanicsAndReliability).WithMany(x => x.HDD);
            HDD.HasOne(x => x.HDDStorageDevice).WithMany(x => x.HDD);
            HDD.HasOne(x => x.HDDAdditionally).WithMany(x => x.HDD);

            var SSD = builder.Entity<SSD>();
            SSD.HasIndex(x => x.Name).IsUnique();
            SSD.HasOne(x => x.SSDMainCharacteristics).WithMany(x => x.SSD);
            SSD.HasOne(x => x.SSDSpeedAndPowerConsumption).WithMany(x => x.SSD);

            var PS = builder.Entity<PS>();
            PS.HasIndex(x => x.Name).IsUnique();
            PS.HasOne(x => x.PSCablesAndConnectors).WithMany(x => x.PS);
            PS.HasOne(x => x.PSCertification).WithMany(x => x.PS);
            PS.HasOne(x => x.PSCoolingSystem).WithMany(x => x.PS);
            PS.HasOne(x => x.PSElectricalParametrs).WithMany(x => x.PS);
        }
    }
}
