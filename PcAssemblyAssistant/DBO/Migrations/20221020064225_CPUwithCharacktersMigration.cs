using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    public partial class CPUwithCharacktersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUCoreAndArchitectures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfCores = table.Column<int>(type: "int", nullable: false),
                    MaxNumberOfThread = table.Column<int>(type: "int", nullable: false),
                    NumberOfPerformanceCores = table.Column<int>(type: "int", nullable: false),
                    NumberOfEfficientCores = table.Column<int>(type: "int", nullable: true),
                    L2CacheSize = table.Column<int>(type: "int", nullable: true),
                    UnitOfL2CacheSize = table.Column<int>(type: "int", nullable: true),
                    L3CacheSize = table.Column<int>(type: "int", nullable: true),
                    UnitOfL3CacheSize = table.Column<int>(type: "int", nullable: true),
                    ProcessTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Core = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUCoreAndArchitectures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUFrequencyAndOverclockingCapabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Frequency = table.Column<int>(type: "int", nullable: false),
                    UnitFrequecy = table.Column<int>(type: "int", nullable: false),
                    MaxFrequencyInTurbo = table.Column<int>(type: "int", nullable: true),
                    UnitMaxFrequencyInTurbo = table.Column<int>(type: "int", nullable: true),
                    FrequencyOfEfficientCores = table.Column<int>(type: "int", nullable: true),
                    UnitFrequencyOfEfficientCores = table.Column<int>(type: "int", nullable: true),
                    MaxFrequencyTurboOfEfficientCores = table.Column<int>(type: "int", nullable: true),
                    UnitMaxFrequencyTurboOfEfficientCores = table.Column<int>(type: "int", nullable: true),
                    FreeMultiplier = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUFrequencyAndOverclockingCapabilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUGeneralParametrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealiseDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUGeneralParametrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUGraphicsCores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GPUModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPUCoreFreqency = table.Column<int>(type: "int", nullable: false),
                    UnitOfGPUCoreFreqency = table.Column<int>(type: "int", nullable: false),
                    ExecutiveBlocks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUGraphicsCores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPURAMoptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxSuppMemory = table.Column<int>(type: "int", nullable: false),
                    UnitOfMaxSuppMemory = table.Column<int>(type: "int", nullable: false),
                    NumberOfMemoryChanel = table.Column<int>(type: "int", nullable: false),
                    MaximumRAMfrequency = table.Column<int>(type: "int", nullable: false),
                    UnitOfMaximumRAMfrequency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPURAMoptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUThermalCharacteristicks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TDP = table.Column<int>(type: "int", nullable: false),
                    UnitOfTDP = table.Column<int>(type: "int", nullable: false),
                    MaxCPUtemprature = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUThermalCharacteristicks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    ParametrsId = table.Column<int>(type: "int", nullable: false),
                    CoreAndArchitectureId = table.Column<int>(type: "int", nullable: false),
                    FrequencyAndOverclockingCapabilityId = table.Column<int>(type: "int", nullable: false),
                    ThermalCharacteristicksId = table.Column<int>(type: "int", nullable: false),
                    GPUId = table.Column<int>(type: "int", nullable: false),
                    RAMoptionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPUs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CPUs_CPUCoreAndArchitectures_CoreAndArchitectureId",
                        column: x => x.CoreAndArchitectureId,
                        principalTable: "CPUCoreAndArchitectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_CPUFrequencyAndOverclockingCapabilities_FrequencyAndOverclockingCapabilityId",
                        column: x => x.FrequencyAndOverclockingCapabilityId,
                        principalTable: "CPUFrequencyAndOverclockingCapabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_CPUGeneralParametrs_ParametrsId",
                        column: x => x.ParametrsId,
                        principalTable: "CPUGeneralParametrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_CPUGraphicsCores_GPUId",
                        column: x => x.GPUId,
                        principalTable: "CPUGraphicsCores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_CPURAMoptions_RAMoptionsId",
                        column: x => x.RAMoptionsId,
                        principalTable: "CPURAMoptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_CPUThermalCharacteristicks_ThermalCharacteristicksId",
                        column: x => x.ThermalCharacteristicksId,
                        principalTable: "CPUThermalCharacteristicks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Name",
                table: "Countries",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_CoreAndArchitectureId",
                table: "CPUs",
                column: "CoreAndArchitectureId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_CountryId",
                table: "CPUs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_FrequencyAndOverclockingCapabilityId",
                table: "CPUs",
                column: "FrequencyAndOverclockingCapabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_GPUId",
                table: "CPUs",
                column: "GPUId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_Name",
                table: "CPUs",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_ParametrsId",
                table: "CPUs",
                column: "ParametrsId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_RAMoptionsId",
                table: "CPUs",
                column: "RAMoptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_ThermalCharacteristicksId",
                table: "CPUs",
                column: "ThermalCharacteristicksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CPUCoreAndArchitectures");

            migrationBuilder.DropTable(
                name: "CPUFrequencyAndOverclockingCapabilities");

            migrationBuilder.DropTable(
                name: "CPUGeneralParametrs");

            migrationBuilder.DropTable(
                name: "CPUGraphicsCores");

            migrationBuilder.DropTable(
                name: "CPURAMoptions");

            migrationBuilder.DropTable(
                name: "CPUThermalCharacteristicks");
        }
    }
}
