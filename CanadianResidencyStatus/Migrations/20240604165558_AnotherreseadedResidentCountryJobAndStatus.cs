using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CanadianResidencyStatus.Migrations
{
    /// <inheritdoc />
    public partial class AnotherreseadedResidentCountryJobAndStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 4,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 5,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 55, 58, 64, DateTimeKind.Local).AddTicks(2314));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 676, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 676, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 676, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 676, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 676, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 677, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 677, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 677, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 677, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 677, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 676, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 676, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 676, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 4,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 677, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 5,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 35, 24, 677, DateTimeKind.Local).AddTicks(91));
        }
    }
}
