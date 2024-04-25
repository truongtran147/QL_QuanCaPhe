using Microsoft.Reporting.WinForms;
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

namespace GUI
{
    public partial class frmXuatHoaDon : Form
    {
        public frmXuatHoaDon()
        {
            InitializeComponent();
        }
        private int mahd;

        public int Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }


        private void frmXuatHoaDon_Load(object sender, EventArgs e)
        {
            string rootPath = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(rootPath, @"..\..\Report1.rdlc");
            reportViewer1.LocalReport.ReportPath = relativePath;
            DataSet1TableAdapters.HoaDonTableTableAdapter adapter = new DataSet1TableAdapters.HoaDonTableTableAdapter();
            DataSet1.HoaDonTableDataTable dt = new DataSet1.HoaDonTableDataTable();
            adapter.Fill(dt);
            string sqlFilter = $"mahd = {mahd}";
            DataRow[] filteredRows = dt.Select(sqlFilter);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", filteredRows));
            this.reportViewer1.RefreshReport();
            if (filteredRows.Length > 1 )
            {
                this.Height += 24 * (filteredRows.Length -1);
            }
        }
    }
}
