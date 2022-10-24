using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    public partial class AddMotheboardMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_Countries_CountryId",
                table: "CPUs");

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

            migrationBuilder.AlterColumn<int>(
                name: "ThermalCharacteristicksId",
                table: "CPUs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RAMoptionsId",
                table: "CPUs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ParametrsId",
                table: "CPUs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GPUId",
                table: "CPUs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FrequencyAndOverclockingCapabilityId",
                table: "CPUs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "CPUs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CoreAndArchitectureId",
                table: "CPUs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "MBAudios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoundScheme = table.Column<int>(type: "int", nullable: true),
                    SouncAdapterChipset = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBAudios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBBackPanels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountAndTypeUSB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoOutputs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountOfNetworkPorts = table.Column<int>(type: "int", nullable: true),
                    CountOfAnalogAudioJacks = table.Column<int>(type: "int", nullable: true),
                    DigitalAudioPorts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBBackPanels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBCollingAndPowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainPowerConnctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPUPowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerPhases = table.Column<int>(type: "int", nullable: false),
                    PassiveCooling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveCooling = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBCollingAndPowers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MbCPUandChipsets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUStirpes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MbCPUandChipsets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBExpensionSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCIExpressVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountOfPCIExX16Slots = table.Column<int>(type: "int", nullable: false),
                    SupportedPCIorCrossfire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountOfPCIorCrossfire = table.Column<int>(type: "int", nullable: true),
                    CountOfPCIExX1Slots = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBExpensionSlots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBFormFactor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBFormFactor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBInternalConnectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternalUSBConnectors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUCoolerPowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FanConnectorsPin4 = table.Column<int>(type: "int", nullable: true),
                    FanConnectorsPin3 = table.Column<int>(type: "int", nullable: true),
                    LEDConnectorPin3 = table.Column<int>(type: "int", nullable: true),
                    LEDConnectorPin4 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBInternalConnectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBRAMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlotsCount = table.Column<int>(type: "int", nullable: false),
                    RAMFormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAMType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountOfRAMChannel = table.Column<int>(type: "int", nullable: false),
                    MaximumMemory = table.Column<int>(type: "int", nullable: false),
                    UnitOfMaxMemory = table.Column<int>(type: "int", nullable: false),
                    MaxRAMFrequency = table.Column<int>(type: "int", nullable: false),
                    UnitMaxRAMFrequency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBRAMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBStorageDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountOfM2 = table.Column<int>(type: "int", nullable: true),
                    M2Connectors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountOfPortsSATA = table.Column<int>(type: "int", nullable: false),
                    SupportedNVME = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBStorageDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBWebs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NetAdapterSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NetAdapterChipset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuiltInWifiAdapter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WiFiController = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bluetooth = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBWebs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    MBFormFactorId = table.Column<int>(type: "int", nullable: true),
                    MbCPUandChipsetId = table.Column<int>(type: "int", nullable: true),
                    MBRAMId = table.Column<int>(type: "int", nullable: true),
                    MBExpensionSlotsId = table.Column<int>(type: "int", nullable: true),
                    MBStorageDeviceId = table.Column<int>(type: "int", nullable: true),
                    MBBackPanelId = table.Column<int>(type: "int", nullable: true),
                    MBInternalConnectorsId = table.Column<int>(type: "int", nullable: true),
                    MBAudioId = table.Column<int>(type: "int", nullable: true),
                    MBWebId = table.Column<int>(type: "int", nullable: true),
                    MBCollingAndPowerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MBs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MBAudios_MBAudioId",
                        column: x => x.MBAudioId,
                        principalTable: "MBAudios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MBBackPanels_MBBackPanelId",
                        column: x => x.MBBackPanelId,
                        principalTable: "MBBackPanels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MBCollingAndPowers_MBCollingAndPowerId",
                        column: x => x.MBCollingAndPowerId,
                        principalTable: "MBCollingAndPowers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MbCPUandChipsets_MbCPUandChipsetId",
                        column: x => x.MbCPUandChipsetId,
                        principalTable: "MbCPUandChipsets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MBExpensionSlots_MBExpensionSlotsId",
                        column: x => x.MBExpensionSlotsId,
                        principalTable: "MBExpensionSlots",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MBFormFactor_MBFormFactorId",
                        column: x => x.MBFormFactorId,
                        principalTable: "MBFormFactor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MBInternalConnectors_MBInternalConnectorsId",
                        column: x => x.MBInternalConnectorsId,
                        principalTable: "MBInternalConnectors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MBRAMs_MBRAMId",
                        column: x => x.MBRAMId,
                        principalTable: "MBRAMs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MBStorageDevices_MBStorageDeviceId",
                        column: x => x.MBStorageDeviceId,
                        principalTable: "MBStorageDevices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MBs_MBWebs_MBWebId",
                        column: x => x.MBWebId,
                        principalTable: "MBWebs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MBs_CountryId",
                table: "MBs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MBAudioId",
                table: "MBs",
                column: "MBAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MBBackPanelId",
                table: "MBs",
                column: "MBBackPanelId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MBCollingAndPowerId",
                table: "MBs",
                column: "MBCollingAndPowerId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MbCPUandChipsetId",
                table: "MBs",
                column: "MbCPUandChipsetId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MBExpensionSlotsId",
                table: "MBs",
                column: "MBExpensionSlotsId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MBFormFactorId",
                table: "MBs",
                column: "MBFormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MBInternalConnectorsId",
                table: "MBs",
                column: "MBInternalConnectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MBRAMId",
                table: "MBs",
                column: "MBRAMId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MBStorageDeviceId",
                table: "MBs",
                column: "MBStorageDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_MBWebId",
                table: "MBs",
                column: "MBWebId");

            migrationBuilder.CreateIndex(
                name: "IX_MBs_Name",
                table: "MBs",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_Countries_CountryId",
                table: "CPUs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_Countries_CountryId",
                table: "CPUs");

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

            migrationBuilder.DropTable(
                name: "MBs");

            migrationBuilder.DropTable(
                name: "MBAudios");

            migrationBuilder.DropTable(
                name: "MBBackPanels");

            migrationBuilder.DropTable(
                name: "MBCollingAndPowers");

            migrationBuilder.DropTable(
                name: "MbCPUandChipsets");

            migrationBuilder.DropTable(
                name: "MBExpensionSlots");

            migrationBuilder.DropTable(
                name: "MBFormFactor");

            migrationBuilder.DropTable(
                name: "MBInternalConnectors");

            migrationBuilder.DropTable(
                name: "MBRAMs");

            migrationBuilder.DropTable(
                name: "MBStorageDevices");

            migrationBuilder.DropTable(
                name: "MBWebs");

            migrationBuilder.AlterColumn<int>(
                name: "ThermalCharacteristicksId",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RAMoptionsId",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParametrsId",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GPUId",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FrequencyAndOverclockingCapabilityId",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CoreAndArchitectureId",
                table: "CPUs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_Countries_CountryId",
                table: "CPUs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
        }
    }
}
