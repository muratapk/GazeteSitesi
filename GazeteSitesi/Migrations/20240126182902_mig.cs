using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GazeteSitesi.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gazetes",
                columns: table => new
                {
                    GazeteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GazeteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GazeteLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GazeteSlogan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GazeteEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GazeteFacebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GazeteInstagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GazeteYoutube = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GazeteTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GazeteAdres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gazetes", x => x.GazeteId);
                });

            migrationBuilder.CreateTable(
                name: "Kategorilers",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorilers", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Konumlars",
                columns: table => new
                {
                    KonumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konumlars", x => x.KonumId);
                });

            migrationBuilder.CreateTable(
                name: "Resimlers",
                columns: table => new
                {
                    ResimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResimAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resimlers", x => x.ResimId);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlars",
                columns: table => new
                {
                    YazarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarSifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlars", x => x.YazarId);
                });

            migrationBuilder.CreateTable(
                name: "Yetkilers",
                columns: table => new
                {
                    YetkiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkilers", x => x.YetkiId);
                });

            migrationBuilder.CreateTable(
                name: "Reklamlars",
                columns: table => new
                {
                    ReklamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReklamKonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReklamResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KonumId = table.Column<int>(type: "int", nullable: false),
                    KonumlarKonumId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reklamlars", x => x.ReklamId);
                    table.ForeignKey(
                        name: "FK_Reklamlars_Konumlars_KonumlarKonumId",
                        column: x => x.KonumlarKonumId,
                        principalTable: "Konumlars",
                        principalColumn: "KonumId");
                });

            migrationBuilder.CreateTable(
                name: "haberlers",
                columns: table => new
                {
                    HaberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaberBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaberKonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaberIcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResimId = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false),
                    HaberTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HaberManset = table.Column<int>(type: "int", nullable: false),
                    KonumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haberlers", x => x.HaberId);
                    table.ForeignKey(
                        name: "FK_haberlers_Kategorilers_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategorilers",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_haberlers_Konumlars_KonumId",
                        column: x => x.KonumId,
                        principalTable: "Konumlars",
                        principalColumn: "KonumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_haberlers_Resimlers_ResimId",
                        column: x => x.ResimId,
                        principalTable: "Resimlers",
                        principalColumn: "ResimId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_haberlers_Yazarlars_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazarlars",
                        principalColumn: "YazarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilars",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YetkiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilars", x => x.KullaniciId);
                    table.ForeignKey(
                        name: "FK_Kullanicilars_Yetkilers_YetkiId",
                        column: x => x.YetkiId,
                        principalTable: "Yetkilers",
                        principalColumn: "YetkiId");
                });

            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    YorumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumMesaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.YorumId);
                    table.ForeignKey(
                        name: "FK_Yorumlars_haberlers_HaberId",
                        column: x => x.HaberId,
                        principalTable: "haberlers",
                        principalColumn: "HaberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_haberlers_KategoriId",
                table: "haberlers",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_haberlers_KonumId",
                table: "haberlers",
                column: "KonumId");

            migrationBuilder.CreateIndex(
                name: "IX_haberlers_ResimId",
                table: "haberlers",
                column: "ResimId");

            migrationBuilder.CreateIndex(
                name: "IX_haberlers_YazarId",
                table: "haberlers",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilars_YetkiId",
                table: "Kullanicilars",
                column: "YetkiId");

            migrationBuilder.CreateIndex(
                name: "IX_Reklamlars_KonumlarKonumId",
                table: "Reklamlars",
                column: "KonumlarKonumId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_HaberId",
                table: "Yorumlars",
                column: "HaberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gazetes");

            migrationBuilder.DropTable(
                name: "Kullanicilars");

            migrationBuilder.DropTable(
                name: "Reklamlars");

            migrationBuilder.DropTable(
                name: "Yorumlars");

            migrationBuilder.DropTable(
                name: "Yetkilers");

            migrationBuilder.DropTable(
                name: "haberlers");

            migrationBuilder.DropTable(
                name: "Kategorilers");

            migrationBuilder.DropTable(
                name: "Konumlars");

            migrationBuilder.DropTable(
                name: "Resimlers");

            migrationBuilder.DropTable(
                name: "Yazarlars");
        }
    }
}
