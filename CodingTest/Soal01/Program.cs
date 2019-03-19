using Soal01.Interfaces;
using Soal01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal01
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobil = new Mobil("Mazda",180,100,"Toyota");
            var becak = new Becak("Becak Goes",20,1,2500);
            Console.WriteLine(mobil + " dan " + becak);
            var kombinasi = mobil + becak;
            Console.WriteLine("hasil kombinasi:");
            Console.WriteLine(kombinasi);
            Console.WriteLine("Hasil Pengujian:");
            var Ujian = new IKomparasi[]{ new UjiEmisi(), new UjiKecepatan(), new UjiTenaga() };
            Ujian.ToList().ForEach(x => Console.WriteLine(x.Uji(mobil,becak)) );
            Console.ReadLine();
        }
    }
}
