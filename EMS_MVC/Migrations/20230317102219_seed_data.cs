using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS_MVC.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Administration" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Security" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name" },
                values: new object[] { 3, "Accounting" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "DateOfBirth", "DepartmentID", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1194), 1, "steve@mojang.com", "Minecraft Steve", "09123456789" },
                    { 2, new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1210), 1, "bob@dpwh.gov.ph", "Bob Builder", "09876543210" },
                    { 3, new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1212), 2, "magik@limbo.com", "Ilyana Rasputin", "096161963" },
                    { 4, new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1214), 2, "sistergrimm@aol.com", "Nico Minoru", "09666666666" },
                    { 5, new DateTime(2023, 3, 17, 18, 22, 18, 729, DateTimeKind.Local).AddTicks(1216), 3, "redhood@batman.com", "Jason Todd", "09101010101" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
