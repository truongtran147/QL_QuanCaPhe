using BUS;
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
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void dongThaoTacKV()
        {
            panel1.Visible = false;
            txtTenKV.Text = "";
            btnThemKV.Enabled = true;
            dgvKhuVuc.Enabled = true;
        }

        private void moThaoTacKV()
        {
            panel1.Visible = true;
            dgvKhuVuc.Enabled = false;
            txtTenKV.Focus();
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ban' table. You can move, or remove it, as needed.
            this.banTableAdapter.Fill(this.dataSet1.ban);
            // TODO: This line of code loads data into the 'dataSet1.khuvuc' table. You can move, or remove it, as needed.
            this.khuvucTableAdapter.Fill(this.dataSet1.khuvuc);


        }

        private void btnThemKV_Click(object sender, EventArgs e)
        {
            /*string s = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value?.ToString();
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("Tên khu vực không được để trống!","Thông báo");
                return;
            }*/
            khuvucBindingSource.AddNew();
            btnThemKV.Enabled = false;
            moThaoTacKV();
        }

        private void btnLuuKV_Click(object sender, EventArgs e)
        {
            try
            {
                khuvucTableAdapter.Update(dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dongThaoTacKV();
            this.khuvucTableAdapter.Fill(this.dataSet1.khuvuc);
        }

        int indexRowKV;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKhuVuc.Columns[2].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu của dòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (KhuVuc_BUS.checkDeleteKhuVuc(int.Parse(dgvKhuVuc.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        khuvucBindingSource.RemoveCurrent();
                    }
                    else
                        MessageBox.Show("Không thể xóa khu vực do có bàn liên kết đến", "Thông báo");
                }
            }
            if (e.ColumnIndex == dgvKhuVuc.Columns[3].Index && e.RowIndex >= 0)
            {
                moThaoTacKV();
                txtTenKV.Text = dgvKhuVuc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenKV.SelectionStart = txtTenKV.Text.Length;
                indexRowKV = e.RowIndex;
            }
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTenKV.Text == "")
            {
                MessageBox.Show("Tên khu vực không được bỏ trống", "Thông báo");
                return;
            }    
            if (btnThemKV.Enabled == false)
            {
                khuvucBindingSource.RemoveAt(dgvKhuVuc.RowCount - 1);
                DataRow newRow = dataSet1.Tables["khuvuc"].NewRow();
                newRow["tenkv"] = txtTenKV.Text;
                dataSet1.Tables["khuvuc"].Rows.Add(newRow);
            }
            else
            {
                dataSet1.Tables["khuvuc"].Rows[indexRowKV]["tenkv"] = txtTenKV.Text;
                khuvucBindingSource.EndEdit();
            }
            dongThaoTacKV();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnThemKV.Enabled == false)
            {
                khuvucBindingSource.RemoveAt(dgvKhuVuc.RowCount - 1);
            }
            dongThaoTacKV();
        }





        private void dongThaoTacBan()
        {
            panel2.Visible = false;
            txtTenBan.Text = "";
            btnThemBan.Enabled = true;
            dgvBan.Enabled = true;
        }

        private void moThaoTacBan()
        {
            panel2.Visible = true;
            dgvBan.Enabled = false;
            txtTenBan.Focus();
        }

        int indexRowBan;
        private void dgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBan.Columns[4].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu của dòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    banBindingSource.RemoveCurrent();
                }
            }
            if (e.ColumnIndex == dgvBan.Columns[5].Index && e.RowIndex >= 0)
            {
                moThaoTacBan();
                txtTenBan.Text = dgvBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboKhuVuc.SelectedValue = dgvBan.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTenBan.SelectionStart = txtTenBan.Text.Length;
                indexRowBan = e.RowIndex;
            }
        }

        private void btnRefreshBan_Click(object sender, EventArgs e)
        {
            this.banTableAdapter.Fill(this.dataSet1.ban);
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            banBindingSource.AddNew();
            btnThemBan.Enabled = false;
            moThaoTacBan();
        }

        private void btnLuuBan_Click(object sender, EventArgs e)
        {
            try
            {
                banTableAdapter.Update(dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnOKBan_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text == "")
            {
                MessageBox.Show("Tên bàn không được bỏ trống", "Thông báo");
                return;
            }
            if (btnThemBan.Enabled == false)
            {
                banBindingSource.RemoveAt(dgvBan.RowCount - 1);
                DataRow newRow = dataSet1.Tables["ban"].NewRow();
                newRow["tenban"] = txtTenBan.Text; // Gán giá trị từ TextBox
                newRow["makv"] = cboKhuVuc.SelectedValue.ToString();
                newRow["trangthai"] = "Trống";
                dataSet1.Tables["ban"].Rows.Add(newRow);
            }
            else
            {
                dgvBan.Rows[indexRowBan].Cells[1].Value = txtTenBan.Text;
                dgvBan.Rows[indexRowBan].Cells[2].Value = cboKhuVuc.SelectedValue.ToString();
                dataSet1.Tables["ban"].Rows[indexRowBan]["tenban"] = txtTenBan.Text;
                dataSet1.Tables["ban"].Rows[indexRowBan]["makv"] = cboKhuVuc.SelectedValue.ToString();
                banBindingSource.EndEdit();
            }
            dongThaoTacBan();
        }

        private void btnCancelBan_Click(object sender, EventArgs e)
        {
            if (btnThemBan.Enabled == false)
            {
                banBindingSource.RemoveAt(dgvBan.RowCount - 1);
            }
            dongThaoTacBan();
        }
    }
}
