using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soal01.Models;

namespace Soal01.Interfaces
{
    public class UjiEmisi : IKomparasi
    {
        public string Uji(Kendaraan a, Kendaraan b)
        {
            if (a.Emisi > b.Emisi)
            {
                return $"Emisi {a.Nama} lebih buruk dari {b.Nama}";
            }else if (a.Emisi < b.Emisi)
            {
                return $"Emisi {a.Nama} lebih baik dari {b.Nama}";
            }
            else
            {
                return $"Emisi {a.Nama} sama dengan {b.Nama}";
            }
        }
    }
}
