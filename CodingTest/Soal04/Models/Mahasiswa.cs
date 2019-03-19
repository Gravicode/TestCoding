using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soal04.Models
{
    public enum Kelamin { Cowok,Cewek};
    public class Mahasiswa
    {
        public int Id { get; set; }
        public string NIM { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Phone { get; set; }
        public Kelamin  JenisKelamin { get; set; }
        public DateTime TanggalLahir { get; set; }
        public int Tinggi { get; set; }
        public int Berat { get; set; }
    }
}