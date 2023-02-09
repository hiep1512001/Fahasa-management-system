using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Fahasa_Management_System.Model
{
    public partial class FahasaContextDB : DbContext
    {
        public FahasaContextDB()
            : base("name=FahasaContextDB")
        {
        }

        public virtual DbSet<CHAMCONG> CHAMCONGs { get; set; }
        public virtual DbSet<CHITIETHOADONSACH> CHITIETHOADONSACHes { get; set; }
        public virtual DbSet<CHITIETHOADONSP> CHITIETHOADONSPs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<NXB> NXBs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHOMSP> NHOMSPs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<THONGTINCV> THONGTINCVs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADONSACHes)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADONSPs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.GIAMUA)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SACH>()
                .Property(e => e.GIABAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.CHITIETHOADONSACHes)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GIABAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GIAMUA)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETHOADONSPs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);
        }
    }
}
