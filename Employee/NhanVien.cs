using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    abstract class NhanVien
    {
        protected string Ten, diaChi;

        public NhanVien(string ten, string diaChi)
        {
            Ten = ten;
            this.diaChi = diaChi;
        }

        public abstract double TinhLuong();
        public abstract void HienThi();
    }
}
