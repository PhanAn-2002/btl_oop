﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_1
{
    public class CongTy
    {
        private List<NhanVien> DanhSach = new List<NhanVien>();

        internal List<NhanVien> _DANHSACH
        {
          get { return DanhSach; }
          set { DanhSach = value; }
        }

        public void SXTheoLuong(char phanloai)
        {

        }

        public void SXTheoTuoi(char phanloai) // phanloai: sắp tăng hay giảm 
        {

        }

        // Neu trung tra ra false
        public bool KiemTraMaBiTrung(string maso)
        {
            foreach (NhanVien item in DanhSach)
            {
                if (item._MASO == maso)
                {
                    return false; // bị trùng
                }
            }
            return true;
        }
    }
}
