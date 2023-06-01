using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete
{
   public class Context:DbContext
    {
        public DbSet<Fatura>  faturas { get; set; }
        public DbSet<Marka>  markas { get; set; }
        public DbSet<Admin>  admins { get; set; }
        public DbSet<Cari>  caris { get; set; }
        public DbSet<Gider>  giders { get; set; }
        public DbSet<Fatura_Kalem>  fatura_Kalems { get; set; }
        public DbSet<Urun>  uruns { get; set; }
        public DbSet<Kategori>  kategoris { get; set; }
        public DbSet<Satis_Hareket>  satis_Harekets { get; set; }
        public DbSet<Departman>  departmans { get; set; }
        public DbSet<Personel>  personels { get; set; }
        public DbSet<Sehir> sehirs { get; set; }
        public DbSet<To_Do_List> To_Do_Lists { get; set; }
        public DbSet<Kargo_Takip> Kargo_Takips { get; set; }
        public DbSet<Kargo> Kargos { get; set; }
        public DbSet<Mesaj> Mesajs { get; set; }

    }
}
