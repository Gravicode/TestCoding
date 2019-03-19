using Soal02.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Soal02.Models
{
    public class Pabrik
    {
        public delegate void ProductFinishedHandler(string NamaPabrik, (string Merek, int Jumlah)[] Products);

        public event ProductFinishedHandler ProductFinished;

        public string Nama { get; set; }
        public List<string> Products { get; set; }

        public Pabrik(string Nama, params string[] Products)
        {
            this.Nama = Nama;
            this.Products = new List<string>();
            this.Products.AddRange(Products);
            Console.WriteLine($"Pabrik {Nama} di aktifkan");
        }

        public void ProductionFinished(List<(string,int)> NewProducts)
        {
            ProductFinished?.Invoke(this.Nama, NewProducts.ToArray());
        }
    }
}
