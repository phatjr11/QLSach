using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLSach.DAL.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSach>()
                .HasMany(e => e.Saches)
                .WithRequired(e => e.LoaiSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaSach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .HasMany(e => e.PhieuMuons)
                .WithRequired(e => e.DocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.MaSach)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
