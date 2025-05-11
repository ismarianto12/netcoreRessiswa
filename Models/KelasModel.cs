namespace  RestSekolah.Models;
using System.ComponentModel.DataAnnotations;
public class KelasModel
{
    public int Id { get; set; }
    public string NamaKelas { get; set; }
    public string Jurusan { get; set; }
    public int Kapasitas { get; set; }
    public int JumlahSiswa { get; set; }
}