# 🏫 RestSekolah API

API berbasis ASP.NET Core untuk mengelola data Siswa dan Mata Pelajaran (Mapel) menggunakan Entity Framework Core.

## 📌 Fitur

* CRUD untuk entitas `Siswa` dan `Mapel`
* Seeding data otomatis untuk database saat migrasi
* Struktur RESTful API
* Menggunakan `Entity Framework Core`

## 🧱 Struktur Proyek

```
RestSekolah/
├── Controllers/
│   └── SiswaController.cs
│   └── MapelController.cs
├── Data/
│   └── SekolahDbContext.cs
├── Models/
│   └── SiswaModel.cs
│   └── MapelModel.cs
├── Program.cs
├── Startup.cs (jika ada)
└── README.md
```

## 🛠️ Instalasi & Menjalankan Proyek

1. **Kloning repositori**

```bash
git clone https://github.com/username/RestSekolah.git
cd RestSekolah
```

2. **Restore dependensi**

```bash
dotnet restore
```

3. **Lakukan migrasi dan update database**

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

> Pastikan sudah menambahkan koneksi database di `appsettings.json`.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=RestSekolahDB;Trusted_Connection=True;"
}
```

4. **Jalankan aplikasi**

```bash
dotnet run
```

## 📮 Endpoint API

| Endpoint          | Method | Keterangan                       |
| ----------------- | ------ | -------------------------------- |
| `/api/siswa`      | GET    | Mendapatkan semua siswa          |
| `/api/siswa/{id}` | GET    | Mendapatkan siswa berdasarkan ID |
| `/api/siswa`      | POST   | Menambahkan siswa baru           |
| `/api/siswa/{id}` | PUT    | Memperbarui data siswa           |
| `/api/siswa/{id}` | DELETE | Menghapus siswa                  |

\| `/api/mapel` | GET | Mendapatkan semua mapel |
\| `/api/mapel/{id}` | GET | Mendapatkan mapel berdasarkan ID |
\| `/api/mapel` | POST | Menambahkan mapel baru |
\| `/api/mapel/{id}` | PUT | Memperbarui data mapel |
\| `/api/mapel/{id}` | DELETE | Menghapus mapel |

## 🧪 Tools yang Digunakan

* [.NET 6](https://dotnet.microsoft.com/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
* [SQL Server](https://www.microsoft.com/en-us/sql-server)
* [Postman](https://www.postman.com/) untuk pengujian API

## 📧 Kontak 083182305714

Dibuat oleh Ismarianto – [LinkedIn](https://www.linkedin.com/in/ismarianto) – [ismarianto97@gmail.com](mailto:ismarianto97@gmail.com)
 
