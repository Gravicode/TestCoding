using Soal02.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Soal02.Models
{
    public class PabrikBaju : Pabrik, IPabrik
    {
        public PabrikBaju(string Nama) : base(Nama, "Billabong", "Calvin Klein", "Guess", "Levis")
        {

        }
        public void Produksi()
        {
            Random rnd = new Random(Environment.TickCount);
            var generated = new List<(string, int)>();
            foreach (var item in Products)
            {
                generated.Add((item, rnd.Next(200)));
            }
            ProductionFinished(generated);
        }

    }
}
