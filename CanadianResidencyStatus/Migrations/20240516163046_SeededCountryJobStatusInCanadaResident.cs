using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CanadianResidencyStatus.Migrations
{
    /// <inheritdoc />
    public partial class SeededCountryJobStatusInCanadaResident : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Nigeria", "Ng" },
                    { 2, "India", "In" },
                    { 3, "China", "Ch" },
                    { 4, "Ghana", "Gh" },
                    { 5, "United State Of America", "USA" }
                });

            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "Id", "DateOfEmployment", "JobName", "Position", "Status", "Wages" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(627), "Software Engineer", "Senior Developer", "Currently Employed", 500000.00m },
                    { 2, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(704), "Software Engineer", "CTO", "Currently Employed", 700000.00m },
                    { 3, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(708), "Designer", "UI", "Currently Employed", 400000.00m },
                    { 4, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(712), "Software Engineer", "Cloud Engineer", "Currently Employed", 300000.00m },
                    { 5, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(715), "Software Engineer", "Tester", "Currently Employed", 200000.00m }
                });

            migrationBuilder.InsertData(
                table: "statusInCanada",
                columns: new[] { "Id", "StatusExpiringDate", "StatusName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(765), "Citizen" },
                    { 2, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(770), "Permanent Resident" },
                    { 3, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(773), "Study Permit" },
                    { 4, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(776), "Work Permit" },
                    { 5, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(779), "Visitor" }
                });

            migrationBuilder.InsertData(
                table: "residents",
                columns: new[] { "Id", "Address", "City", "CountryId", "DateOfEntry", "JobId", "Name", "PostalCode", "Province", "SIN", "StatusId" },
                values: new object[,]
                {
                    { 1, "Woodbine Ave", "Sudbury", 1, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(818), 1, "Olatunde", "P34 678", "Ontario", "9375683957", 1 },
                    { 2, "King Street Profoundus", "Sudbury", 2, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(826), 2, "Anjelo", "P34 678", "Ontario", "93756835674", 2 },
                    { 3, "Toronto", "Sudbury", 3, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(831), 3, "Bashiroh", "P34 678", "Ontario", "9375683294739547", 3 },
                    { 4, "Larch", "Sudbury", 4, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(836), 4, "Ashish", "P5M 678", "Ontario", "949883957", 4 },
                    { 5, "Cambrian Residence", "Sudbury", 5, new DateTime(2024, 5, 16, 12, 30, 46, 130, DateTimeKind.Local).AddTicks(840), 5, "Dade", "P6B 390", "Ontario", "99473553957", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "residents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "jobs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "statusInCanada",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
