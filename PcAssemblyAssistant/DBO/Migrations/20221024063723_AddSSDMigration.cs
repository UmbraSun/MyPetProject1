using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    public partial class AddSSDMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SSD_Countries_CountryId",
                table: "SSD");

            migrationBuilder.DropForeignKey(
                name: "FK_SSD_SSDMainCharacteristics_SSDMainCharacteristicsId",
                table: "SSD");

            migrationBuilder.DropForeignKey(
                name: "FK_SSD_SSDSpeedAndPowerConsumption_SSDSpeedAndPowerConsumptionId",
                table: "SSD");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SSDSpeedAndPowerConsumption",
                table: "SSDSpeedAndPowerConsumption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SSD",
                table: "SSD");

            migrationBuilder.RenameTable(
                name: "SSDSpeedAndPowerConsumption",
                newName: "SSDSpeedAndPowerConsumptions");

            migrationBuilder.RenameTable(
                name: "SSD",
                newName: "SSDs");

            migrationBuilder.RenameIndex(
                name: "IX_SSD_SSDSpeedAndPowerConsumptionId",
                table: "SSDs",
                newName: "IX_SSDs_SSDSpeedAndPowerConsumptionId");

            migrationBuilder.RenameIndex(
                name: "IX_SSD_SSDMainCharacteristicsId",
                table: "SSDs",
                newName: "IX_SSDs_SSDMainCharacteristicsId");

            migrationBuilder.RenameIndex(
                name: "IX_SSD_Name",
                table: "SSDs",
                newName: "IX_SSDs_Name");

            migrationBuilder.RenameIndex(
                name: "IX_SSD_CountryId",
                table: "SSDs",
                newName: "IX_SSDs_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SSDSpeedAndPowerConsumptions",
                table: "SSDSpeedAndPowerConsumptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SSDs",
                table: "SSDs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SSDs_Countries_CountryId",
                table: "SSDs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SSDs_SSDMainCharacteristics_SSDMainCharacteristicsId",
                table: "SSDs",
                column: "SSDMainCharacteristicsId",
                principalTable: "SSDMainCharacteristics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SSDs_SSDSpeedAndPowerConsumptions_SSDSpeedAndPowerConsumptionId",
                table: "SSDs",
                column: "SSDSpeedAndPowerConsumptionId",
                principalTable: "SSDSpeedAndPowerConsumptions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SSDs_Countries_CountryId",
                table: "SSDs");

            migrationBuilder.DropForeignKey(
                name: "FK_SSDs_SSDMainCharacteristics_SSDMainCharacteristicsId",
                table: "SSDs");

            migrationBuilder.DropForeignKey(
                name: "FK_SSDs_SSDSpeedAndPowerConsumptions_SSDSpeedAndPowerConsumptionId",
                table: "SSDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SSDSpeedAndPowerConsumptions",
                table: "SSDSpeedAndPowerConsumptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SSDs",
                table: "SSDs");

            migrationBuilder.RenameTable(
                name: "SSDSpeedAndPowerConsumptions",
                newName: "SSDSpeedAndPowerConsumption");

            migrationBuilder.RenameTable(
                name: "SSDs",
                newName: "SSD");

            migrationBuilder.RenameIndex(
                name: "IX_SSDs_SSDSpeedAndPowerConsumptionId",
                table: "SSD",
                newName: "IX_SSD_SSDSpeedAndPowerConsumptionId");

            migrationBuilder.RenameIndex(
                name: "IX_SSDs_SSDMainCharacteristicsId",
                table: "SSD",
                newName: "IX_SSD_SSDMainCharacteristicsId");

            migrationBuilder.RenameIndex(
                name: "IX_SSDs_Name",
                table: "SSD",
                newName: "IX_SSD_Name");

            migrationBuilder.RenameIndex(
                name: "IX_SSDs_CountryId",
                table: "SSD",
                newName: "IX_SSD_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SSDSpeedAndPowerConsumption",
                table: "SSDSpeedAndPowerConsumption",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SSD",
                table: "SSD",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SSD_Countries_CountryId",
                table: "SSD",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SSD_SSDMainCharacteristics_SSDMainCharacteristicsId",
                table: "SSD",
                column: "SSDMainCharacteristicsId",
                principalTable: "SSDMainCharacteristics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SSD_SSDSpeedAndPowerConsumption_SSDSpeedAndPowerConsumptionId",
                table: "SSD",
                column: "SSDSpeedAndPowerConsumptionId",
                principalTable: "SSDSpeedAndPowerConsumption",
                principalColumn: "Id");
        }
    }
}
