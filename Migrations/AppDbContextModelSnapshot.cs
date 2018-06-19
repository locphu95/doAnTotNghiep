﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NguyenPhuLoc.Models;

namespace NguyenPhuLoc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NguyenPhuLoc.Models.CBNV", b =>
                {
                    b.Property<string>("MaCBNV")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DiaChi");

                    b.Property<string>("DienThoai");

                    b.Property<string>("Email");

                    b.Property<string>("HoCBNV");

                    b.Property<string>("HocVi");

                    b.Property<string>("MaLoaiGiangVien");

                    b.Property<string>("MaQuyen");

                    b.Property<string>("MatKhau");

                    b.Property<DateTime?>("NTNS");

                    b.Property<string>("Phai");

                    b.Property<string>("TenCBNV");

                    b.Property<string>("TenDangNhap");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaCBNV");

                    b.HasIndex("MaLoaiGiangVien");

                    b.HasIndex("MaQuyen");

                    b.ToTable("CBNV");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietDangKy", b =>
                {
                    b.Property<string>("MaCongViec");

                    b.Property<string>("MaPhieuDangKy");

                    b.Property<string>("DanhGiaDonVi");

                    b.Property<string>("DanhGiaTruong");

                    b.Property<string>("DiemDonVi");

                    b.Property<string>("DiemTruong");

                    b.Property<string>("NgayBatDauThucTe");

                    b.Property<string>("NgayKetThucThucTe");

                    b.Property<string>("NhanXetDonVi");

                    b.Property<string>("NhanXetTruong");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaCongViec", "MaPhieuDangKy");

                    b.HasIndex("MaPhieuDangKy");

                    b.ToTable("ChiTietDangKy");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietNhiemVu", b =>
                {
                    b.Property<string>("MaLoaiGiangVien");

                    b.Property<string>("MaNhiemVu");

                    b.Property<string>("MaNamHoc");

                    b.Property<int>("SoTietQuyDinh");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaLoaiGiangVien", "MaNhiemVu", "MaNamHoc");

                    b.HasIndex("MaNamHoc");

                    b.HasIndex("MaNhiemVu");

                    b.ToTable("ChiTietNhiemVu");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietQuanLy", b =>
                {
                    b.Property<DateTime>("NgayQuyetDinh");

                    b.Property<string>("MaCBNV");

                    b.Property<string>("MaDonVi");

                    b.Property<string>("MaChucVu");

                    b.Property<string>("ThoiHan");

                    b.Property<bool>("TrangThai");

                    b.HasKey("NgayQuyetDinh", "MaCBNV", "MaDonVi");

                    b.HasAlternateKey("NgayQuyetDinh");

                    b.HasIndex("MaCBNV");

                    b.HasIndex("MaChucVu");

                    b.HasIndex("MaDonVi");

                    b.ToTable("ChiTietQuanLy");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietThucHien", b =>
                {
                    b.Property<string>("MaCongViec");

                    b.Property<string>("MaHoTro");

                    b.Property<string>("MaPhieuDangKy");

                    b.Property<int>("MucDoHoanThanh");

                    b.Property<DateTime>("NgayXinHoTro");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaCongViec", "MaHoTro", "MaPhieuDangKy");

                    b.HasIndex("MaHoTro");

                    b.HasIndex("MaPhieuDangKy");

                    b.ToTable("ChiTietThucHien");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietToChuc", b =>
                {
                    b.Property<string>("MaCongViec");

                    b.Property<string>("MaDonVi");

                    b.Property<string>("DiaDiemToChuc");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaCongViec", "MaDonVi");

                    b.HasIndex("MaDonVi");

                    b.ToTable("ChiTietToChuc");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChucVu", b =>
                {
                    b.Property<string>("MaChucVu")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TenChucVu");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaChucVu");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.CongViec", b =>
                {
                    b.Property<string>("MaCongViec")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CapCongViec");

                    b.Property<string>("MaNhiemVu");

                    b.Property<string>("MoTaCongViec");

                    b.Property<DateTime>("NgayBatDauDuKien");

                    b.Property<DateTime>("NgayKetThucDuKien");

                    b.Property<int>("SoLuongConLai");

                    b.Property<int>("SoLuongDangKy");

                    b.Property<float>("SoTietChuan");

                    b.Property<string>("TenCongViec");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaCongViec");

                    b.HasIndex("MaNhiemVu");

                    b.ToTable("CongViec");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.DiemNghienCuuKhoaHoc", b =>
                {
                    b.Property<string>("MaCongViec");

                    b.Property<string>("SoQuyDinh");

                    b.Property<int>("Diem");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaCongViec", "SoQuyDinh");

                    b.HasIndex("SoQuyDinh");

                    b.ToTable("DiemNghienCuuKhoaHoc");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.DonVi", b =>
                {
                    b.Property<string>("MaDonVi")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DienThoai");

                    b.Property<string>("TenDonVi");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaDonVi");

                    b.ToTable("DonVi");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.HocKy", b =>
                {
                    b.Property<string>("MaHocKy")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaNamHoc");

                    b.Property<DateTime>("NgayBatDauHocKy");

                    b.Property<DateTime>("NgayKetThucHocKy");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaHocKy");

                    b.HasIndex("MaNamHoc");

                    b.ToTable("HocKy");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.HoTro", b =>
                {
                    b.Property<string>("MaHoTro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DonViTinh");

                    b.Property<string>("LoaiHoTro");

                    b.Property<string>("NguonHoTro");

                    b.Property<int>("SoLuong");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaHoTro");

                    b.ToTable("HoTro");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.LoaiGiangVien", b =>
                {
                    b.Property<string>("MaLoaiGiangVien")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BaoHiem");

                    b.Property<string>("TenLoaiGiangVien");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaLoaiGiangVien");

                    b.ToTable("LoaiGiangVien");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.LoaiQuyetDinh", b =>
                {
                    b.Property<string>("MaLoaiQuyetDinh")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TenLoaiQuyetDinh");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaLoaiQuyetDinh");

                    b.ToTable("LoaiQuyetDinh");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.MinhChung", b =>
                {
                    b.Property<string>("MaMinhChung")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaCongViec");

                    b.Property<string>("MaPhieuDangKy");

                    b.Property<DateTime>("NgayDangMinhChung");

                    b.Property<string>("TenMinhChung");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaMinhChung");

                    b.HasIndex("MaCongViec");

                    b.HasIndex("MaPhieuDangKy");

                    b.ToTable("MinhChung");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.NamHoc", b =>
                {
                    b.Property<string>("MaNamHoc")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MoTaNamHoc");

                    b.Property<DateTime>("NgayBatDauNamHoc");

                    b.Property<DateTime>("NgayKetThucNamHoc");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaNamHoc");

                    b.ToTable("NamHoc");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.NhiemVu", b =>
                {
                    b.Property<string>("MaNhiemVu")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TenNhiemVu");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaNhiemVu");

                    b.ToTable("NhiemVu");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.PhieuDangKy", b =>
                {
                    b.Property<string>("MaPhieuDangKy")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaCBNV");

                    b.Property<string>("MaHocKy");

                    b.Property<DateTime>("NgayDangKy");

                    b.Property<string>("NguoiDangKy");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaPhieuDangKy");

                    b.HasIndex("MaCBNV");

                    b.HasIndex("MaHocKy");

                    b.ToTable("PhieuDangKy");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.QuyDinh", b =>
                {
                    b.Property<string>("SoQuyDinh")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaNamHoc");

                    b.Property<DateTime>("NgayBanHanh");

                    b.Property<string>("NoiDungQuyDinh");

                    b.Property<bool>("TrangThai");

                    b.HasKey("SoQuyDinh");

                    b.HasIndex("MaNamHoc");

                    b.ToTable("QuyDinh");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.Quyen", b =>
                {
                    b.Property<string>("MaQuyen")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TenQuyen");

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaQuyen");

                    b.ToTable("Quyen");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.QuyetDinh", b =>
                {
                    b.Property<string>("SoQuyetDinh")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HinhThuc");

                    b.Property<string>("MaCBNV");

                    b.Property<string>("MaLoaiQuyetDinh");

                    b.Property<DateTime>("NgayBanHanh");

                    b.Property<string>("NoiDungQuyetDinh");

                    b.Property<int>("ThoiHan");

                    b.Property<bool>("TrangThai");

                    b.HasKey("SoQuyetDinh");

                    b.HasIndex("MaCBNV");

                    b.HasIndex("MaLoaiQuyetDinh");

                    b.ToTable("QuyetDinh");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.CBNV", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.LoaiGiangVien", "LoaiGiangVien")
                        .WithMany()
                        .HasForeignKey("MaLoaiGiangVien");

                    b.HasOne("NguyenPhuLoc.Models.Quyen", "Quyen")
                        .WithMany()
                        .HasForeignKey("MaQuyen");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietDangKy", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.CongViec", "CongViec")
                        .WithMany()
                        .HasForeignKey("MaCongViec")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NguyenPhuLoc.Models.PhieuDangKy", "PhieuDangKy")
                        .WithMany()
                        .HasForeignKey("MaPhieuDangKy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietNhiemVu", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.LoaiGiangVien", "LoaiGiangVien")
                        .WithMany()
                        .HasForeignKey("MaLoaiGiangVien")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NguyenPhuLoc.Models.NamHoc", "NamHoc")
                        .WithMany()
                        .HasForeignKey("MaNamHoc")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NguyenPhuLoc.Models.NhiemVu", "NhiemVu")
                        .WithMany()
                        .HasForeignKey("MaNhiemVu")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietQuanLy", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.CBNV", "CBNV")
                        .WithMany()
                        .HasForeignKey("MaCBNV")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NguyenPhuLoc.Models.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("MaChucVu");

                    b.HasOne("NguyenPhuLoc.Models.DonVi", "DonVi")
                        .WithMany()
                        .HasForeignKey("MaDonVi")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietThucHien", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.CongViec", "CongViec")
                        .WithMany()
                        .HasForeignKey("MaCongViec")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NguyenPhuLoc.Models.HoTro", "HoTro")
                        .WithMany()
                        .HasForeignKey("MaHoTro")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NguyenPhuLoc.Models.PhieuDangKy", "PhieuDangKy")
                        .WithMany()
                        .HasForeignKey("MaPhieuDangKy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.ChiTietToChuc", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.CongViec", "CongViec")
                        .WithMany()
                        .HasForeignKey("MaCongViec")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NguyenPhuLoc.Models.DonVi", "DonVi")
                        .WithMany()
                        .HasForeignKey("MaDonVi")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.CongViec", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.NhiemVu", "NhiemVu")
                        .WithMany()
                        .HasForeignKey("MaNhiemVu");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.DiemNghienCuuKhoaHoc", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.CongViec", "CongViec")
                        .WithMany()
                        .HasForeignKey("MaCongViec")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NguyenPhuLoc.Models.QuyDinh", "QuyDinh")
                        .WithMany()
                        .HasForeignKey("SoQuyDinh")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.HocKy", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.NamHoc", "NamHoc")
                        .WithMany()
                        .HasForeignKey("MaNamHoc");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.MinhChung", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.CongViec", "CongViec")
                        .WithMany()
                        .HasForeignKey("MaCongViec");

                    b.HasOne("NguyenPhuLoc.Models.PhieuDangKy", "PhieuDangKy")
                        .WithMany()
                        .HasForeignKey("MaPhieuDangKy");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.PhieuDangKy", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.CBNV", "CBNV")
                        .WithMany()
                        .HasForeignKey("MaCBNV");

                    b.HasOne("NguyenPhuLoc.Models.HocKy", "HocKy")
                        .WithMany()
                        .HasForeignKey("MaHocKy");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.QuyDinh", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.NamHoc", "NamHoc")
                        .WithMany()
                        .HasForeignKey("MaNamHoc");
                });

            modelBuilder.Entity("NguyenPhuLoc.Models.QuyetDinh", b =>
                {
                    b.HasOne("NguyenPhuLoc.Models.CBNV", "CBNV")
                        .WithMany()
                        .HasForeignKey("MaCBNV");

                    b.HasOne("NguyenPhuLoc.Models.LoaiQuyetDinh", "LoaiQuyetDinh")
                        .WithMany()
                        .HasForeignKey("MaLoaiQuyetDinh");
                });
#pragma warning restore 612, 618
        }
    }
}
