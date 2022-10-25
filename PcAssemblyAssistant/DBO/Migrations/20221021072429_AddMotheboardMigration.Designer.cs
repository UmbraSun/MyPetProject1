﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DAL.DbContext;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221021072429_AddMotheboardMigration")]
    partial class AddMotheboardMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DBO_DAL.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CoreAndArchitectureId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FrequencyAndOverclockingCapabilityId")
                        .HasColumnType("int");

                    b.Property<int?>("GPUId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ParametrsId")
                        .HasColumnType("int");

                    b.Property<int?>("RAMoptionsId")
                        .HasColumnType("int");

                    b.Property<int?>("ThermalCharacteristicksId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoreAndArchitectureId");

                    b.HasIndex("CountryId");

                    b.HasIndex("FrequencyAndOverclockingCapabilityId");

                    b.HasIndex("GPUId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ParametrsId");

                    b.HasIndex("RAMoptionsId");

                    b.HasIndex("ThermalCharacteristicksId");

                    b.ToTable("CPUs");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUCoreAndArchitecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Core")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("L2CacheSize")
                        .HasColumnType("int");

                    b.Property<int?>("L3CacheSize")
                        .HasColumnType("int");

                    b.Property<int>("MaxNumberOfThread")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfCores")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfEfficientCores")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPerformanceCores")
                        .HasColumnType("int");

                    b.Property<string>("ProcessTechnology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UnitOfL2CacheSize")
                        .HasColumnType("int");

                    b.Property<int?>("UnitOfL3CacheSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CPUCoreAndArchitectures");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUFrequencyAndOverclockingCapability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("FreeMultiplier")
                        .HasColumnType("bit");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<int?>("FrequencyOfEfficientCores")
                        .HasColumnType("int");

                    b.Property<int?>("MaxFrequencyInTurbo")
                        .HasColumnType("int");

                    b.Property<int?>("MaxFrequencyTurboOfEfficientCores")
                        .HasColumnType("int");

                    b.Property<int>("UnitFrequecy")
                        .HasColumnType("int");

                    b.Property<int?>("UnitFrequencyOfEfficientCores")
                        .HasColumnType("int");

                    b.Property<int?>("UnitMaxFrequencyInTurbo")
                        .HasColumnType("int");

                    b.Property<int?>("UnitMaxFrequencyTurboOfEfficientCores")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CPUFrequencyAndOverclockingCapabilities");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUGeneralParametrs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RealiseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Socket")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CPUGeneralParametrs");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUGraphicsCore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExecutiveBlocks")
                        .HasColumnType("int");

                    b.Property<int>("GPUCoreFreqency")
                        .HasColumnType("int");

                    b.Property<string>("GPUModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitOfGPUCoreFreqency")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CPUGraphicsCores");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPURAMoptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MaxSuppMemory")
                        .HasColumnType("int");

                    b.Property<int>("MaximumRAMfrequency")
                        .HasColumnType("int");

                    b.Property<string>("MemoryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfMemoryChanel")
                        .HasColumnType("int");

                    b.Property<int>("UnitOfMaxSuppMemory")
                        .HasColumnType("int");

                    b.Property<int>("UnitOfMaximumRAMfrequency")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CPURAMoptions");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUThermalCharacteristicks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MaxCPUtemprature")
                        .HasColumnType("int");

                    b.Property<int>("TDP")
                        .HasColumnType("int");

                    b.Property<int>("UnitOfTDP")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CPUThermalCharacteristicks");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MBAudioId")
                        .HasColumnType("int");

                    b.Property<int?>("MBBackPanelId")
                        .HasColumnType("int");

                    b.Property<int?>("MBCollingAndPowerId")
                        .HasColumnType("int");

                    b.Property<int?>("MBExpensionSlotsId")
                        .HasColumnType("int");

                    b.Property<int?>("MBFormFactorId")
                        .HasColumnType("int");

                    b.Property<int?>("MBInternalConnectorsId")
                        .HasColumnType("int");

                    b.Property<int?>("MBRAMId")
                        .HasColumnType("int");

                    b.Property<int?>("MBStorageDeviceId")
                        .HasColumnType("int");

                    b.Property<int?>("MBWebId")
                        .HasColumnType("int");

                    b.Property<int?>("MbCPUandChipsetId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("MBAudioId");

                    b.HasIndex("MBBackPanelId");

                    b.HasIndex("MBCollingAndPowerId");

                    b.HasIndex("MBExpensionSlotsId");

                    b.HasIndex("MBFormFactorId");

                    b.HasIndex("MBInternalConnectorsId");

                    b.HasIndex("MBRAMId");

                    b.HasIndex("MBStorageDeviceId");

                    b.HasIndex("MBWebId");

                    b.HasIndex("MbCPUandChipsetId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("MBs");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBAudio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SouncAdapterChipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SoundScheme")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MBAudios");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBBackPanel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CountAndTypeUSB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountOfAnalogAudioJacks")
                        .HasColumnType("int");

                    b.Property<int?>("CountOfNetworkPorts")
                        .HasColumnType("int");

                    b.Property<string>("DigitalAudioPorts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoOutputs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MBBackPanels");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBCollingAndPower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ActiveCooling")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPUPowerConnector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainPowerConnctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassiveCooling")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PowerPhases")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MBCollingAndPowers");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MbCPUandChipset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPUStirpes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chipset")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Socket")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MbCPUandChipsets");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBExpensionSlots", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountOfPCIExX16Slots")
                        .HasColumnType("int");

                    b.Property<int?>("CountOfPCIExX1Slots")
                        .HasColumnType("int");

                    b.Property<int?>("CountOfPCIorCrossfire")
                        .HasColumnType("int");

                    b.Property<string>("PCIExpressVersion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupportedPCIorCrossfire")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MBExpensionSlots");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBFormFactor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FormFactor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MBFormFactor");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBInternalConnectors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPUCoolerPowerConnector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FanConnectorsPin3")
                        .HasColumnType("int");

                    b.Property<int?>("FanConnectorsPin4")
                        .HasColumnType("int");

                    b.Property<string>("InternalUSBConnectors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LEDConnectorPin3")
                        .HasColumnType("int");

                    b.Property<int?>("LEDConnectorPin4")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MBInternalConnectors");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBRAM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountOfRAMChannel")
                        .HasColumnType("int");

                    b.Property<int>("MaxRAMFrequency")
                        .HasColumnType("int");

                    b.Property<int>("MaximumMemory")
                        .HasColumnType("int");

                    b.Property<string>("RAMFormFactor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAMType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SlotsCount")
                        .HasColumnType("int");

                    b.Property<int>("UnitMaxRAMFrequency")
                        .HasColumnType("int");

                    b.Property<int>("UnitOfMaxMemory")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MBRAMs");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBStorageDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountOfM2")
                        .HasColumnType("int");

                    b.Property<int>("CountOfPortsSATA")
                        .HasColumnType("int");

                    b.Property<string>("M2Connectors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SupportedNVME")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MBStorageDevices");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBWeb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bluetooth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuiltInWifiAdapter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetAdapterChipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetAdapterSpeed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WiFiController")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MBWebs");
                });

            modelBuilder.Entity("DBO_DAL.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPU", b =>
                {
                    b.HasOne("DBO_DAL.Entities.CPUCoreAndArchitecture", "CoreAndArchitecture")
                        .WithMany("CPU")
                        .HasForeignKey("CoreAndArchitectureId");

                    b.HasOne("DBO_DAL.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("DBO_DAL.Entities.CPUFrequencyAndOverclockingCapability", "FrequencyAndOverclockingCapability")
                        .WithMany("CPU")
                        .HasForeignKey("FrequencyAndOverclockingCapabilityId");

                    b.HasOne("DBO_DAL.Entities.CPUGraphicsCore", "GPU")
                        .WithMany("CPU")
                        .HasForeignKey("GPUId");

                    b.HasOne("DBO_DAL.Entities.CPUGeneralParametrs", "Parametrs")
                        .WithMany("CPU")
                        .HasForeignKey("ParametrsId");

                    b.HasOne("DBO_DAL.Entities.CPURAMoptions", "RAMoptions")
                        .WithMany("CPU")
                        .HasForeignKey("RAMoptionsId");

                    b.HasOne("DBO_DAL.Entities.CPUThermalCharacteristicks", "ThermalCharacteristicks")
                        .WithMany("CPU")
                        .HasForeignKey("ThermalCharacteristicksId");

                    b.Navigation("CoreAndArchitecture");

                    b.Navigation("Country");

                    b.Navigation("FrequencyAndOverclockingCapability");

                    b.Navigation("GPU");

                    b.Navigation("Parametrs");

                    b.Navigation("RAMoptions");

                    b.Navigation("ThermalCharacteristicks");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MB", b =>
                {
                    b.HasOne("DBO_DAL.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("DBO_DAL.Entities.MBAudio", "MBAudio")
                        .WithMany("MB")
                        .HasForeignKey("MBAudioId");

                    b.HasOne("DBO_DAL.Entities.MBBackPanel", "MBBackPanel")
                        .WithMany("MB")
                        .HasForeignKey("MBBackPanelId");

                    b.HasOne("DBO_DAL.Entities.MBCollingAndPower", "MBCollingAndPower")
                        .WithMany("MB")
                        .HasForeignKey("MBCollingAndPowerId");

                    b.HasOne("DBO_DAL.Entities.MBExpensionSlots", "MBExpensionSlots")
                        .WithMany("MB")
                        .HasForeignKey("MBExpensionSlotsId");

                    b.HasOne("DBO_DAL.Entities.MBFormFactor", "MBFormFactor")
                        .WithMany("MB")
                        .HasForeignKey("MBFormFactorId");

                    b.HasOne("DBO_DAL.Entities.MBInternalConnectors", "MBInternalConnectors")
                        .WithMany("MB")
                        .HasForeignKey("MBInternalConnectorsId");

                    b.HasOne("DBO_DAL.Entities.MBRAM", "MBRAM")
                        .WithMany("MB")
                        .HasForeignKey("MBRAMId");

                    b.HasOne("DBO_DAL.Entities.MBStorageDevice", "MBStorageDevice")
                        .WithMany("MB")
                        .HasForeignKey("MBStorageDeviceId");

                    b.HasOne("DBO_DAL.Entities.MBWeb", "MBWeb")
                        .WithMany("MB")
                        .HasForeignKey("MBWebId");

                    b.HasOne("DBO_DAL.Entities.MbCPUandChipset", "MbCPUandChipset")
                        .WithMany("MB")
                        .HasForeignKey("MbCPUandChipsetId");

                    b.Navigation("Country");

                    b.Navigation("MBAudio");

                    b.Navigation("MBBackPanel");

                    b.Navigation("MBCollingAndPower");

                    b.Navigation("MBExpensionSlots");

                    b.Navigation("MBFormFactor");

                    b.Navigation("MBInternalConnectors");

                    b.Navigation("MBRAM");

                    b.Navigation("MBStorageDevice");

                    b.Navigation("MBWeb");

                    b.Navigation("MbCPUandChipset");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DBO_DAL.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DBO_DAL.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBO_DAL.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DBO_DAL.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUCoreAndArchitecture", b =>
                {
                    b.Navigation("CPU");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUFrequencyAndOverclockingCapability", b =>
                {
                    b.Navigation("CPU");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUGeneralParametrs", b =>
                {
                    b.Navigation("CPU");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUGraphicsCore", b =>
                {
                    b.Navigation("CPU");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPURAMoptions", b =>
                {
                    b.Navigation("CPU");
                });

            modelBuilder.Entity("DBO_DAL.Entities.CPUThermalCharacteristicks", b =>
                {
                    b.Navigation("CPU");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBAudio", b =>
                {
                    b.Navigation("MB");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBBackPanel", b =>
                {
                    b.Navigation("MB");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBCollingAndPower", b =>
                {
                    b.Navigation("MB");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MbCPUandChipset", b =>
                {
                    b.Navigation("MB");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBExpensionSlots", b =>
                {
                    b.Navigation("MB");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBFormFactor", b =>
                {
                    b.Navigation("MB");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBInternalConnectors", b =>
                {
                    b.Navigation("MB");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBRAM", b =>
                {
                    b.Navigation("MB");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBStorageDevice", b =>
                {
                    b.Navigation("MB");
                });

            modelBuilder.Entity("DBO_DAL.Entities.MBWeb", b =>
                {
                    b.Navigation("MB");
                });
#pragma warning restore 612, 618
        }
    }
}
