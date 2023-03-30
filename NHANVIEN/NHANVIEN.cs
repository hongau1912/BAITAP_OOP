using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NHANVIEN
{
	public class NHANVIEN
	{
		private String maNv; // trường dữ liệu (Data field)
		private String hoTen;
		private DateTime ngaySinh;
		private String gioiTinh;
		private long soCm;
		private DateTime ngayVao;
		private String diaChi;
        private Double heSoLuong;
        private const Double luongCoBan = 1490000;

		public String MANV // thuộc tính
		{
			set { this.maNv = value; } // write data
			get { return this.maNv; } // read data
		}

        public String HOTEN
        {
            set { this.hoTen = value; }
            get { return this.hoTen; }
        }

        public DateTime NGAYSINH
        {
            set { this.ngaySinh = value; }
            get { return this.ngaySinh; }
        }

        public String GIOITINH
        {
            set { this.gioiTinh = value; }
            get { return this.gioiTinh; }
        }

        public long SOCM
        {
            set { this.soCm = value; }
            get { return this.soCm; }
        }

        public DateTime NGAYVAO
        {
            set { this.ngayVao = value; }
            get { return this.ngayVao; }
        }

        public String DIACHI
        {
            set { this.diaChi = value; }
            get { return this.diaChi; }
        }
        public Double HESOLUONG
        {
            set { this.heSoLuong = value; }
            get { return this.heSoLuong; }
        }
        public NHANVIEN() // hàm khởi tạo không đối
		{
		}
        public NHANVIEN(String maNv, String hoTen, DateTime ngaySinh, String gioiTinh, long soCm, DateTime ngayVao, String diaChi) // hàm khởi tạo có đối
        {
            this.maNv = maNv;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.soCm = soCm;
            this.ngayVao = ngayVao;
            this.diaChi = diaChi;
        }
        public void NHAP()
        {
            Console.WriteLine("maNv: ");
            this.maNv = Console.ReadLine();
            Console.WriteLine("hoTen: ");
            this.hoTen = Console.ReadLine();
            Console.WriteLine("ngaySinh: ");
            this.ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("gioiTinh: ");
            this.gioiTinh = Console.ReadLine();
            Console.WriteLine("soCm: ");
            this.soCm = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("ngayVao: ");
            this.ngayVao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("diaChi: ");
            this.diaChi = Console.ReadLine();
            Console.WriteLine("heSoLuong: ");
            this.heSoLuong = Convert.ToInt64(Console.ReadLine());
        }

        public void XUAT()
        {
            Console.WriteLine("maNv: " +this.maNv);
            Console.WriteLine("hoTen: " +this.hoTen);
            Console.WriteLine("ngaySinh: " +this.ngaySinh.ToString("dd/mm/yyyy"));
            Console.WriteLine("gioiTinh: " +this.gioiTinh);
            Console.WriteLine("soCm: " +this.soCm);
            Console.WriteLine("ngayVao: " +this.ngayVao);
            Console.WriteLine("diaChi: " +this.diaChi);
            Console.WriteLine("thamNien: " +THAMNIEN());
            Console.WriteLine("thucLinh: " +THUCLINH());
        }
        public int THAMNIEN()
        {
            DateTime todayDate = DateTime.Today;
            return (int) ((todayDate - this.ngayVao).TotalDays/365.242199);
        }

        public double THUCLINH()
        {
            if (THAMNIEN() >= 10)
                return (this.heSoLuong * luongCoBan + 500000);
            else
                return (this.heSoLuong * luongCoBan + 2000000);
        }
	}
}

