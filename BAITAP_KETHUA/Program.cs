using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BAITAP_KETHUA
{
    class Program
    {
        static DANHSACHNHANVIEN danhsach;
        static void MENU()
        {
            Console.WriteLine("Nhap tu 1- 6 de thuc hien chuc nang: ");
            Console.WriteLine("1. Nhap nv: ");
            Console.WriteLine("2. Xuat nv: ");
            Console.WriteLine("3. Tim nv: ");
            Console.WriteLine("4. Xoa nv: ");
            Console.WriteLine("5. Thong ke nv: ");
            Console.WriteLine("6. Tinh tong quy luong: ");
            int menu = 0;
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        danhsach.NHAP();
                        break;
                    }
                case 2:
                    {
                        danhsach.XUAT();
                        break;
                    }
                case 3:
                    {
                        danhsach.TIM();
                        break;
                    }
                case 4:
                    {
                        danhsach.XOA();
                        break;
                    }
                case 5:
                    {
                        danhsach.THONGKE();
                        break;
                    }
                case 6:
                    {
                        danhsach.TONGQUYLUONG();
                        break;
                    }

            }
        }
        static void Main(string[] args)
        {
            danhsach = new DANHSACHNHANVIEN();
            char c = 'y';
            while (c == 'y')
            {
                MENU();
                Console.WriteLine("Nahp ky tu 'y' de tro ve MENU(): ");
                c = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            Console.ReadKey();
        }
    }
}