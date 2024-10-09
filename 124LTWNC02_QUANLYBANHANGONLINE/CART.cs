using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _124LTWNC02_QUANLYBANHANGONLINE
{
    public class CART
    {
        Dictionary<string, ITEM> listcarts;

        public Dictionary<string, ITEM> Listcarts { get => listcarts; set => listcarts = value; }

        public CART() {
            listcarts = new Dictionary<string, ITEM>();
        }

        public void AddCart(String masanpham, string tensanpham, string hinhanh, int soluong, double dongia)
        {
            ITEM item = new ITEM(masanpham, tensanpham, hinhanh, soluong, dongia);

            if (listcarts.ContainsKey(item.Masanpham))
                listcarts[item.Masanpham].Soluong += item.Soluong;
            else
                listcarts.Add(item.Masanpham, item);
        }
        public void RemoveCart(String masanpham)
        {
            listcarts.Remove(masanpham);
        }
        public double TotalBill()
        {
            double total = 0;
            foreach (ITEM item in listcarts.Values)
                total += item.THANHTIEN;
            return total;
        }
    }
}