using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CanadianResidencyStatus.Migrations
{
    /// <inheritdoc />
    public partial class reseadedResidentCountryJobAndStatusAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEntry",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 4,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 5,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 6, 4, 12, 32, 58, 8, DateTimeKind.Local).AddTicks(3623));
        }
    }
}
