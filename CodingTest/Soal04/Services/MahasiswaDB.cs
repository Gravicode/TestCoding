using Soal04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Soal04.Services
{
    public class MahasiswaDbContext : DbContext
    {
        public MahasiswaDbContext()
            : base("Mahasiswa.DbConnection")
        {
            Database.SetInitializer<MahasiswaDbContext>(new MahasiswaDbInitializer());
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Mahasiswa> DataMahasiswa { get; set; }
    }
    public class MahasiswaDbInitializer : CreateDatabaseIfNotExists<MahasiswaDbContext>
    {
        protected override void Seed(MahasiswaDbContext context)
        {
            var datas = new List<Mahasiswa>{
            new Mahasiswa {
                Id=0, NIM="0123", Nama="Asep Show", Alamat="Jl Beruk No.23 Jember", Berat=66, Tinggi=150, JenisKelamin= Kelamin.Cowok, Phone="08123446", TanggalLahir=new DateTime(1998,8,1) 
            },
            new Mahasiswa {
                Id=1, NIM="0234", Nama="Japri", Alamat="Jl Kople No.1 Garut", Berat=88, Tinggi=172, JenisKelamin= Kelamin.Cowok, Phone="032146546", TanggalLahir=new DateTime(1995,4,1)
            },
                new Mahasiswa {
                Id=2, NIM="0345", Nama="Sutemi Asyui", Alamat="Jl Cocot No.22 Majalengka", Berat=77, Tinggi=160, JenisKelamin= Kelamin.Cewek, Phone="0547546342", TanggalLahir=new DateTime(1993,2,1)
            },
                new Mahasiswa {
                Id=3, NIM="0543", Nama="Dewi Sysyk", Alamat="Jl Banjir No.33 Kampung Ambon", Berat=67, Tinggi=176, JenisKelamin= Kelamin.Cewek, Phone="05436765476", TanggalLahir=new DateTime(1992,3,1)
            },
        };

            datas.ForEach(x => context.DataMahasiswa.Add(x));
        }
    }
    public static class DataExtensions
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType)
                  ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataRow ToDataRow<T>(this T data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType)
                  ?? prop.PropertyType);
            }
            DataRow row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
            {
                row[prop.Name] = prop.GetValue(data) ?? DBNull.Value;
            }
            table.Rows.Add(row);
            return table.Rows[0];
        }
    }
}