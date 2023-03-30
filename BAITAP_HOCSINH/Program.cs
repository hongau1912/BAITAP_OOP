using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BAITAP_HOCSINH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BT_HOCSINH.SOLUONGHOCSINH);
            BT_HOCSINH lva = new BT_HOCSINH();
            lva.HOTEN = "Le Van A";
            lva.GIOITINH = "male";
            lva.SOCM = 432242429;
            lva.NGAYSINH = DateTime.Parse("11/11/2000");
            lva.DIEMTOAN = 9.0f;
            lva.DIEMLY = 7.5f;
            lva.DIEMHOA = 8.5f;
            lva.DIACHIEMAIL = new string[] { "lva@gmail.com", "lva1@gmail.com" };
            Console.WriteLine(lva.DIACHIEMAIL[0]);

            lva[0] = "lva2@gmail.com";
            lva[1] = "lva3@gmail.com";
            Console.WriteLine(lva[0]);

            lva["A"] = 344335565;
            lva["B"] = 844885594;
            Console.WriteLine(lva["B"]);
            lva.XUAT();

            BT_HOCSINH lvb = new BT_HOCSINH("Le Van B", "Female", 324432453, DateTime.Parse("08/22/2001"), 6.7f, 8.8f, 6.9f);
            lvb.XUAT();

            BT_HOCSINH lvc = new BT_HOCSINH(lvb);
            lvc.XUAT();

            BT_HOCSINH lvd = new BT_HOCSINH();
            lvd.NHAP();
            lvd.XUAT();

            BT_HOCSINH[] danhsach;
            int N = 0;
            Console.WriteLine("Nhap so luong hs (N) can quan ly: ");
            N = int.Parse(Console.ReadLine());
            danhsach = new BT_HOCSINH[N];
            for (int i = 0; i < N; i++)
            {
                BT_HOCSINH hs = new BT_HOCSINH();
                hs.NHAP();
                danhsach[i] = hs;
            }
            Console.ReadKey();
        }
    }
}