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
    public partial class Ban_GUI : UserControl
    {

        private Ban_DTO ban;
        [Category("Data")]
        public Ban_DTO BAN
        {
            get { return ban; }
            set { ban = value; }
        }
        public Ban_GUI()
        {
            InitializeComponent();
            background.Checked = false;
        }

        private void Ban_GUI_Load(object sender, EventArgs e)
        {
            label1.Text = ban.Tenban;
            label2.Text = "(" + ban.Trangthai + ")";

            if (ban.Trangthai == "Có khách")
            {
                background.FillColor = Color.FromArgb(255, 192, 192);
                label1.BackColor = Color.FromArgb(255, 192, 192);
                label2.BackColor = Color.FromArgb(255, 192, 192);
            }
            else
            {
                background.FillColor = Color.LightCyan;
                label1.BackColor = Color.LightCyan;
                label2.BackColor = Color.LightCyan;
            }
        }
        internal void Control_Click(object sender, EventArgs e)
        {
            // Khi một control con được click, chuyển tiếp sự kiện click lên UserControl
            OnClick(e);
        }

        public void unCheck()
        {
            if (overlay.Checked)
                overlay.Checked = false;
        }

        public void PerformCheck()
        {
            overlay.Checked = true;
        }
        public void PerformClick()
        {
            overlay.PerformClick();
        }

        private void overlay_CheckedChanged(object sender, EventArgs e)
        {
            /*if (!background.Checked)
            {
                overlay.Dock = DockStyle.Fill;
                overlay.Location = new Point(-5, -5);
                overlay.Size = new Size(150, 150);
            }
            else
            {
                //overlay.Dock = DockStyle.Fill;
                overlay.BorderColor = Color.FromArgb(0, 192, 0);
                //overlay.BorderRadius = 2;
            }*/
        }
    }
}
