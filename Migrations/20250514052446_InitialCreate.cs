using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestSekolah.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jadwal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Hari = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Jam = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kelas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MataPelajaran = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pengajar = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jadwal", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "jadwal",
                columns: new[] { "Id", "Hari", "Jam", "Kelas", "MataPelajaran", "Pengajar" },
                values: new object[,]
                {
                    { 1, "Senin", "08:00 - 09:30", "XII IPA 1", "Matematika", "Budi" },
                    { 2, "Selasa", "10:00 - 11:30", "XII IPS 2", "Bahasa Inggris", "Siti" },
                    { 3, "Rabu", "08:00 - 09:30", "XII IPA 1", "Biologi", "Andi" },
                    { 4, "Kamis", "10:00 - 11:30", "XII IPS 2", "Ekonomi", "Dewi" },
                    { 5, "Jumat", "08:00 - 09:30", "XII IPA 1", "Kimia", "Rudi" },
                    { 6, "Sabtu", "10:00 - 11:30", "XII IPS 2", "Geografi", "Ani" },
                    { 7, "Minggu", "08:00 - 09:30", "XII IPA 1", "Fisika", "Budi" },
                    { 8, "Senin", "10:00 - 11:30", "XII IPS 2", "Sosiologi", "Siti" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jadwal");
        }
    }
}
