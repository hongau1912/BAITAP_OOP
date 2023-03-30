using System;
namespace NHANVIEN
{
	public class DANHSACH
	{
		private Dictionary<String, NHANVIEN> listStaff;

		public DANHSACH()
		{
			listStaff = new Dictionary<String, NHANVIEN>();
		}
		public void NHAP()
		{
			char t = 'y';
			while (t == 'y')
			{
				NHANVIEN nv = new NHANVIEN();
				nv.NHAP();
				listStaff.Add(nv.MANV, nv);
				Console.WriteLine("Nhap ky tu y de tiep tuc: ");
				t = Convert.ToChar(Console.ReadLine());
			}
		}

		public void XUAT()
		{
			foreach (NHANVIEN nv in listStaff.Values)
				nv.XUAT();
		}

		public NHANVIEN TIM()
		{
			Console.WriteLine("Nhap ma nv: ");
			string MANV = Console.ReadLine();
			return this.listStaff[MANV];
		}

		public void XOA()
		{
			Console.WriteLine("Nhap ma nv can xoa: ");
			String MANV = Console.ReadLine();
			listStaff.Remove(MANV);
		}
	}
}

