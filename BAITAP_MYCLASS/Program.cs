using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BAITAP_MYCLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            TAMGIAC tamGiac = new TAMGIAC();
            tamGiac.NHAP();
            tamGiac.XUAT();
            Console.ReadKey();
        }
    }
}