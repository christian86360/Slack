using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Channel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Channel");
        }
    }
}
