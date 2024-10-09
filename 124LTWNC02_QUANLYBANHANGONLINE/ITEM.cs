using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _124LTWNC02_QUANLYBANHANGONLINE
{
    public class ITEM
    {
        private String masanpham;
        private String tensanpham;
        private String hinhanh;
        private int soluong; 
        private double dongia;

        public string Masanpham { get => masanpham; set => masanpham = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public double THANHTIEN
        {
            get { return this.soluong * this.dongia; }
        }

        public ITEM(string masanpham, string tensanpham, string hinhanh, int soluong, double dongia)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.hinhanh = hinhanh;
            this.soluong = soluong;
            this.dongia = dongia;
        }

        public ITEM()
        {
        }
    }
}