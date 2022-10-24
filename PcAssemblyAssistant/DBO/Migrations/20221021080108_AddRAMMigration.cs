using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    public partial class AddRAMMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KitVolumeAndCompositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    UnitTotalAmount = table.Column<int>(type: "int", nullable: false),
                    VolumeOfOneModule = table.Column<int>(type: "int", nullable: false),
                    UnitVolumeOfOneModule = table.Column<int>(type: "int", nullable: false),
                    NumOfModules = table.Column<int>(type: "int", nullable: false),
                    RegisterMemory = table.Column<bool>(type: "bit", nullable: false),
                    ECCMemory = table.Column<bool>(type: "bit", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitVolumeAndCompositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAMPerformances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClockFrequency = table.Column<int>(type: "int", nullable: false),
                    UnitClockFrequency = table.Column<int>(type: "int", nullable: false),
                    IntelXMPprofiles = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMPerformances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAMTimings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CASLatency = table.Column<int>(type: "int", nullable: false),
                    RAStoCASDelay = table.Column<int>(type: "int", nullable: false),
                    RowPrechangeDelay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMTimings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProducerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    RAMKitVolumeAndCompositionId = table.Column<int>(type: "int", nullable: true),
                    RAMPerformanceId = table.Column<int>(type: "int", nullable: true),
                    RAMTimingsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RAMs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RAMs_KitVolumeAndCompositions_RAMKitVolumeAndCompositionId",
                        column: x => x.RAMKitVolumeAndCompositionId,
                        principalTable: "KitVolumeAndCompositions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RAMs_RAMPerformances_RAMPerformanceId",
                        column: x => x.RAMPerformanceId,
                        principalTable: "RAMPerformances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RAMs_RAMTimings_RAMTimingsId",
                        column: x => x.RAMTimingsId,
                        principalTable: "RAMTimings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_CountryId",
                table: "RAMs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_Name",
                table: "RAMs",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_RAMKitVolumeAndCompositionId",
                table: "RAMs",
                column: "RAMKitVolumeAndCompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_RAMPerformanceId",
                table: "RAMs",
                column: "RAMPerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_RAMTimingsId",
                table: "RAMs",
                column: "RAMTimingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "KitVolumeAndCompositions");

            migrationBuilder.DropTable(
                name: "RAMPerformances");

            migrationBuilder.DropTable(
                name: "RAMTimings");
        }
    }
}
