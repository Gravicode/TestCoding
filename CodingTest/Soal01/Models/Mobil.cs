using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal01.Models
{
    public class Mobil:Kendaraan
    {
        public Mobil(string Nama, int Kecepatan, int Tenaga, string Manufaktur) : base(Nama, Kecepatan, Tenaga)
        {
            this.Manufaktur = Manufaktur;
            this.Emisi = 50;
        }
        public string Manufaktur { get; set; }
        public override string ToString()
        {
            return $"Nama : {Nama}, kecepatan tempuh {Kecepatan}, Merek {Manufaktur}";
        }
    }
}
