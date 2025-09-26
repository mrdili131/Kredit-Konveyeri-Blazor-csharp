using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Konveyer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LimitAmount = table.Column<int>(type: "INTEGER", nullable: true),
                    Rate = table.Column<int>(type: "INTEGER", nullable: true),
                    MaxMonth = table.Column<int>(type: "INTEGER", nullable: true),
                    Fine = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    born_in = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Gender = table.Column<int>(type: "INTEGER", nullable: true),
                    Education = table.Column<int>(type: "INTEGER", nullable: true),
                    ClientCountry = table.Column<string>(type: "TEXT", nullable: true),
                    ClientRegion = table.Column<string>(type: "TEXT", nullable: true),
                    PassportLetter = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    PassportNumber = table.Column<int>(type: "INTEGER", maxLength: 6, nullable: true),
                    PassportGotRegion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    PassportGotCountry = table.Column<string>(type: "TEXT", nullable: true),
                    PassportPinfl = table.Column<int>(type: "INTEGER", nullable: true),
                    PassportGotDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BaseCountry = table.Column<string>(type: "TEXT", nullable: true),
                    BaseRegion = table.Column<string>(type: "TEXT", nullable: true),
                    BaseCity = table.Column<string>(type: "TEXT", nullable: true),
                    BaseAddress = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentCountry = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentRegion = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentCity = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentAddress = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    FilialId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: true),
                    ContractId = table.Column<string>(type: "TEXT", nullable: true),
                    ApplicationId = table.Column<int>(type: "INTEGER", nullable: true),
                    amount = table.Column<int>(type: "INTEGER", nullable: false),
                    PayDay = table.Column<int>(type: "INTEGER", nullable: true),
                    Rate = table.Column<int>(type: "INTEGER", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    FilialId = table.Column<int>(type: "INTEGER", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credits", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Credits");
        }
    }
}
