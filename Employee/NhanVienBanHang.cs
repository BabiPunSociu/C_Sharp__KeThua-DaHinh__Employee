using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class NhanVienBanHang : NhanVien
    {
        private int SoLuongBanDuoc;

        public NhanVienBanHang(string ten, string diachi, int soLuongBanDuoc) : base(ten, diachi)
        {
            SoLuongBanDuoc = soLuongBanDuoc;
        }

        public override double TinhLuong()
        {
            return SoLuongBanDuoc;
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
