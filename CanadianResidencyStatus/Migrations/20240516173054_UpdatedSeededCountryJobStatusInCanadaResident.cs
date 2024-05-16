using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CanadianResidencyStatus.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeededCountryJobStatusInCanadaResident : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateOfEntry", "Name" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 30, 52, 357, DateTimeKind.Local).AddTicks(4392), "Lawal Hammed" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfEntry", "Name" },
                values: new object[] { new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(818), "Olatunde" });

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEntry",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEntry",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEntry",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEntry",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 4,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 5,
                column: "StatusExpiringDate",
                value: new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(779));
        }
    }
}
