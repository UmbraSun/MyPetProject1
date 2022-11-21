using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    public partial class AddGPUMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GPUConnections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConnectionInterface = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionFormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditPowerConnectors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedPSU = table.Column<int>(type: "int", nullable: false),
                    UnitOfRecommendedPSU = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUConnections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPUCoolingSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoolingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeAndNumOfInstalledFans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiquidCoolingRadiator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUCoolingSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPUGeneralParametrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GraphicProcessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Microarchitecture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProccessTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUGeneralParametrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPUImageOutputs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoConnectors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayPortVersion = table.Column<float>(type: "real", nullable: false),
                    NumOfMonitorConnect = table.Column<int>(type: "int", nullable: false),
                    MaxResolution = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUImageOutputs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPUVideoMemorySpecific",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoMemorySize = table.Column<int>(type: "int", nullable: false),
                    UnitOfVideoMemorySize = table.Column<int>(type: "int", nullable: false),
                    MemoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemoryBusWidht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxMemoryBandwidth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EffectiveMemoryFrequency = table.Column<int>(type: "int", nullable: false),
                    UnitOfEffectiveMemoryFrequency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUVideoMemorySpecific", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPUVideoProcessorSpecifics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NominalFrequencyOfTheVideoChip = table.Column<int>(type: "int", nullable: false),
                    UnitNominalFreqOfTheVideoChip = table.Column<int>(type: "int", nullable: false),
                    TurboFrequency = table.Column<int>(type: "int", nullable: false),
                    UnitTurboFrequency = table.Column<int>(type: "int", nullable: false),
                    NumOfUniversalProcessors = table.Column<int>(type: "int", nullable: false),
                    NumOfTextureUnits = table.Column<int>(type: "int", nullable: false),
                    NumOfROPs = table.Column<int>(type: "int", nullable: true),
                    RayTracingSupport = table.Column<bool>(type: "bit", nullable: false),
                    HardwareAcceleratedRayTracing = table.Column<int>(type: "int", nullable: false),
                    TensorCores = table.Column<int>(type: "int", nullable: false),
                    ShaderVersion = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUVideoProcessorSpecifics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GPU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProducerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForMining = table.Column<bool>(type: "bit", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    GPUGeneralParametrsId = table.Column<int>(type: "int", nullable: true),
                    GPUVideoMemorySpecificId = table.Column<int>(type: "int", nullable: true),
                    GPUVideoProcessorSpecificId = table.Column<int>(type: "int", nullable: true),
                    GPUImageOutputId = table.Column<int>(type: "int", nullable: true),
                    GPUConnectionId = table.Column<int>(type: "int", nullable: true),
                    GPUCoolingSystemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GPU_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GPU_GPUConnections_GPUConnectionId",
                        column: x => x.GPUConnectionId,
                        principalTable: "GPUConnections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GPU_GPUCoolingSystems_GPUCoolingSystemId",
                        column: x => x.GPUCoolingSystemId,
                        principalTable: "GPUCoolingSystems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GPU_GPUGeneralParametrs_GPUGeneralParametrsId",
                        column: x => x.GPUGeneralParametrsId,
                        principalTable: "GPUGeneralParametrs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GPU_GPUImageOutputs_GPUImageOutputId",
                        column: x => x.GPUImageOutputId,
                        principalTable: "GPUImageOutputs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GPU_GPUVideoMemorySpecific_GPUVideoMemorySpecificId",
                        column: x => x.GPUVideoMemorySpecificId,
                        principalTable: "GPUVideoMemorySpecific",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GPU_GPUVideoProcessorSpecifics_GPUVideoProcessorSpecificId",
                        column: x => x.GPUVideoProcessorSpecificId,
                        principalTable: "GPUVideoProcessorSpecifics",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GPU_CountryId",
                table: "GPU",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_GPUConnectionId",
                table: "GPU",
                column: "GPUConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_GPUCoolingSystemId",
                table: "GPU",
                column: "GPUCoolingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_GPUGeneralParametrsId",
                table: "GPU",
                column: "GPUGeneralParametrsId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_GPUImageOutputId",
                table: "GPU",
                column: "GPUImageOutputId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_GPUVideoMemorySpecificId",
                table: "GPU",
                column: "GPUVideoMemorySpecificId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_GPUVideoProcessorSpecificId",
                table: "GPU",
                column: "GPUVideoProcessorSpecificId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_Name",
                table: "GPU",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GPU");

            migrationBuilder.DropTable(
                name: "GPUConnections");

            migrationBuilder.DropTable(
                name: "GPUCoolingSystems");

            migrationBuilder.DropTable(
                name: "GPUGeneralParametrs");

            migrationBuilder.DropTable(
                name: "GPUImageOutputs");

            migrationBuilder.DropTable(
                name: "GPUVideoMemorySpecific");

            migrationBuilder.DropTable(
                name: "GPUVideoProcessorSpecifics");
        }
    }
}
