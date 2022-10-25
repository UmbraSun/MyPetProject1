using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcAssemblyAssistant.Migrations
{
    public partial class ChangePowerConsuptionInModelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EnergyConsumption",
                table: "SSDSpeedAndPowerConsumptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<float>(
                name: "EnergyConsumption",
                table: "SSDSpeedAndPowerConsumptions",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
