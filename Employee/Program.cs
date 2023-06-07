using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        public static void Main()
        {
            NhanVienBanHang nv1 = new NhanVienBanHang("Vu Thu Hien", "Dai La, Hai Ba Trung, Ha Noi", 1000);
            nv1.HienThi();

            CongNhan nv2 = new CongNhan("Vu Tram Anh", "Quan Nhan, Thanh Xuan, Ha Noi", 90);
            nv2.HienThi();
        }
    }
}