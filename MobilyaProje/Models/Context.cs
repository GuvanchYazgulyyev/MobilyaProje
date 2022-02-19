using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MobilyaProje.Models
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Galeri> Galeris { get; set; }
        public DbSet<Galeriicerik> Galeriiceriks { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Mesaj> Mesajs { get; set; }
        public DbSet<MusteriYorum> MusteriYorums { get; set; }
        public DbSet<NeYapiyoruz> NeYapiyoruzs { get; set; }
        public DbSet<Surecimiz> Surecimizs { get; set; }
        public DbSet<Blok> Bloks { get; set; }
        public DbSet<BlokSayfa> BlokSayfas { get; set; }
        public DbSet<Referans> Referans { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<FormGonder> FormGonders { get; set; }
       
    }
}