using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    public partial class AddPSMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PSs_PSCertifications_PSCertificationId",
                        column: x => x.PSCertificationId,
                        principalTable: "PSCertifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PSs_PSCoolingSystems_PSCoolingSystemId",
                        column: x => x.PSCoolingSystemId,
                        principalTable: "PSCoolingSystems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PSs_PSElectricalParametrs_PSElectricalParametrsId",
                        column: x => x.PSElectricalParametrsId,
                        principalTable: "PSElectricalParametrs",
                        principalColumn: "Id");
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PSs");

            migrationBuilder.DropTable(
                name: "PSCablesAndConnectors");

            migrationBuilder.DropTable(
                name: "PSCertifications");

            migrationBuilder.DropTable(
                name: "PSCoolingSystems");

            migrationBuilder.DropTable(
                name: "PSElectricalParametrs");
        }
    }
}
