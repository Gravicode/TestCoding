using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soal01.Models;

namespace Soal01.Interfaces
{
    public class UjiTenaga : IKomparasi
    {
        public string Uji(Kendaraan a, Kendaraan b)
        {
            if (a.Kecepatan > b.Kecepatan)
            {
                return $"{a.Nama} lebih kuat dari {b.Nama}";
            }
            else if (a.Kecepatan < b.Kecepatan)
            {
                return $"{a.Nama} lebih lemah dari {b.Nama}";
            }
            else
            {
                return $"{a.Nama} sama kuat dengan {b.Nama}";
            }
        }
    }
}
