using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class add_patients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0cbcc2be-4146-42d3-8de2-b8ac2e7b3645"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("3dc7e704-1a3d-4171-b538-faa7ab9e0d16"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("73f5e7bf-733d-4fca-b1da-e57f9f2e5ebe"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7e6bf869-97c5-4184-b52b-dd8c279c5425"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d0d2ea61-1059-4d49-a4b2-e1463df89dcc"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e264de40-97e7-4a01-93f9-e02882a950c6"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerformanceRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("147ad45d-0b6d-4897-83c4-ddbf7998b243"), "Eslam", 1, 1000m, "aaa" },
                    { new Guid("7f3519b7-d118-4667-870e-d5530b841967"), "Ahmed", 2, 2000m, "aaa" },
                    { new Guid("8455eca6-3890-4426-af2a-ebd57e5070b4"), "Mohamed", 5, 5000m, "aaa" },
                    { new Guid("8c3eead3-1691-4c32-b60d-016c797e1f3c"), "Ali", 3, 3000m, "aaa" },
                    { new Guid("a35ab2ad-3022-4509-a866-fc769d7b0fdd"), "Sally", 6, 6000m, "aaa" },
                    { new Guid("a3b3f9e7-210a-430b-b532-8cd0ec22c72f"), "Mostafa", 4, 4000m, "aaa" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "DoctorId", "Name" },
                values: new object[,]
                {
                    { new Guid("236b2eaa-7436-4fe9-a516-1fc4c453a784"), new Guid("bff53872-8091-4979-8464-91fb0e9c820b"), "Kamal" },
                    { new Guid("48671e8d-ddf4-401f-9eb6-59be9939dbbb"), new Guid("bd6f419e-b227-4527-924a-b6bdf66a5247"), "Alaa" },
                    { new Guid("968c5fb6-43d4-4979-b79d-af221cc4a613"), new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"), "Ahmed" },
                    { new Guid("ad5973c4-7350-4a88-a228-7ae3b4ddbff7"), new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"), "Sara" },
                    { new Guid("c6d53eab-0c67-4ab3-8587-a7ec89a05305"), new Guid("15c9c9c8-b251-40b2-8c84-7f9ab5fa0f2a"), "Ali" },
                    { new Guid("e0239963-b78a-4c6d-bb99-f194e9bc67c3"), new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"), "Karma" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("147ad45d-0b6d-4897-83c4-ddbf7998b243"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7f3519b7-d118-4667-870e-d5530b841967"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8455eca6-3890-4426-af2a-ebd57e5070b4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8c3eead3-1691-4c32-b60d-016c797e1f3c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a35ab2ad-3022-4509-a866-fc769d7b0fdd"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a3b3f9e7-210a-430b-b532-8cd0ec22c72f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("236b2eaa-7436-4fe9-a516-1fc4c453a784"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("48671e8d-ddf4-401f-9eb6-59be9939dbbb"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("968c5fb6-43d4-4979-b79d-af221cc4a613"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ad5973c4-7350-4a88-a228-7ae3b4ddbff7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("c6d53eab-0c67-4ab3-8587-a7ec89a05305"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e0239963-b78a-4c6d-bb99-f194e9bc67c3"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerformanceRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("0cbcc2be-4146-42d3-8de2-b8ac2e7b3645"), "Eslam", 1, 1000m, "aaa" },
                    { new Guid("3dc7e704-1a3d-4171-b538-faa7ab9e0d16"), "Mohamed", 5, 5000m, "aaa" },
                    { new Guid("73f5e7bf-733d-4fca-b1da-e57f9f2e5ebe"), "Ali", 3, 3000m, "aaa" },
                    { new Guid("7e6bf869-97c5-4184-b52b-dd8c279c5425"), "Sally", 6, 6000m, "aaa" },
                    { new Guid("d0d2ea61-1059-4d49-a4b2-e1463df89dcc"), "Mostafa", 4, 4000m, "aaa" },
                    { new Guid("e264de40-97e7-4a01-93f9-e02882a950c6"), "Ahmed", 2, 2000m, "aaa" }
                });
        }
    }
}
