using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TravelTripProje.Models.Sınıflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkımızdas { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}