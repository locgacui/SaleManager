using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class FormReport : DevExpress.XtraEditors.XtraForm
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private XtraReport report;

        public XtraReport Report
        {
            get
            {
                return report;
            }

            set
            {
                report = value;
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            dViewer.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }

        private void FormReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }
    }
}