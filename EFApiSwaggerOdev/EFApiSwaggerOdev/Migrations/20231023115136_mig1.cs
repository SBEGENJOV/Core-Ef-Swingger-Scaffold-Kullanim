using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFApiSwaggerOdev.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sube",
                columns: table => new
                {
                    SubeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubeAd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SubeKonum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SubeCalisan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sube", x => x.SubeID);
                });

            migrationBuilder.CreateTable(
                name: "Market",
                columns: table => new
                {
                    MarketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketAd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MarketAdres = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MarketKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SubeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market", x => x.MarketID);
                    table.ForeignKey(
                        name: "FK_Market_Sube",
                        column: x => x.SubeID,
                        principalTable: "Sube",
                        principalColumn: "SubeID");
                });

            migrationBuilder.CreateTable(
                name: "Calisan",
                columns: table => new
                {
                    CalisanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalisanAd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CalisanYas = table.Column<int>(type: "int", nullable: true),
                    CalisanGorev = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MarketID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisan", x => x.CalisanID);
                    table.ForeignKey(
                        name: "FK_Calisan_Market",
                        column: x => x.MarketID,
                        principalTable: "Market",
                        principalColumn: "MarketID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calisan_MarketID",
                table: "Calisan",
                column: "MarketID");

            migrationBuilder.CreateIndex(
                name: "IX_Market_SubeID",
                table: "Market",
                column: "SubeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calisan");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "Sube");
        }
    }
}
