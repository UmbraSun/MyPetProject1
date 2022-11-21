using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    public partial class AddSSDandPSMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUCoreAndArchitectures_CoreAndArchitectureId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUFrequencyAndOverclockingCapabilities_FrequencyAndOverclockingCapabilityId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUGeneralParametrs_ParametrsId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUGraphicsCores_GPUId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPURAMoptions_RAMoptionsId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUThermalCharacteristicks_ThermalCharacteristicksId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUConnections_GPUConnectionId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUCoolingSystems_GPUCoolingSystemId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUGeneralParametrs_GPUGeneralParametrsId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUImageOutputs_GPUImageOutputId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUVideoMemorySpecific_GPUVideoMemorySpecificId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUVideoProcessorSpecifics_GPUVideoProcessorSpecificId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDs_HDDAdditionallies_HDDAdditionallyId",
                table: "HDDs");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDs_HDDMechanicsAndReliabilities_HDDMechanicsAndReliabilityId",
                table: "HDDs");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDs_HDDStorageDevices_HDDStorageDeviceId",
                table: "HDDs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBAudios_MBAudioId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBBackPanels_MBBackPanelId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBCollingAndPowers_MBCollingAndPowerId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MbCPUandChipsets_MbCPUandChipsetId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBExpensionSlots_MBExpensionSlotsId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBFormFactor_MBFormFactorId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBInternalConnectors_MBInternalConnectorsId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBRAMs_MBRAMId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBStorageDevices_MBStorageDeviceId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBWebs_MBWebId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMs_KitVolumeAndCompositions_RAMKitVolumeAndCompositionId",
                table: "RAMs");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMs_RAMPerformances_RAMPerformanceId",
                table: "RAMs");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMs_RAMTimings_RAMTimingsId",
                table: "RAMs");

            migrationBuilder.AddColumn<int>(
                name: "UnitOfСonsumption",
                table: "MBCollingAndPowers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Сonsumption",
                table: "MBCollingAndPowers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitOfСonsumption",
                table: "KitVolumeAndCompositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Сonsumption",
                table: "KitVolumeAndCompositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitOfСonsumption",
                table: "HDDAdditionallies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Сonsumption",
                table: "HDDAdditionallies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitOfСonsumption",
                table: "GPUGeneralParametrs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Сonsumption",
                table: "GPUGeneralParametrs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TypeAndNumOfInstalledFans",
                table: "GPUCoolingSystems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LiquidCoolingRadiator",
                table: "GPUCoolingSystems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoolingType",
                table: "GPUCoolingSystems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "UnitOfСonsumption",
                table: "CPUGeneralParametrs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Сonsumption",
                table: "CPUGeneralParametrs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PSCablesAndConnectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainPowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUPowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPUPowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SATA15PinConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Molex4PinConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floppy4pinConnector = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSCablesAndConnectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PSCertifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Certificate80PLUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerFactorCorrection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProtectionTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSCertifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PSCoolingSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoolingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FanDiametrs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeedControl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSCoolingSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PSElectricalParametrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineCurrent12V = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineCurrent3V = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineCurrent5V = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandbyCurrent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineCurrentMinus12V = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainInputVoltageRange = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSElectricalParametrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SSDMainCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StorageCapacity = table.Column<int>(type: "int", nullable: false),
                    UnitOfStorageCapacity = table.Column<int>(type: "int", nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalInterface = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyM2Connector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NVMe = table.Column<bool>(type: "bit", nullable: false),
                    MemoryStructure = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSDMainCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SSDSpeedAndPowerConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxSequentialReadSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxSequentialWriteSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RandomReadSpeedOf4KBFiles = table.Column<int>(type: "int", nullable: false),
                    RandomWriteSpeedOf4KBFiles = table.Column<int>(type: "int", nullable: false),
                    EnergyConsumption = table.Column<int>(type: "int", nullable: false),
                    UnitEnergyConsumption = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSDSpeedAndPowerConsumptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PSs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    UnitOfCapacity = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    PSCablesAndConnectorsId = table.Column<int>(type: "int", nullable: true),
                    PSElectricalParametrsId = table.Column<int>(type: "int", nullable: true),
                    PSCoolingSystemId = table.Column<int>(type: "int", nullable: true),
                    PSCertificationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PSs_PSCablesAndConnectors_PSCablesAndConnectorsId",
                        column: x => x.PSCablesAndConnectorsId,
                        principalTable: "PSCablesAndConnectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PSs_PSCertifications_PSCertificationId",
                        column: x => x.PSCertificationId,
                        principalTable: "PSCertifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PSs_PSCoolingSystems_PSCoolingSystemId",
                        column: x => x.PSCoolingSystemId,
                        principalTable: "PSCoolingSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PSs_PSElectricalParametrs_PSElectricalParametrsId",
                        column: x => x.PSElectricalParametrsId,
                        principalTable: "PSElectricalParametrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SSDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SSDType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    SSDMainCharacteristicsId = table.Column<int>(type: "int", nullable: true),
                    SSDSpeedAndPowerConsumptionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SSDs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SSDs_SSDMainCharacteristics_SSDMainCharacteristicsId",
                        column: x => x.SSDMainCharacteristicsId,
                        principalTable: "SSDMainCharacteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSDs_SSDSpeedAndPowerConsumptions_SSDSpeedAndPowerConsumptionId",
                        column: x => x.SSDSpeedAndPowerConsumptionId,
                        principalTable: "SSDSpeedAndPowerConsumptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PSs_CountryId",
                table: "PSs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PSs_Name",
                table: "PSs",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PSs_PSCablesAndConnectorsId",
                table: "PSs",
                column: "PSCablesAndConnectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_PSs_PSCertificationId",
                table: "PSs",
                column: "PSCertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_PSs_PSCoolingSystemId",
                table: "PSs",
                column: "PSCoolingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_PSs_PSElectricalParametrsId",
                table: "PSs",
                column: "PSElectricalParametrsId");

            migrationBuilder.CreateIndex(
                name: "IX_SSDs_CountryId",
                table: "SSDs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SSDs_Name",
                table: "SSDs",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SSDs_SSDMainCharacteristicsId",
                table: "SSDs",
                column: "SSDMainCharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_SSDs_SSDSpeedAndPowerConsumptionId",
                table: "SSDs",
                column: "SSDSpeedAndPowerConsumptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUCoreAndArchitectures_CoreAndArchitectureId",
                table: "CPUs",
                column: "CoreAndArchitectureId",
                principalTable: "CPUCoreAndArchitectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUFrequencyAndOverclockingCapabilities_FrequencyAndOverclockingCapabilityId",
                table: "CPUs",
                column: "FrequencyAndOverclockingCapabilityId",
                principalTable: "CPUFrequencyAndOverclockingCapabilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUGeneralParametrs_ParametrsId",
                table: "CPUs",
                column: "ParametrsId",
                principalTable: "CPUGeneralParametrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUGraphicsCores_GPUId",
                table: "CPUs",
                column: "GPUId",
                principalTable: "CPUGraphicsCores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPURAMoptions_RAMoptionsId",
                table: "CPUs",
                column: "RAMoptionsId",
                principalTable: "CPURAMoptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUThermalCharacteristicks_ThermalCharacteristicksId",
                table: "CPUs",
                column: "ThermalCharacteristicksId",
                principalTable: "CPUThermalCharacteristicks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUConnections_GPUConnectionId",
                table: "GPU",
                column: "GPUConnectionId",
                principalTable: "GPUConnections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUCoolingSystems_GPUCoolingSystemId",
                table: "GPU",
                column: "GPUCoolingSystemId",
                principalTable: "GPUCoolingSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUGeneralParametrs_GPUGeneralParametrsId",
                table: "GPU",
                column: "GPUGeneralParametrsId",
                principalTable: "GPUGeneralParametrs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUImageOutputs_GPUImageOutputId",
                table: "GPU",
                column: "GPUImageOutputId",
                principalTable: "GPUImageOutputs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUVideoMemorySpecific_GPUVideoMemorySpecificId",
                table: "GPU",
                column: "GPUVideoMemorySpecificId",
                principalTable: "GPUVideoMemorySpecific",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUVideoProcessorSpecifics_GPUVideoProcessorSpecificId",
                table: "GPU",
                column: "GPUVideoProcessorSpecificId",
                principalTable: "GPUVideoProcessorSpecifics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDs_HDDAdditionallies_HDDAdditionallyId",
                table: "HDDs",
                column: "HDDAdditionallyId",
                principalTable: "HDDAdditionallies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDs_HDDMechanicsAndReliabilities_HDDMechanicsAndReliabilityId",
                table: "HDDs",
                column: "HDDMechanicsAndReliabilityId",
                principalTable: "HDDMechanicsAndReliabilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDDs_HDDStorageDevices_HDDStorageDeviceId",
                table: "HDDs",
                column: "HDDStorageDeviceId",
                principalTable: "HDDStorageDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBAudios_MBAudioId",
                table: "MBs",
                column: "MBAudioId",
                principalTable: "MBAudios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBBackPanels_MBBackPanelId",
                table: "MBs",
                column: "MBBackPanelId",
                principalTable: "MBBackPanels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBCollingAndPowers_MBCollingAndPowerId",
                table: "MBs",
                column: "MBCollingAndPowerId",
                principalTable: "MBCollingAndPowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MbCPUandChipsets_MbCPUandChipsetId",
                table: "MBs",
                column: "MbCPUandChipsetId",
                principalTable: "MbCPUandChipsets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBExpensionSlots_MBExpensionSlotsId",
                table: "MBs",
                column: "MBExpensionSlotsId",
                principalTable: "MBExpensionSlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBFormFactor_MBFormFactorId",
                table: "MBs",
                column: "MBFormFactorId",
                principalTable: "MBFormFactor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBInternalConnectors_MBInternalConnectorsId",
                table: "MBs",
                column: "MBInternalConnectorsId",
                principalTable: "MBInternalConnectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBRAMs_MBRAMId",
                table: "MBs",
                column: "MBRAMId",
                principalTable: "MBRAMs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBStorageDevices_MBStorageDeviceId",
                table: "MBs",
                column: "MBStorageDeviceId",
                principalTable: "MBStorageDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBWebs_MBWebId",
                table: "MBs",
                column: "MBWebId",
                principalTable: "MBWebs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMs_KitVolumeAndCompositions_RAMKitVolumeAndCompositionId",
                table: "RAMs",
                column: "RAMKitVolumeAndCompositionId",
                principalTable: "KitVolumeAndCompositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMs_RAMPerformances_RAMPerformanceId",
                table: "RAMs",
                column: "RAMPerformanceId",
                principalTable: "RAMPerformances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMs_RAMTimings_RAMTimingsId",
                table: "RAMs",
                column: "RAMTimingsId",
                principalTable: "RAMTimings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUCoreAndArchitectures_CoreAndArchitectureId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUFrequencyAndOverclockingCapabilities_FrequencyAndOverclockingCapabilityId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUGeneralParametrs_ParametrsId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUGraphicsCores_GPUId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPURAMoptions_RAMoptionsId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_CPUThermalCharacteristicks_ThermalCharacteristicksId",
                table: "CPUs");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUConnections_GPUConnectionId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUCoolingSystems_GPUCoolingSystemId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUGeneralParametrs_GPUGeneralParametrsId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUImageOutputs_GPUImageOutputId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUVideoMemorySpecific_GPUVideoMemorySpecificId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_GPUVideoProcessorSpecifics_GPUVideoProcessorSpecificId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDs_HDDAdditionallies_HDDAdditionallyId",
                table: "HDDs");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDs_HDDMechanicsAndReliabilities_HDDMechanicsAndReliabilityId",
                table: "HDDs");

            migrationBuilder.DropForeignKey(
                name: "FK_HDDs_HDDStorageDevices_HDDStorageDeviceId",
                table: "HDDs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBAudios_MBAudioId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBBackPanels_MBBackPanelId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBCollingAndPowers_MBCollingAndPowerId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MbCPUandChipsets_MbCPUandChipsetId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBExpensionSlots_MBExpensionSlotsId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBFormFactor_MBFormFactorId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBInternalConnectors_MBInternalConnectorsId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBRAMs_MBRAMId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBStorageDevices_MBStorageDeviceId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_MBs_MBWebs_MBWebId",
                table: "MBs");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMs_KitVolumeAndCompositions_RAMKitVolumeAndCompositionId",
                table: "RAMs");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMs_RAMPerformances_RAMPerformanceId",
                table: "RAMs");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMs_RAMTimings_RAMTimingsId",
                table: "RAMs");

            migrationBuilder.DropTable(
                name: "PSs");

            migrationBuilder.DropTable(
                name: "SSDs");

            migrationBuilder.DropTable(
                name: "PSCablesAndConnectors");

            migrationBuilder.DropTable(
                name: "PSCertifications");

            migrationBuilder.DropTable(
                name: "PSCoolingSystems");

            migrationBuilder.DropTable(
                name: "PSElectricalParametrs");

            migrationBuilder.DropTable(
                name: "SSDMainCharacteristics");

            migrationBuilder.DropTable(
                name: "SSDSpeedAndPowerConsumptions");

            migrationBuilder.DropColumn(
                name: "UnitOfСonsumption",
                table: "MBCollingAndPowers");

            migrationBuilder.DropColumn(
                name: "Сonsumption",
                table: "MBCollingAndPowers");

            migrationBuilder.DropColumn(
                name: "UnitOfСonsumption",
                table: "KitVolumeAndCompositions");

            migrationBuilder.DropColumn(
                name: "Сonsumption",
                table: "KitVolumeAndCompositions");

            migrationBuilder.DropColumn(
                name: "UnitOfСonsumption",
                table: "HDDAdditionallies");

            migrationBuilder.DropColumn(
                name: "Сonsumption",
                table: "HDDAdditionallies");

            migrationBuilder.DropColumn(
                name: "UnitOfСonsumption",
                table: "GPUGeneralParametrs");

            migrationBuilder.DropColumn(
                name: "Сonsumption",
                table: "GPUGeneralParametrs");

            migrationBuilder.DropColumn(
                name: "UnitOfСonsumption",
                table: "CPUGeneralParametrs");

            migrationBuilder.DropColumn(
                name: "Сonsumption",
                table: "CPUGeneralParametrs");

            migrationBuilder.AlterColumn<string>(
                name: "TypeAndNumOfInstalledFans",
                table: "GPUCoolingSystems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LiquidCoolingRadiator",
                table: "GPUCoolingSystems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoolingType",
                table: "GPUCoolingSystems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUCoreAndArchitectures_CoreAndArchitectureId",
                table: "CPUs",
                column: "CoreAndArchitectureId",
                principalTable: "CPUCoreAndArchitectures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUFrequencyAndOverclockingCapabilities_FrequencyAndOverclockingCapabilityId",
                table: "CPUs",
                column: "FrequencyAndOverclockingCapabilityId",
                principalTable: "CPUFrequencyAndOverclockingCapabilities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUGeneralParametrs_ParametrsId",
                table: "CPUs",
                column: "ParametrsId",
                principalTable: "CPUGeneralParametrs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUGraphicsCores_GPUId",
                table: "CPUs",
                column: "GPUId",
                principalTable: "CPUGraphicsCores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPURAMoptions_RAMoptionsId",
                table: "CPUs",
                column: "RAMoptionsId",
                principalTable: "CPURAMoptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_CPUThermalCharacteristicks_ThermalCharacteristicksId",
                table: "CPUs",
                column: "ThermalCharacteristicksId",
                principalTable: "CPUThermalCharacteristicks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUConnections_GPUConnectionId",
                table: "GPU",
                column: "GPUConnectionId",
                principalTable: "GPUConnections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUCoolingSystems_GPUCoolingSystemId",
                table: "GPU",
                column: "GPUCoolingSystemId",
                principalTable: "GPUCoolingSystems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUGeneralParametrs_GPUGeneralParametrsId",
                table: "GPU",
                column: "GPUGeneralParametrsId",
                principalTable: "GPUGeneralParametrs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUImageOutputs_GPUImageOutputId",
                table: "GPU",
                column: "GPUImageOutputId",
                principalTable: "GPUImageOutputs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUVideoMemorySpecific_GPUVideoMemorySpecificId",
                table: "GPU",
                column: "GPUVideoMemorySpecificId",
                principalTable: "GPUVideoMemorySpecific",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GPU_GPUVideoProcessorSpecifics_GPUVideoProcessorSpecificId",
                table: "GPU",
                column: "GPUVideoProcessorSpecificId",
                principalTable: "GPUVideoProcessorSpecifics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HDDs_HDDAdditionallies_HDDAdditionallyId",
                table: "HDDs",
                column: "HDDAdditionallyId",
                principalTable: "HDDAdditionallies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HDDs_HDDMechanicsAndReliabilities_HDDMechanicsAndReliabilityId",
                table: "HDDs",
                column: "HDDMechanicsAndReliabilityId",
                principalTable: "HDDMechanicsAndReliabilities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HDDs_HDDStorageDevices_HDDStorageDeviceId",
                table: "HDDs",
                column: "HDDStorageDeviceId",
                principalTable: "HDDStorageDevices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBAudios_MBAudioId",
                table: "MBs",
                column: "MBAudioId",
                principalTable: "MBAudios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBBackPanels_MBBackPanelId",
                table: "MBs",
                column: "MBBackPanelId",
                principalTable: "MBBackPanels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBCollingAndPowers_MBCollingAndPowerId",
                table: "MBs",
                column: "MBCollingAndPowerId",
                principalTable: "MBCollingAndPowers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MbCPUandChipsets_MbCPUandChipsetId",
                table: "MBs",
                column: "MbCPUandChipsetId",
                principalTable: "MbCPUandChipsets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBExpensionSlots_MBExpensionSlotsId",
                table: "MBs",
                column: "MBExpensionSlotsId",
                principalTable: "MBExpensionSlots",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBFormFactor_MBFormFactorId",
                table: "MBs",
                column: "MBFormFactorId",
                principalTable: "MBFormFactor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBInternalConnectors_MBInternalConnectorsId",
                table: "MBs",
                column: "MBInternalConnectorsId",
                principalTable: "MBInternalConnectors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBRAMs_MBRAMId",
                table: "MBs",
                column: "MBRAMId",
                principalTable: "MBRAMs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBStorageDevices_MBStorageDeviceId",
                table: "MBs",
                column: "MBStorageDeviceId",
                principalTable: "MBStorageDevices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MBs_MBWebs_MBWebId",
                table: "MBs",
                column: "MBWebId",
                principalTable: "MBWebs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RAMs_KitVolumeAndCompositions_RAMKitVolumeAndCompositionId",
                table: "RAMs",
                column: "RAMKitVolumeAndCompositionId",
                principalTable: "KitVolumeAndCompositions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RAMs_RAMPerformances_RAMPerformanceId",
                table: "RAMs",
                column: "RAMPerformanceId",
                principalTable: "RAMPerformances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RAMs_RAMTimings_RAMTimingsId",
                table: "RAMs",
                column: "RAMTimingsId",
                principalTable: "RAMTimings",
                principalColumn: "Id");
        }
    }
}
