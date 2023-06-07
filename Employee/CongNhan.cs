using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class CongNhan : NhanVien
    {
        private int sanPham;

        public CongNhan(string Ten, string diaChi, int sanPham) : base(Ten, diaChi)
        {
            this.sanPham = sanPham;
        }

        public override double TinhLuong()
        {
            return sanPham;
        }
        public override void HienThi()
        {
            Console.WriteLine("Name: " + Ten);
            Console.WriteLine("Address: " + diaChi);
            Console.WriteLine("Luong: " + TinhLuong());
            Console.WriteLine("=============================");
        }
    }
}
