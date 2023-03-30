using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NHANVIEN
{
    class Program
    {
        static void Main(string[] args)
        {
            NHANVIEN nv1 = new NHANVIEN();
            //nv1.MANV = "01";
            //nv1.HOTEN = "Le Van A";
            //nv1.NGAYSINH = DateTime.Parse("12/19/1999");
            //nv1.GIOITINH = "Male";
            //nv1.SOCM = 3224553235;
            //nv1.NGAYVAO = DateTime.Parse("01/01/2015");
            //nv1.DIACHI = "Quang Nam";
            //nv1.HESOLUONG = 1;
            //nv1.XUAT();

            //NHANVIEN nv2 = new NHANVIEN();
            //nv2.NHAP();
            //nv2.XUAT();
            DANHSACH ds = new DANHSACH();
            ds.NHAP();
            ds.XUAT();
            Console.ReadKey();
        }
    }
}