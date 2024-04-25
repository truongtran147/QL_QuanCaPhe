using BUS;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmHeThongChinh : Form
    {

        public frmHeThongChinh()
        {
            InitializeComponent();
        }

        private void menuBanHang_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.TopLevel = false;
            container.Controls.Add(frm1);
            frm1.Dock = DockStyle.Fill;
            frm1.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Hiển thị ProgressBar và thiết lập giá trị khởi đầu
            guna2ProgressBar1.Visible = true;
            guna2ProgressBar1.Style = ProgressBarStyle.Marquee;

            // Thực hiện tác vụ trong một luồng khác để không làm đóng băng giao diện người dùng
            await Task.Run(() =>
            {
                // Thực hiện kiểm tra kết nối và đợi một khoảng thời gian giả định
                System.Threading.Thread.Sleep(1000);
                bool isConnected = Account_BUS.TestConnection(textBox1.Text);

                // Ẩn ProgressBar sau khi hoàn thành tác vụ
                this.Invoke((MethodInvoker)delegate
                {
                    guna2ProgressBar1.Visible = false;
                    // Hiển thị thông báo kết quả
                    if (isConnected)
                        MessageBox.Show("Kết nối thành công");
                    else
                        MessageBox.Show("Fail to connection");
                });
            });
        }

        private void menu_i_dsBan_Click(object sender, EventArgs e)
        {

        }
    }
}
