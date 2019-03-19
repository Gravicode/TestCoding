using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Soal04.Models;

namespace Soal04.Services
{
    public class MahasiswaService : IMahasiswaService,IDisposable
    {
        MahasiswaDbContext db;
        public MahasiswaService()
        {
            if(db==null)
                db = new MahasiswaDbContext();
        }
        public bool Create(Mahasiswa data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public DataTable GetAll()
        {
            return db.DataMahasiswa.ToList().ToDataTable(); 
        }

        public DataRow GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public DataTable Search(string Nama)
        {
            throw new NotImplementedException();
        }

        public bool Update(Mahasiswa data)
        {
            throw new NotImplementedException();
        }
    }
}