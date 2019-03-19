using System;
using System.Collections.Generic;
using System.Text;

namespace Soal02.Interfaces
{
    public interface ICounter
    {
        void AddProduct(string Pabrik, string Product, int Jumlah);
        string GetAveragePerProduct();
        string GetTotalPerProduct();
        string GetTotalProductionPerPabrik();
    }
}
