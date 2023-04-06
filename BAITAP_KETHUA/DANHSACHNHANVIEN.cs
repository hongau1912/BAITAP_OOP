using System;
namespace BAITAP_KETHUA
{
	public class DANHSACHNHANVIEN
	{
		Dictionary<String, NHANVIEN> listStaff;

		public DANHSACHNHANVIEN()
		{
			this.listStaff = new Dictionary<String, NHANVIEN>();
		}

		public void NHAP()
		{
			char c = 'y';
			while (c == 'y')
			{
				NHANVIEN nv = null;
				char loai = ' ';
				Console.WriteLine("Nhap (B) bien che, (D) hop dong: ");
				loai = Convert.ToChar(Console.ReadLine().ToUpper());
				switch (loai)
				{
					case 'B':
						{
							nv = new NVBIENCHE();
							nv.NHAP();
							break;
						}
					case 'D':
						{
							nv = new NVHOPDONG();
							nv.NHAP();
							break;
						}
				} // end switch

				if (nv != null)
					this.listStaff.Add(nv.MANV, nv);
				Console.WriteLine("Nhap ky tu 'y' de tiep tuc: ");
				c = Convert.ToChar(Console.ReadLine());
			} // end while
		}

		public void XUAT()
		{
			foreach (NHANVIEN nv in listStaff.Values)
				nv.XUAT();
		}

		public NHANVIEN TIM()
		{
			Console.WriteLine("Nhap ma nv can tim: ");
			String maNv = Console.ReadLine();
			return this.listStaff[maNv];
		}

		public void XOA()
		{
			Console.WriteLine("Nhap ma nv can xoa: ");
			String maNv = Console.ReadLine();
			this.listStaff.Remove(maNv);
		}

		public void THONGKE()
		{
			int tongBienChe = 0;
			int tongHopDong = 0;
			foreach (NHANVIEN nv in this.listStaff.Values)
			{
				if (nv is NVBIENCHE)
					tongBienChe++;
				else if (nv is NVHOPDONG)
					tongHopDong++;
			}
			Console.WriteLine("Tong nhan vien BIEN CHE: " +tongBienChe);
			Console.WriteLine("Tong nhan vine HOP DONG: " +tongHopDong);
		}

		public void TONGQUYLUONG()
		{
			double tongLuong = 0;
			foreach (NHANVIEN nv in this.listStaff.Values)
			{
				if (nv is NVBIENCHE)
					tongLuong += ((NVBIENCHE)nv).THUCLINH();
				else if (nv is NVHOPDONG)
					tongLuong += ((NVHOPDONG)nv).THUCLINH();
			}
			Console.WriteLine("Tong quy luong: " +tongLuong);
		}
	}
}

