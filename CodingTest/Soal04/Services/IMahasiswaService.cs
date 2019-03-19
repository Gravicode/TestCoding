using Soal04.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal04.Services
{
    public interface IMahasiswaService
    {
            DataRow GetById(int Id);
            DataTable GetAll();
            DataTable Search(string Nama);
            bool Create(Mahasiswa data);
            bool Update(Mahasiswa data);
            bool Delete(int id);
    }
}
