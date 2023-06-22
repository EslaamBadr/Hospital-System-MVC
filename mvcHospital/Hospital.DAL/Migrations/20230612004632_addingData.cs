using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerformanceRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("15c9c9c8-b251-40b2-8c84-7f9ab5fa0f2a"), "Ahmed", 2, 2000m, "aaa" },
                    { new Guid("75822bee-c0c3-412d-b378-d22d9f0279bc"), "Ali", 3, 3000m, "aaa" },
                    { new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"), "Mostafa", 4, 4000m, "aaa" },
                    { new Guid("bd6f419e-b227-4527-924a-b6bdf66a5247"), "Mohamed", 5, 5000m, "aaa" },
                    { new Guid("bff53872-8091-4979-8464-91fb0e9c820b"), "Eslam", 1, 1000m, "aaa" },
                    { new Guid("f2281eaf-e5fe-470c-a0e1-3da8d1050081"), "Sally", 6, 6000m, "aaa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("15c9c9c8-b251-40b2-8c84-7f9ab5fa0f2a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("75822bee-c0c3-412d-b378-d22d9f0279bc"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("bd6f419e-b227-4527-924a-b6bdf66a5247"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("bff53872-8091-4979-8464-91fb0e9c820b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f2281eaf-e5fe-470c-a0e1-3da8d1050081"));
        }
    }
}
