using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHD_DTO
    {
		private int mahd;

		public int Mahd
		{
			get { return mahd; }
			set { mahd = value; }
		}
		private int mamh;
		public int Mamh
		{
			get { return mamh; }
			set { mamh = value; }
		}
		private float dongia;
		public float Dongia
		{
			get { return dongia; }
			set { dongia = value; }
		}
		private int soluong;
		public int Soluong
		{
			get { return soluong; }
			set { soluong = value; }
		}
		private float thanhtien;
		public float Thanhtien
		{
			get { return thanhtien; }
			set { thanhtien = value; }
		}


		//Thêm thuộc tính để hiện tên lên trên hóa đơn
		private string tenmh;
		public string Tenmh
		{
			get { return tenmh; }
			set { tenmh = value; }
		}

	}
}
