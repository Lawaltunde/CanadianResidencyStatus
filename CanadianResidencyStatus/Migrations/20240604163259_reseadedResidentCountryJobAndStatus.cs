using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CanadianResidencyStatus.Migrations
{
    /// <inheritdoc />
    public partial class reseadedResidentCountryJobAndStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEntry",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEntry",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEntry",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEntry",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEntry",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 4,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 5,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4312));
        }
    }
}
