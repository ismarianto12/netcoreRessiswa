using Microsoft.EntityFrameworkCore;
using RestSekolah.Models;

namespace RestSekolah.Data
{
    public class SekolahDbContext : DbContext
    {
        public SekolahDbContext(DbContextOptions<SekolahDbContext> options)
            : base(options)
        {
        }

        public DbSet<SiswaModel> Siswa { get; set; }
        public DbSet<MapelModel> Mapel { get; set; }
        public DbSet<KelasModel> Kelas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding data untuk tabel Siswa
            modelBuilder.Entity<SiswaModel>().HasData(
                new SiswaModel
                {
                    Id = 1,
                    Nama = "Ismarianto",
                    Kelas = "XII IPA 1",
                    Alamat = "Padang",
                    NoTelp = "081234567890"
                },
                new SiswaModel
                {
                    Id = 2,
                    Nama = "Amalya",
                    Kelas = "XII IPS 2",
                    Alamat = "Jakarta",
                    NoTelp = "089876543210"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 1,
                    Nama = "Matematika",
                    Kode = "MTH101",
                    JumlahSiswa = 30,
                    Keterangan = "Matematika Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 2,
                    Nama = "Bahasa Inggris",
                    Kode = "ENG101",
                    JumlahSiswa = 25,
                    Keterangan = "Bahasa Inggris Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 3,
                    Nama = "Biologi",
                    Kode = "BIO101",
                    JumlahSiswa = 30,
                    Keterangan = "Biologi Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 4,
                    Nama = "Ekonomi",
                    Kode = "EKO101",
                    JumlahSiswa = 25,
                    Keterangan = "Ekonomi Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 5,
                    Nama = "Kimia",
                    Kode = "KIM101",
                    JumlahSiswa = 30,
                    Keterangan = "Kimia Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 6,
                    Nama = "Geografi",
                    Kode = "GEO101",
                    JumlahSiswa = 25,
                    Keterangan = "Geografi Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 7,
                    Nama = "Fisika",
                    Kode = "FIS101",
                    JumlahSiswa = 30,
                    Keterangan = "Fisika Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 8,
                    Nama = "Sosiologi",
                    Kode = "SOS101",
                    JumlahSiswa = 25,
                    Keterangan = "Sosiologi Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 9,
                    Nama = "Sejarah",
                    Kode = "SEJ101",
                    JumlahSiswa = 30,
                    Keterangan = "Sejarah Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 10,
                    Nama = "Pendidikan Agama",
                    Kode = "AGM101",
                    JumlahSiswa = 25,
                    Keterangan = "Pendidikan Agama Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 11,
                    Nama = "Pendidikan Pancasila",
                    Kode = "PPKN101",
                    JumlahSiswa = 30,
                    Keterangan = "Pendidikan Pancasila Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 12,
                    Nama = "Kewirausahaan",
                    Kode = "KWR101",
                    JumlahSiswa = 25,
                    Keterangan = "Kewirausahaan Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 13,
                    Nama = "Seni Budaya",
                    Kode = "SEN101",
                    JumlahSiswa = 30,
                    Keterangan = "Seni Budaya Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 14,
                    Nama = "Olahraga",
                    Kode = "OLR101",
                    JumlahSiswa = 25,
                    Keterangan = "Olahraga Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 15,
                    Nama = "Bahasa Indonesia",
                    Kode = "IND101",
                    JumlahSiswa = 30,
                    Keterangan = "Bahasa Indonesia Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 16,
                    Nama = "Bahasa Jepang",
                    Kode = "JPN101",
                    JumlahSiswa = 25,
                    Keterangan = "Bahasa Jepang Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 17,
                    Nama = "Bahasa Mandarin",
                    Kode = "MND101",
                    JumlahSiswa = 30,
                    Keterangan = "Bahasa Mandarin Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 18,
                    Nama = "Bahasa Perancis",
                    Kode = "FRN101",
                    JumlahSiswa = 25,
                    Keterangan = "Bahasa Perancis Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 19,
                    Nama = "Bahasa Arab",
                    Kode = "ARB101",
                    JumlahSiswa = 30,
                    Keterangan = "Bahasa Arab Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 20,
                    Nama = "Bahasa Jerman",
                    Kode = "GRM101",
                    JumlahSiswa = 25,
                    Keterangan = "Bahasa Jerman Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 21,
                    Nama = "Bahasa Korea",
                    Kode = "KOR101",
                    JumlahSiswa = 30,
                    Keterangan = "Bahasa Korea Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 22,
                    Nama = "Bahasa Rusia",
                    Kode = "RUS101",
                    JumlahSiswa = 25,
                    Keterangan = "Bahasa Rusia Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
            modelBuilder.Entity<MapelModel>().HasData(
                new MapelModel
                {
                    Id = 23,
                    Nama = "Bahasa Spanyol",
                    Kode = "SPN101",
                    JumlahSiswa = 30,
                    Keterangan = "Bahasa Spanyol Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPA 1",
                    Semester = "Ganjil"
                },
                new MapelModel
                {
                    Id = 24,
                    Nama = "Bahasa Italia",
                    Kode = "ITA101",
                    JumlahSiswa = 25,
                    Keterangan = "Bahasa Italia Dasar",
                    Jenis = "Wajib",
                    Kelas = "XII IPS 2",
                    Semester = "Genap"
                }
            );
        }
    }
}
