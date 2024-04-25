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
    public partial class ThaoTacBan_GUI : UserControl
    {
        private int option;

        public int Option
        {
            get { return option; }
            set { option = value; }
        }


        private Ban_DTO bandangchon;

        public Ban_DTO Bandangchon
        {
            get { return bandangchon; }
            set { bandangchon = value; }
        }

        private int target;

        public int Target
        {
            get { return target; }
            set { target = value; }
        }



        public ThaoTacBan_GUI()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (option == 1)
            {
                if (cboBan.Items.Count == 0)
                    return;
                HoaDon_DTO hdDau = HoaDon_BUS.GetHoaDonTheoBan(bandangchon.Maban);
                HoaDon_DTO hdCuoi = HoaDon_BUS.GetHoaDonTheoBan(int.Parse(cboBan.SelectedValue.ToString()));
                if (MessageBox.Show($"Bạn có muốn gộp hóa đơn của {bandangchon.Tenban} vào {cboBan.Text} không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (HoaDon_BUS.GopHoaDon(hdDau.Mahd, hdCuoi.Mahd))
                    {
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("Có lỗi xảy ra", "Thông báo");
                }
                else
                    return;
            }
            else
            {
                if (cboBan.Items.Count == 0)
                    return;
                HoaDon_DTO hd = HoaDon_BUS.GetHoaDonTheoBan(bandangchon.Maban);
                if (MessageBox.Show($"Bạn có muốn chuyển hóa đơn của {bandangchon.Tenban} qua {cboBan.Text} không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (HoaDon_BUS.ChuyenBan(hd.Mahd, bandangchon.Maban, int.Parse(cboBan.SelectedValue.ToString())))
                    {
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("Có lỗi xảy ra", "Thông báo");
                }
                else
                    return;

            }
        }

        private void GopBan_GUI_Load(object sender, EventArgs e)
        {
            string tenban;
            List<Ban_DTO> lstBan = Ban_BUS.GetBan(-1);
            if (option == 1)
            {
                lstBan.RemoveAll(item => item.Trangthai == "Trống");
                lstBan.RemoveAll(item => item.Maban == bandangchon.Maban);
                label1.Text = "Bạn muốn gộp HĐ của " + bandangchon.Tenban;
                label2.Text = "vào:";
            }
            else
            {
                lstBan.RemoveAll(item => item.Trangthai == "Có khách");
                lstBan.RemoveAll(item => item.Maban == bandangchon.Maban);
                label1.Text = "Bạn muốn chuyển HĐ của " + bandangchon.Tenban;
                label2.Text = "qua:";
            }
            cboBan.DataSource = lstBan;
            cboBan.DisplayMember = "Tenban";
            cboBan.ValueMember = "Maban";
            cboBan.SelectedIndex = -1;
        }

        private void cboBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboBan.SelectedIndex != -1)
                {
                    target = int.Parse(cboBan.SelectedValue.ToString());
                    btnXacNhan.Enabled = true;
                }
            }
            catch { return; }
        }
    }
}
