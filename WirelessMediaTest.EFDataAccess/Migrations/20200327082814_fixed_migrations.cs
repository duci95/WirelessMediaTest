using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WirelessMediaTest.EFDataAccess.Migrations
{
    public partial class fixed_migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ManufacturerVendors");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ManufacturerVendors");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ManufacturerVendors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ManufacturerVendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ManufacturerVendors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ManufacturerVendors",
                type: "datetime2",
                nullable: true);
        }
    }
}
