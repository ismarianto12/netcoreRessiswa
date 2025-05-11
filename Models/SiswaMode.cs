using System.ComponentModel.DataAnnotations.Schema;

namespace RestSekolah.Models;
[Table("siswa")]

public class SiswaModel
{

    public int Id { get; set; }
    public string Nama { get; set; }
    public string Kelas { get; set; }
    public string Alamat { get; set; }
    public string NoTelp { get; set; }
}
