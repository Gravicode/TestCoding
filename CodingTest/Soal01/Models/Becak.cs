using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal01.Models
{
    public class Becak:Kendaraan
    {
        public Becak(string Nama, int Kecepatan, int Tenaga, int Ongkos) :base(Nama,Kecepatan,Tenaga)
        {
            this.Ongkos = Ongkos;
            this.Emisi = 0;
        }
        public int Ongkos { get; set; } = 1500;
        public override string ToString()
        {
            return $"Nama : {Nama}, kecepatan tempuh {Kecepatan}, ongkos Rp.{Ongkos}";
        }
    }
}
