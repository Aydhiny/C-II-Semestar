using DLWMS.Data.IspitIB220088;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private StudentiUvjerenjaIB220088 uvjerenje;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }
        public frmIzvjestaji(StudentiUvjerenjaIB220088 uvjerenje)
        {
            this.uvjerenje = uvjerenje;
            InitializeComponent();
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Student", uvjerenje.Student.ToString()));
            rpc.Add(new ReportParameter("BrojIndeksa", uvjerenje.Student.BrojIndeksa));
            rpc.Add(new ReportParameter("Svrha", uvjerenje.Svrha));
            rpc.Add(new ReportParameter("Vrsta", uvjerenje.Vrsta));
            rpc.Add(new ReportParameter("Datum", DateTime.Now.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
