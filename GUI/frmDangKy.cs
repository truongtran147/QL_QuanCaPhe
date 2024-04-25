using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangKy : Form
    {
        private Point lastPoint;
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "" || txtUsername.Text == "" || txtMatkhau.Text == "" || txtSoDT.Text == "")
            {
                MessageBox.Show("Các mục được đánh dấu * không được bỏ trống!", "Thông báo");
                return;
            }
            if (Account_BUS.checkUsername(txtUsername.Text) != null)
            {
                MessageBox.Show("Tài khoản đăng nhập đã tồn tại!", "Thông báo");
                return;
            }
            Account_DTO account = new Account_DTO();
            account.Hoten = txtHoten.Text;
            account.Username = txtUsername.Text;
            account.Password = txtMatkhau.Text;
            account.Diachi = txtDiachi.Text;
            account.SDT = txtSoDT.Text;
            account.Loaitk = 0;

            Account_BUS.insertAccount(account);

            MessageBox.Show("Đã thêm tài khoản mới!");
            this.Close();
        }

        private void frmDangKy_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void frmDangKy_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - lastPoint.X;
                int dy = e.Y - lastPoint.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }

        //không cho nhập khoảng trắng vào tk và mk
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
