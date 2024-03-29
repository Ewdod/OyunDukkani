﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable



namespace OyunDukkani.Data.Migrations
{
    /// <inheritdoc />
    public partial class OyunlarData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "oyunlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyati = table.Column<double>(type: "float", nullable: false),
                    Platformu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarkodNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TekPlatform = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oyunlar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "oyunlar",
                columns: new[] { "Id", "BarkodNumarasi", "Fiyati", "OyunAdi", "Platformu", "TekPlatform" },
                values: new object[,]
                {
                    { 1, "1234567890123", 59.990000000000002, "The Witcher 3", "PC", true },
                    { 2, "9876543210123", 39.990000000000002, "Grand Theft Auto V", "PlayStation 4", false },
                    { 3, "4567890123456", 49.990000000000002, "The Legend of Zelda: Breath of the Wild", "Nintendo Switch", true },
                    { 4, "7890123456789", 44.990000000000002, "Red Dead Redemption 2", "Xbox One", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "oyunlar");
        }
    }
}
