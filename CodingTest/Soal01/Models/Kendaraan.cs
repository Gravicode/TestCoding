using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal01.Models
{
    public class Kendaraan
    {
        public string Nama { get; set; }
        public int Emisi { get; set; } = 0;
        public int Kecepatan { get; set; }
        public int Tenaga { set; get; }
        public static Kendaraan operator +(Kendaraan a, Kendaraan b)
        {
            Kendaraan newKendaraan = new Kendaraan($"{a.Nama}_{b.Nama}", a.Kecepatan+b.Kecepatan, a.Tenaga+b.Tenaga);           
            return newKendaraan;
        }
        
        public Kendaraan(string Nama,int Kecepatan, int Tenaga)
        {
            this.Nama = Nama;
            this.Kecepatan = Kecepatan;
            this.Tenaga = Tenaga;
        }
        public void TambahKecepatan<T>(T Nilai) where T : struct
        {
            var hasil = int.TryParse(Nilai.ToString(), out int temp);
            Kecepatan += hasil ? temp : 0; 
        }
        public override string ToString()
        {
            return $"Nama : {Nama}, kecepatan tempuh {Kecepatan}, tenaga : {Tenaga}";
        }
    }
}
