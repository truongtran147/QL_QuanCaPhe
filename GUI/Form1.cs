using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showLoaiMH();
        }

        //byte[] -> ảnh
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static string FormatCurrency(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";
            if (int.TryParse(input, out int number))
            {
                string formattedNumber = number.ToString("N0");
                return $"{formattedNumber} đ̲";
            }

            return input;
        }

        public void banTrong()
        {
            btnGopBan.Enabled = false;
            btnChuyenBan.Enabled = false;
            btnTaoHD.Enabled = true;
            btnHuyOder.Enabled = false;
            btnThanhToan.Enabled = false;
            btnInHD.Enabled = false;
            btnDonBan.Enabled = false;
            containerCTHD.Controls.Clear();
            lblTongTT.Text = "" + 0;
            //lblBan.Text = "Chọn bàn";
        }
        public void coKhach()
        {
            btnGopBan.Enabled = true;
            btnChuyenBan.Enabled = true;
            btnTaoHD.Enabled = false;
            btnHuyOder.Enabled = true;
            btnThanhToan.Enabled = true;
            btnInHD.Enabled = true;
            btnDonBan.Enabled = true;
        }

        private void showLoaiMH()
        {
            /*comboBox1.DataSource = LoaiMH_BUS.GetLoaiMH();
            comboBox1.DisplayMember = "tenloaimh";
            comboBox1.ValueMember = "maloaimh";*/
        }

        string tenban = "";
        public void loadBan()
        {
            //load ban
            if (containerBan.Controls.Count > 0)
            {
                containerBan.Controls.Clear();
            }
            List<KhuVuc_DTO> kv = new List<KhuVuc_DTO>();
            if (cboKhuVuc.SelectedIndex == 0)
                kv = KhuVuc_BUS.GetKhuVuc(-1);
            else
                kv = KhuVuc_BUS.GetKhuVuc(int.Parse(cboKhuVuc.SelectedValue.ToString()));
            List<Ban_GUI> allBan = new List<Ban_GUI>();
            for (int i = 0; i < kv.Count; i++)
            {
                Label label = new Label();
                label.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(192, 0, 0);
                label.Padding = new Padding(0, 8, 0, 0);
                label.AutoSize = false;
                label.AutoEllipsis = true;
                label.Width = containerBan.ClientSize.Width - 25;
                label.Text = kv[i].Tenkv.ToUpper();
                containerBan.Controls.Add(label);
                List<Ban_DTO> lstBan = Ban_BUS.GetBan(kv[i].Makv);

                Ban_GUI[] listBanGUI_khuvuc = new Ban_GUI[lstBan.Count];
                for (int j = 0; j < listBanGUI_khuvuc.Length; j++)
                {
                    listBanGUI_khuvuc[j] = new Ban_GUI();
                    listBanGUI_khuvuc[j].BAN = lstBan[j];
                    containerBan.Controls.Add(listBanGUI_khuvuc[j]);
                    //listBanGUI_khuvuc[j].Margin = new Padding(5,0,5,10);
                    foreach (Control item in listBanGUI_khuvuc[j].Controls)
                    {
                        //Xử lý sự kiện click cho các control con trong usercontrol ở đây
                        item.Click += listBanGUI_khuvuc[j].Control_Click;
                    }
                    listBanGUI_khuvuc[j].Click += ban_GUI_Click;
                    if (listBanGUI_khuvuc[j].BAN.Maban == maban)
                        listBanGUI_khuvuc[j].PerformClick();
                    //if (listBanGUI_khuvuc[j].BAN.Trangthai == "Trống") ;
                }
                allBan.AddRange(listBanGUI_khuvuc);
            }
            
        }

        public void loadMH()
        {
            if (containerOder.Controls.Count > 0)
            {
                containerOder.Controls.Clear();
            }
            string mamathang = "";
            /*if (comboBox1.SelectedIndex != 0)
            {
                mamathang = comboBox1.SelectedValue.ToString();
            }*/

            List<MatHang_DTO> lstMH = MatHang_BUS.GetMatHang(mamathang);
            if (lstMH != null)
            {
                MatHang_GUI[] listMH = new MatHang_GUI[lstMH.Count];
                for (int i = 0; i < listMH.Length; i++)
                {
                    listMH[i] = new MatHang_GUI();
                    listMH[i].MH = lstMH[i];
                    listMH[i].AnhMH = byteArrayToImage(lstMH[i].Anhmh);
                    listMH[i].Click += matHang_GUI_Click;
                    containerOder.Controls.Add(listMH[i]);
                    foreach (Control item in listMH[i].Controls)
                    {
                        //Xử lý sự kiện click cho các control con trong usercontrol ở đây
                        item.Click += listMH[i].Control_Click;
                    }

                }
            }
        }

        private float tongtt = 0;
        private float giam = 0;
        private int mahd, maban;
        private Ban_GUI ban = new Ban_GUI();

        public void loadHD()
        {
            tongtt = 0;
            lblTongTT.Text = FormatCurrency(tongtt.ToString());

            containerCTHD.Controls.Clear();
            hdtheoban = HoaDon_BUS.GetHoaDonTheoBan(maban);
            mahd = hdtheoban.Mahd;
            List<ChiTietHD_DTO> listCTHDtheoma = ChiTietHD_BUS.GetCTHD(mahd);

            if (listCTHDtheoma != null)
            {
                ChiTietHD_GUI[] listCTHDGUI = new ChiTietHD_GUI[listCTHDtheoma.Count];
                for (int i = 0; i < listCTHDtheoma.Count; i++)
                {
                    listCTHDGUI[i] = new ChiTietHD_GUI();
                    listCTHDGUI[i].CTHD = listCTHDtheoma[i];
                    foreach (Control item in listCTHDGUI[i].Controls)
                    {
                        if (item.Name == "btnTangSL" || item.Name == "btnGiamSL" || item.Name == "btnXoaCTHD")
                        {
                            item.Click += (sender, e) => { loadHD(); };
                        }
                    }
                    tongtt += listCTHDtheoma[i].Thanhtien;
                    containerCTHD.Controls.Add(listCTHDGUI[i]);
                }
                lblTongTT.Text = FormatCurrency(tongtt.ToString());
                /*if (containerCTHD.Controls.Count > 6)
                    containerCTHD.Padding = new Padding(3,0,0,0);
                else containerCTHD.Padding = new Padding(10,0,0,0);*/
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            KhuVuc_DTO all = new KhuVuc_DTO();
            all.Makv = -1;
            all.Tenkv = "Tất cả";
            List<KhuVuc_DTO> lstKhuVuc = new List<KhuVuc_DTO>();
            lstKhuVuc.Add(all);
            lstKhuVuc.AddRange(KhuVuc_BUS.GetKhuVuc(-1));
            cboKhuVuc.DataSource = lstKhuVuc;
            cboKhuVuc.SelectedIndex = 0;
            cboKhuVuc.ValueMember = "Makv";
            cboKhuVuc.DisplayMember = "Tenkv";
            Button hiddenButton = new Button();
            hiddenButton.Visible = false;
            this.Controls.Add(hiddenButton);
            //load do an nuoc uong
            loadMH();
            //load ban
            loadBan();
        }



        private void matHang_GUI_Click(object sender, EventArgs e)
        {
            if (lblBan.Text == "Chọn bàn")
            {
                MessageBox.Show("Chưa chọn bàn để gọi món", "Thông báo!");
                return;
            }
            else if (bandangchon.Trangthai == "Trống")
            {
                MessageBox.Show("Mở hóa đơn (Gọi món) để thêm hàng vào Order", "Thông báo!");
                return;
            }    
            MatHang_GUI matHang_GUI1 = sender as MatHang_GUI;
            if (ChiTietHD_BUS.DaTonTai(mahd, matHang_GUI1.MH.MaMH) == false)
            {
                ChiTietHD_DTO themMon = new ChiTietHD_DTO();
                themMon.Mahd = mahd;
                themMon.Mamh = matHang_GUI1.MH.MaMH;
                themMon.Dongia = matHang_GUI1.MH.DonGia;
                themMon.Soluong = 1;
                themMon.Thanhtien = matHang_GUI1.MH.DonGia;
                themMon.Tenmh = "";
                ChiTietHD_BUS.InsertCTHD(themMon);
            }
            loadHD();
        }



        private Ban_DTO bandangchon = new Ban_DTO();
        HoaDon_DTO hdtheoban = new HoaDon_DTO();
        private void ban_GUI_Click(object sender, EventArgs e)
        {
            ThaoTacBan(0);
            tongtt = 0;
            txtGiam.Text = "";
            Ban_GUI ban_GUI = sender as Ban_GUI;
            lblBan.Text = ban_GUI.BAN.Tenban;
            maban = ban_GUI.BAN.Maban;
            bandangchon = ban_GUI.BAN;

            if (ban_GUI.BAN.Trangthai == "Có khách")
            {
                coKhach();
                loadHD();
            }
            else
            {
                banTrong();
                lblBan.Text = ban_GUI.BAN.Tenban;
            }

            //Xử lý highlight cho bàn đang chọn
            foreach (Control control in containerBan.Controls)
            {
                if (control is Ban_GUI)
                {
                    Ban_GUI ban = (Ban_GUI)control;
                    ban.unCheck();
                    if (ban.BAN.Tenban == lblBan.Text)
                    {
                        ban.PerformCheck();
                    }
                }
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            HoaDon_BUS.InsertHoaDon(maban);
            bandangchon.Trangthai = "Có khách";
            Ban_BUS.UpdateBan(bandangchon);
            loadBan();
            foreach (Control ctrl in containerBan.Controls)
            {
                if (ctrl is Ban_GUI)
                {
                    Ban_GUI ban = (Ban_GUI)ctrl;
                    if (ban.BAN.Tenban == lblBan.Text)
                        ban.PerformCheck();
                }
            }
            coKhach();

            foreach (MatHang_GUI uc in containerOder.Controls)
            {
                //uc.PerformClick();
                return;
            }
        }

        private void btnHuyOder_Click(object sender, EventArgs e)
        {
            lblBan.Text = "Chọn bàn";
            bandangchon.Trangthai = "Trống";
            Ban_BUS.UpdateBan(bandangchon);
            HoaDon_BUS.DeleteHoaDon(mahd);
            banTrong();
            loadBan();
            btnHuyOder.Enabled = false;
        }

        private void txtGiam_TextChanged(object sender, EventArgs e)
        {
            if (txtGiam.Text != "")
                giam = float.Parse(txtGiam.Text);
            else
                giam = 0;
            loadHD();
            tongtt -= giam;
            lblTongTT.Text = FormatCurrency(tongtt.ToString());
        }

        private void txtGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập vào có phải là số hay không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ThaoTacBan_GUI_Disposed(object sender, EventArgs e)
        {
            maban = thaotacBan_GUI.Target;
            loadBan();
            btnTaoHD.Enabled = false;
            MessageBox.Show("Thành công", "Thông báo");
        }


        private ThaoTacBan_GUI thaotacBan_GUI;
        private void btnGopBan_Click(object sender, EventArgs e)
        {
            ThaoTacBan(1);
        }
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            ThaoTacBan(2);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (ChiTietHD_BUS.GetCTHD(mahd) != null)
            {
                HoaDon_DTO hdonTT = HoaDon_BUS.GetHoaDonTheoBan(bandangchon.Maban);
                if (HoaDon_BUS.UpdateHoaDon(hdonTT.Mahd, giam, tongtt))
                    MessageBox.Show("Đã lưu hóa đơn");
            }
            else
                MessageBox.Show("Không được lưu hóa đơn trống!", "Thông báo");
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (HoaDon_BUS.GetHoaDonTheoMa(mahd) != null)
            {
                frmXuatHoaDon frmxuatHD = new frmXuatHoaDon();
                frmxuatHD.Mahd = mahd;
                frmxuatHD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không được in hóa đơn trống!", "Thông báo");
            }
        }

        private void btnDonBan_Click(object sender, EventArgs e)
        {
            if (HoaDon_BUS.GetHoaDonTheoMa(mahd) != null)
            {
                bandangchon.Trangthai = "Trống";
                Ban_BUS.UpdateBan(bandangchon);
                banTrong();
                loadBan();
            }
            else
            {
                MessageBox.Show("Bàn đang được phục vụ, không thể dọn", "Thông báo");
            }
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBan();
        }

        private void ThaoTacBan(int option)
        {
            foreach (Control control in this.Controls)
            {
                if (control is ThaoTacBan_GUI)
                {
                    control.Hide();
                }
            }
            if (option == 0) //0: đóng thao tác bàn, 1: Gọp bàn, 2: Chuyển bàn.
            {
                return;
            }
            thaotacBan_GUI = new ThaoTacBan_GUI();
            thaotacBan_GUI.Disposed += ThaoTacBan_GUI_Disposed;
            thaotacBan_GUI.Bandangchon = bandangchon;
            thaotacBan_GUI.Option = option;
            // Đặt vị trí của User Control
            if (option == 1)
                thaotacBan_GUI.Location = new Point(btnGopBan.Location.X + btnGopBan.Width, btnGopBan.Location.Y);
            else
                thaotacBan_GUI.Location = new Point(btnChuyenBan.Location.X + btnChuyenBan.Width, btnChuyenBan.Location.Y);

            // Thêm User Control vào Form
            this.Controls.Add(thaotacBan_GUI);
            thaotacBan_GUI.BringToFront();

            // Hiển thị User Control

            thaotacBan_GUI.Show();
            
        }

    }
}
