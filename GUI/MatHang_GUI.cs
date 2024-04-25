using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class MatHang_GUI : UserControl
    {
        public MatHang_GUI()
        {
            InitializeComponent();
            
        }

        private MatHang_DTO mh;
        [Category("Data")]
        public MatHang_DTO MH
        {
            get { return mh; }
            set { mh = value; }
        }

        private System.Drawing.Image anhMH;
        [Category("Data")]
        public System.Drawing.Image AnhMH
        {
            get { return anhMH; }
            set { anhMH = value; picAnhMH.Image = value; }
        }

        /*
        // Xử lý sự kiện click cho UserControl
        private void MatHang_GUI_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện click của UserControl
            OnClick(e);
        }*/

        // Xử lý sự kiện click của các control con
        internal void Control_Click(object sender, EventArgs e)
        {
            // Khi một control con được click, chuyển tiếp sự kiện click lên UserControl
            OnClick(e);
        }

        private void txtTenMH_MouseDown(object sender, MouseEventArgs e)
        {
            lblDonGia.Focus();
        }

        private void MatHang_GUI_Load(object sender, EventArgs e)
        {
            txtTenMH.Text = mh.TenMH;
            lblDonGia.Text = FormatCurrency(mh.DonGia.ToString());
            txtTenMH.SelectionAlignment = HorizontalAlignment.Center;
            if (txtTenMH.GetLineFromCharIndex(txtTenMH.TextLength) + 1 == 1)
            {
                txtTenMH.Location = new Point(-1, 120);
            }
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

        private void MatHang_GUI_BackColorChanged(object sender, EventArgs e)
        {
            txtTenMH.BackColor = this.BackColor;
        }

        public void PerformClick()
        {
            overlay.PerformClick();
        }
    }
}
