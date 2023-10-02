using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1_2033216515_NguyenHoangPhuc
{
    internal class TongTien
    {
        private int typeKhach;
        private int item;
        private int soLuong;

        public TongTien(int typeKhach, int item, int soLuong)
        {
            this.typeKhach = typeKhach;
            this.item = item;
            this.soLuong = soLuong;
        }

        private int[] Gia = new int[]
        {
            200000,
            180000,
            150000,
        };

        public int ThanhTien()
        {
            int sum = Gia[item] * soLuong;
            return typeKhach == 0 ? sum : sum * 85 / 100;
        }
    }
}
