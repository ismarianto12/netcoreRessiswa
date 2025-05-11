
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
namespace RestSekolah.Models
{
    [Table("kelas")]
    public class KelasModel
    {

        public int Id { get; set; }
        public string NamaKelas { get; set; }
        [Required(ErrorMessage = "Tahun ajaran tidak boleh kosong")]

        public string Jurusan { get; set; }
        [Required(ErrorMessage = "Tahun ajaran tidak boleh kosong")]
        public int Kapasitas { get; set; }

        [Required(ErrorMessage = "Tahun ajaran tidak boleh kosong")]
        public int JumlahSiswa { get; set; }
    }
}

