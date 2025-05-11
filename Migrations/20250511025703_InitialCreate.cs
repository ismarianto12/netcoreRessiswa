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
                name: "Mapel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JumlahSiswa = table.Column<int>(type: "int", nullable: false),
                    Keterangan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Jenis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kelas = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Semester = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mapel", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Mapel",
                columns: new[] { "Id", "Jenis", "JumlahSiswa", "Kelas", "Keterangan", "Kode", "Nama", "Semester" },
                values: new object[,]
                {
                    { 1, "Wajib", 30, "XII IPA 1", "Matematika Dasar", "MTH101", "Matematika", "Ganjil" },
                    { 2, "Wajib", 25, "XII IPS 2", "Bahasa Inggris Dasar", "ENG101", "Bahasa Inggris", "Genap" },
                    { 3, "Wajib", 30, "XII IPA 1", "Biologi Dasar", "BIO101", "Biologi", "Ganjil" },
                    { 4, "Wajib", 25, "XII IPS 2", "Ekonomi Dasar", "EKO101", "Ekonomi", "Genap" },
                    { 5, "Wajib", 30, "XII IPA 1", "Kimia Dasar", "KIM101", "Kimia", "Ganjil" },
                    { 6, "Wajib", 25, "XII IPS 2", "Geografi Dasar", "GEO101", "Geografi", "Genap" },
                    { 7, "Wajib", 30, "XII IPA 1", "Fisika Dasar", "FIS101", "Fisika", "Ganjil" },
                    { 8, "Wajib", 25, "XII IPS 2", "Sosiologi Dasar", "SOS101", "Sosiologi", "Genap" },
                    { 9, "Wajib", 30, "XII IPA 1", "Sejarah Dasar", "SEJ101", "Sejarah", "Ganjil" },
                    { 10, "Wajib", 25, "XII IPS 2", "Pendidikan Agama Dasar", "AGM101", "Pendidikan Agama", "Genap" },
                    { 11, "Wajib", 30, "XII IPA 1", "Pendidikan Pancasila Dasar", "PPKN101", "Pendidikan Pancasila", "Ganjil" },
                    { 12, "Wajib", 25, "XII IPS 2", "Kewirausahaan Dasar", "KWR101", "Kewirausahaan", "Genap" },
                    { 13, "Wajib", 30, "XII IPA 1", "Seni Budaya Dasar", "SEN101", "Seni Budaya", "Ganjil" },
                    { 14, "Wajib", 25, "XII IPS 2", "Olahraga Dasar", "OLR101", "Olahraga", "Genap" },
                    { 15, "Wajib", 30, "XII IPA 1", "Bahasa Indonesia Dasar", "IND101", "Bahasa Indonesia", "Ganjil" },
                    { 16, "Wajib", 25, "XII IPS 2", "Bahasa Jepang Dasar", "JPN101", "Bahasa Jepang", "Genap" },
                    { 17, "Wajib", 30, "XII IPA 1", "Bahasa Mandarin Dasar", "MND101", "Bahasa Mandarin", "Ganjil" },
                    { 18, "Wajib", 25, "XII IPS 2", "Bahasa Perancis Dasar", "FRN101", "Bahasa Perancis", "Genap" },
                    { 19, "Wajib", 30, "XII IPA 1", "Bahasa Arab Dasar", "ARB101", "Bahasa Arab", "Ganjil" },
                    { 20, "Wajib", 25, "XII IPS 2", "Bahasa Jerman Dasar", "GRM101", "Bahasa Jerman", "Genap" },
                    { 21, "Wajib", 30, "XII IPA 1", "Bahasa Korea Dasar", "KOR101", "Bahasa Korea", "Ganjil" },
                    { 22, "Wajib", 25, "XII IPS 2", "Bahasa Rusia Dasar", "RUS101", "Bahasa Rusia", "Genap" },
                    { 23, "Wajib", 30, "XII IPA 1", "Bahasa Spanyol Dasar", "SPN101", "Bahasa Spanyol", "Ganjil" },
                    { 24, "Wajib", 25, "XII IPS 2", "Bahasa Italia Dasar", "ITA101", "Bahasa Italia", "Genap" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mapel");
        }
    }
}
