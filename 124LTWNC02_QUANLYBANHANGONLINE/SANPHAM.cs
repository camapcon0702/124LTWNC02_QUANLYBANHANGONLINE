using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _124LTWNC02_QUANLYBANHANGONLINE
{
    public class SANPHAM
    {
        private int maSanPham;
        private String tenSanPham;
        private double donGia;
        private int soLuong;
        private String hinhAnh;
        private String moTa;
        private int maDanhMuc;

        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }

        public SANPHAM(int maSanPham, string tenSanPham, double donGia, int soLuong, string hinhAnh, string moTa, int maDanhMuc)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
            HinhAnh = hinhAnh;
            MoTa = moTa;
            MaDanhMuc = maDanhMuc;
        }

        public SANPHAM()
        {
        }
    }
}