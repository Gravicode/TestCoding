using Soal02.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Soal02.Models
{
    public class PabrikSepatu : Pabrik, IPabrik
    {
        public PabrikSepatu(string Nama):base(Nama, "Nike", "Adidas", "Reebook")
        {
            
        }
        public void Produksi()
        {
            Random rnd = new Random(Environment.TickCount);
            var generated = new List<(string, int)>();
            foreach(var item in Products)
            {  
                generated.Add((item, rnd.Next(100)));   
            }
            ProductionFinished(generated);
        }
        
    }
}
