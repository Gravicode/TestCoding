using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soal01.Models;

namespace Soal01.Interfaces
{
    public class UjiKecepatan : IKomparasi
    {
        public string Uji(Kendaraan a, Kendaraan b)
        {
            if (a.Kecepatan > b.Kecepatan)
            {
                return $"{a.Nama} lebih cepat dari {b.Nama}";
            }
            else if (a.Kecepatan < b.Kecepatan)
            {
                return $"{a.Nama} lebih lambat dari {b.Nama}";
            }
            else
            {
                return $"{a.Nama} sama cepat dengan {b.Nama}";
            }
        }
    }
}
