using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }
        public DbSet<CongNhan> congNhans { get; set; }
        public DbSet<BangDangKy> BangDangKies { get; set; }
        public DbSet<Calam> calams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calam>().ToTable("Calam");
            modelBuilder.Entity<BangDangKy>().ToTable("BangDangKy");
            modelBuilder.Entity<CongNhan>().ToTable("CongNhan");
        }
    }
}
