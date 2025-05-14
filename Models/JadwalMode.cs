namespace RestSekolah.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
    [Table("jadwal")]
public class JadwaModel{
 
    public int Id { get; set; }
    public string Hari { get; set; }
    public string Jam { get; set; }
    public string Kelas { get; set; }
    public string MataPelajaran { get; set; }
    public string Pengajar { get; set; }
}