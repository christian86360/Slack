using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class primeramigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channel",
                keyColumn: "Id",
                keyValue: new Guid("15a7c214-3ee0-4bc5-a5fb-ff383a82089b"));

            migrationBuilder.DeleteData(
                table: "Channel",
                keyColumn: "Id",
                keyValue: new Guid("b9a7f9fa-7d12-4806-8b51-cd73433de54d"));

            migrationBuilder.DeleteData(
                table: "Channel",
                keyColumn: "Id",
                keyValue: new Guid("e02e9e66-c226-4b12-9ed2-effb4ab2287b"));

            migrationBuilder.InsertData(
                table: "Channel",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("8c6bb8c5-0f4e-432d-bc3b-d13a332999c6"), "Canal dedicado a dotnet core", "DotnetCore" },
                    { new Guid("9d6cd113-6674-4499-9853-7c8618d8b287"), "Canal dedicado a Angular", "Angular" },
                    { new Guid("a214fd0e-a6b2-4ccb-b86d-e4199fb1da15"), "Canal dedicado a Reactjs", "Reactjs" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channel",
                keyColumn: "Id",
                keyValue: new Guid("8c6bb8c5-0f4e-432d-bc3b-d13a332999c6"));

            migrationBuilder.DeleteData(
                table: "Channel",
                keyColumn: "Id",
                keyValue: new Guid("9d6cd113-6674-4499-9853-7c8618d8b287"));

            migrationBuilder.DeleteData(
                table: "Channel",
                keyColumn: "Id",
                keyValue: new Guid("a214fd0e-a6b2-4ccb-b86d-e4199fb1da15"));

            migrationBuilder.InsertData(
                table: "Channel",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("15a7c214-3ee0-4bc5-a5fb-ff383a82089b"), "Canal dedicado a Reactjs", "Reactjs" },
                    { new Guid("b9a7f9fa-7d12-4806-8b51-cd73433de54d"), "Canal dedicado a Angular", "Angular" },
                    { new Guid("e02e9e66-c226-4b12-9ed2-effb4ab2287b"), "Canal dedicado a dotnet core", "DotnetCore" }
                });
        }
    }
}
