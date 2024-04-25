using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietHD_GUI : UserControl
    {
        private ChiTietHD_DTO cthd;
        [Category("Data")]
        public ChiTietHD_DTO CTHD
        {
            get { return cthd; }
            set { cthd = value; }
        }
        public ChiTietHD_GUI()
        {
            InitializeComponent();
        }

        private void ChiTietHD_GUI_Load(object sender, EventArgs e)
        {
            lblTenMon.Text = cthd.Tenmh;
            txtSoLuong.Text = cthd.Soluong.ToString();
            lblGia.Text = FormatCurrency(cthd.Dongia.ToString());
            lblThanhTien.Text = FormatCurrency(cthd.Thanhtien.ToString());
        }

        public static string FormatCurrency(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";
            // Chuyển chuỗi sang số và định dạng lại dưới dạng tiền tệ
            if (int.TryParse(input, out int number))
            {
                string formattedNumber = number.ToString("N0");
                return $"{formattedNumber} đ̲";
            }

            return input;
        }

        int sluong;
        private void btnGiamSL_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSoLuong.Text) == 1)
            {
                MessageBox.Show("Đã đạt số lượng tối thiểu", "Thông báo!");
                return;
            }

            sluong = int.Parse(txtSoLuong.Text) - 1;
            txtSoLuong.Text = sluong.ToString();
        }

        private void btnTangSL_Click(object sender, EventArgs e)
        {
            sluong = int.Parse(txtSoLuong.Text) + 1;
            txtSoLuong.Text = sluong.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            sluong = int.Parse(txtSoLuong.Text);
            if (sluong != cthd.Soluong)
            {
                cthd.Soluong = sluong;
                cthd.Thanhtien = sluong * cthd.Dongia;
                lblThanhTien.Text = FormatCurrency(cthd.Thanhtien.ToString());
                bool kq = ChiTietHD_BUS.UpdateCTHD(cthd);
            }    
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            ChiTietHD_BUS.DeleteCTHD(cthd);
        }
    }
}
