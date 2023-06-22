using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class issuesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IssuePatient",
                columns: table => new
                {
                    IssuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuePatient", x => new { x.IssuesId, x.PatientsId });
                    table.ForeignKey(
                        name: "FK_IssuePatient_Issues_IssuesId",
                        column: x => x.IssuesId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssuePatient_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_IssuePatient_PatientsId",
                table: "IssuePatient",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssuePatient");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Patients");

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
                    { new Guid("15c9c9c8-b251-40b2-8c84-7f9ab5fa0f2a"), "Ahmed", 2, 2000m, "aaa" },
                    { new Guid("75822bee-c0c3-412d-b378-d22d9f0279bc"), "Ali", 3, 3000m, "aaa" },
                    { new Guid("b449274c-b096-47d5-a48f-6bfee60b5d06"), "Mostafa", 4, 4000m, "aaa" },
                    { new Guid("bd6f419e-b227-4527-924a-b6bdf66a5247"), "Mohamed", 5, 5000m, "aaa" },
                    { new Guid("bff53872-8091-4979-8464-91fb0e9c820b"), "Eslam", 1, 1000m, "aaa" },
                    { new Guid("f2281eaf-e5fe-470c-a0e1-3da8d1050081"), "Sally", 6, 6000m, "aaa" }
                });
        }
    }
}
