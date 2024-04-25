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
    public partial class frmDangNhap : Form
    {
        private Point lastPoint;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        frmDangKy fDangKy = new frmDangKy();

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                guna2Button2.Image = Properties.Resources.invisible;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                guna2Button2.Image = Properties.Resources.visible;
            }
        }

        private void linkTaoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            fDangKy.ShowDialog();
            this.Show();
        }

        private void frmDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void frmDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - lastPoint.X;
                int dy = e.Y - lastPoint.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Account_DTO acc = new Account_DTO();
            acc = Account_BUS.checkAccount(txtUsername.Text, txtPassword.Text);
            if (acc == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, hãy kiểm tra lại", "Thông báo!");
                return;
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo!");

            } 
                
        }
    }
}
