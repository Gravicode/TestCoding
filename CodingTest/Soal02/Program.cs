using Soal02.Interfaces;
using Soal02.Models;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Soal02
{
    class Program
    {
        static CounterMachine counter;
        static void Main(string[] args)
        {
            //init pabrik
            PabrikSepatu P1 = new PabrikSepatu("A01");
            PabrikBaju P2 = new PabrikBaju("B01");
            PabrikSepatu P3 = new PabrikSepatu("A02");
            PabrikBaju P4 = new PabrikBaju("B02");
            CancellationToken token = new CancellationToken();

            var AllPabrik = new Pabrik[] {P1,P2,P3,P4 };
            counter = new CounterMachine();

            //mulai produksi
            foreach(var item in AllPabrik)
            {
                item.ProductFinished += Item_ProductFinished;
                Task Tsk = new Task( () => Run<IPabrik>(item as IPabrik, token));
                Tsk.Start();
            }
            Stopwatch sw = new Stopwatch();
            //setiap 10 detik lakukan perhitungan statistik
            while (true)
            {
                sw.Restart();
                Console.WriteLine($"----------------------------------------");
                Console.WriteLine("Statistik Produksi");
                Console.WriteLine($"Rata-rata jumlah per-produk :");
                Console.WriteLine($"{ counter.GetAveragePerProduct()}");
                Console.WriteLine($"Total per-produk :");
                Console.WriteLine($"{ counter.GetTotalPerProduct()}");
                Console.WriteLine($"Total per-pabrik :");
                Console.WriteLine($"{ counter.GetTotalProductionPerPabrik()}");
                sw.Stop();
                Console.WriteLine($"Time for Calculation : {sw.ElapsedMilliseconds} ms");
                Console.WriteLine($"----------------------------------------");
                Thread.Sleep(10000);
            }

            Console.ReadLine();

        }

        private static void Item_ProductFinished(string NamaPabrik, (string Merek, int Jumlah)[] Products)
        {
            //hasil produksi tiap pabrik
            foreach(var item in Products)
            {
                Console.WriteLine($"{NamaPabrik} => {item.Merek} : {item.Jumlah}");
                counter.AddProduct(NamaPabrik, item.Merek, item.Jumlah);
            }
        }

        static void Run<T>(T pabrik, CancellationToken cancel) where T:IPabrik
        {
            Random rnd = new Random(Environment.TickCount);
            var LoopDelay = rnd.Next(1000, 5000);
            while (true)
            {
                pabrik.Produksi();
                if (cancel !=  CancellationToken.None && cancel.IsCancellationRequested) break;
                Thread.Sleep(LoopDelay);
            }
        }
    }
}
