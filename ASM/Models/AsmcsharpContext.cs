using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASM.Models;

public partial class AsmcsharpContext : DbContext
{
    public AsmcsharpContext()
    {
    }

    public AsmcsharpContext(DbContextOptions<AsmcsharpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }

    public virtual DbSet<DocGium> DocGia { get; set; }

    public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<Theloai> Theloais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NGUYEN-DUC-PHUO\\SQLEXPRESS;Database=ASMCSHARP;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChiTietPhieuMuon");

            entity.Property(e => e.MaPhieu).HasColumnName("maPhieu");
            entity.Property(e => e.MaSach).HasColumnName("maSach");
            entity.Property(e => e.SoLuong).HasColumnName("soLuong");

            entity.HasOne(d => d.MaPhieuNavigation).WithMany()
                .HasForeignKey(d => d.MaPhieu)
                .HasConstraintName("FK__ChiTietPh__soLuo__4316F928");

            entity.HasOne(d => d.MaSachNavigation).WithMany()
                .HasForeignKey(d => d.MaSach)
                .HasConstraintName("FK__ChiTietPh__maSac__440B1D61");
        });

        modelBuilder.Entity<DocGium>(entity =>
        {
            entity.HasKey(e => e.MaDocGia).HasName("PK__DocGia__F67BFCBA0D7851C3");

            entity.Property(e => e.MaDocGia).HasColumnName("maDocGia");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("soDienThoai");
            entity.Property(e => e.TenDocGia)
                .HasMaxLength(30)
                .HasColumnName("tenDocGia");
        });

        modelBuilder.Entity<PhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaPhieu).HasName("PK__PhieuMuo__49A5B11F0FC99355");

            entity.ToTable("PhieuMuon");

            entity.Property(e => e.MaPhieu).HasColumnName("maPhieu");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(100)
                .HasColumnName("ghiChu");
            entity.Property(e => e.MaDocGia).HasColumnName("maDocGia");
            entity.Property(e => e.MaNhanVien).HasColumnName("maNhanVien");
            entity.Property(e => e.NgayHetHan).HasColumnName("ngayHetHan");
            entity.Property(e => e.NgayMuon).HasColumnName("ngayMuon");
            entity.Property(e => e.NgayTra).HasColumnName("ngayTra");
            entity.Property(e => e.TrangThaiTra).HasColumnName("trangThaiTra");

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.PhieuMuons)
                .HasForeignKey(d => d.MaDocGia)
                .HasConstraintName("FK__PhieuMuon__maDoc__412EB0B6");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.PhieuMuons)
                .HasForeignKey(d => d.MaNhanVien)
                .HasConstraintName("FK__PhieuMuon__ghiCh__403A8C7D");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__D2507EF95B3D7523");

            entity.ToTable("Sach");

            entity.Property(e => e.MaSach).HasColumnName("maSach");
            entity.Property(e => e.MaTheloai).HasColumnName("maTheloai");
            entity.Property(e => e.NamXuatBan).HasColumnName("namXuatBan");
            entity.Property(e => e.Nxb)
                .HasMaxLength(30)
                .HasColumnName("NXB");
            entity.Property(e => e.TacGia)
                .HasMaxLength(30)
                .HasColumnName("tacGia");
            entity.Property(e => e.TenSach)
                .HasMaxLength(30)
                .HasColumnName("tenSach");

            entity.HasOne(d => d.MaTheloaiNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.MaTheloai)
                .HasConstraintName("FK__Sach__maTheloai__3D5E1FD2");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__TaiKhoan__BDDEF20D92E3E711");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.MaNhanVien).HasColumnName("maNhanVien");
            entity.Property(e => e.HoTen).HasMaxLength(30);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("matKhau");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("soDienThoai");
            entity.Property(e => e.TaiKhoan1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("taiKhoan");
            entity.Property(e => e.VaiTro)
                .HasMaxLength(30)
                .HasColumnName("vaiTro");
        });

        modelBuilder.Entity<Theloai>(entity =>
        {
            entity.HasKey(e => e.MaTheloai).HasName("PK__Theloai__6284DCD20F00F637");

            entity.ToTable("Theloai");

            entity.Property(e => e.MaTheloai).HasColumnName("maTheloai");
            entity.Property(e => e.TenTheloai)
                .HasMaxLength(30)
                .HasColumnName("tenTheloai");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
