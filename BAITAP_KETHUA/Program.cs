using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BAITAP_KETHUA
{
    class Program
    {
        static void Main(string[] args)
        {
            NVBIENCHE bc1 = new NVBIENCHE();
            NVHOPDONG hd1 = new NVHOPDONG();
            bc1.NHAP();
            bc1.XUAT();
            hd1.NHAP();
            hd1.XUAT();
            Console.ReadKey();
        }
    }
}