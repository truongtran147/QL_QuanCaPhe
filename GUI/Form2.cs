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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string rootPath = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine(rootPath, @"..\..\Report2.rdlc");
            reportViewer1.LocalReport.ReportPath = relativePath;
            DataSet1TableAdapters.topBanRaTableAdapter adapter = new DataSet1TableAdapters.topBanRaTableAdapter();
            DataSet1.topBanRaDataTable dt = new DataSet1.topBanRaDataTable();
            adapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt.Rows));
            this.reportViewer1.RefreshReport();




            relativePath = Path.Combine(rootPath, @"..\..\Report3.rdlc");
            reportViewer2.LocalReport.ReportPath = relativePath;
            DataSet1TableAdapters.doanhthuTableAdapter dtAdapter = new DataSet1TableAdapters.doanhthuTableAdapter();
            DataSet1.doanhthuDataTable dtdt = new DataSet1.doanhthuDataTable();
            dtAdapter.Fill(dtdt);
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtdt.Rows));
            this.reportViewer2.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
