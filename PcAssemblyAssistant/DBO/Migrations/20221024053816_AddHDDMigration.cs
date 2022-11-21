using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    public partial class AddHDDMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HDDAdditionallies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxPowerConsumption = table.Column<int>(type: "int", nullable: false),
                    UnitMaxPowerConsumption = table.Column<int>(type: "int", nullable: false),
                    StandbyPowerConsumpiton = table.Column<int>(type: "int", nullable: false),
                    UnitStandbyPowerConsumpiton = table.Column<int>(type: "int", nullable: false),
                    MinOperatingTemp = table.Column<int>(type: "int", nullable: false),
                    MaxOperatingTemp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDAdditionallies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HDDMechanicsAndReliabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordingTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShockResistAtWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiseLevelDuring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiseLevelInIdle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDMechanicsAndReliabilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HDDStorageDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolumeHDD = table.Column<int>(type: "int", nullable: false),
                    UnitOfVolumeHDD = table.Column<int>(type: "int", nullable: false),
                    CacheSize = table.Column<int>(type: "int", nullable: false),
                    UnitOfCacheSize = table.Column<int>(type: "int", nullable: false),
                    SpindleSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxDataTransferRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntarfaceHDD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterfaceBandwidth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptForRAIDarrays = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDStorageDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HDDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    HDDStorageDeviceId = table.Column<int>(type: "int", nullable: true),
                    HDDMechanicsAndReliabilityId = table.Column<int>(type: "int", nullable: true),
                    HDDAdditionallyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HDDs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id", 
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_HDDs_HDDAdditionallies_HDDAdditionallyId",
                        column: x => x.HDDAdditionallyId,
                        principalTable: "HDDAdditionallies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HDDs_HDDMechanicsAndReliabilities_HDDMechanicsAndReliabilityId",
                        column: x => x.HDDMechanicsAndReliabilityId,
                        principalTable: "HDDMechanicsAndReliabilities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HDDs_HDDStorageDevices_HDDStorageDeviceId",
                        column: x => x.HDDStorageDeviceId,
                        principalTable: "HDDStorageDevices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HDDs_CountryId",
                table: "HDDs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDs_HDDAdditionallyId",
                table: "HDDs",
                column: "HDDAdditionallyId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDs_HDDMechanicsAndReliabilityId",
                table: "HDDs",
                column: "HDDMechanicsAndReliabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDs_HDDStorageDeviceId",
                table: "HDDs",
                column: "HDDStorageDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDs_Name",
                table: "HDDs",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HDDs");

            migrationBuilder.DropTable(
                name: "HDDAdditionallies");

            migrationBuilder.DropTable(
                name: "HDDMechanicsAndReliabilities");

            migrationBuilder.DropTable(
                name: "HDDStorageDevices");
        }
    }
}
