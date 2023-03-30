using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BAITAP_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            HOCSINH messi = new HOCSINH();
            messi.HOTEN = "Messi";
            messi.NGAYSINH = DateTime.Parse("12/19/1999");
            messi.GIOITINH = "Male";
            messi.SOCM = 097783927392;
            messi.DIEMTOAN = 3.5f;
            messi.DIEMLY = 4.5f;
            messi.DIEMHOA = 9.5f;
            messi.Diachimail = new string[] {"messi@gmail.com", "leon@yahoo.com" };
            Console.WriteLine(messi.Diachimail[0]);
            messi.XUAT();
            Console.ReadKey();
        //    HOCSINH[] danhsach;
        //    int N = 0;
        //    Console.WriteLine("Nhap so hoc sinh (N) can quan ly");
        //    N = int.Parse(Console.ReadLine());
        //    danhsach = new HOCSINH[N];
        //    for (int i = 0; i < N; i++)
        //    {
        //        HOCSINH hs
        //    }
        }
    }
}