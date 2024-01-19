using DLWMS.Data.IspitIB180079;
using DLWMS.WinForms.IspitIB180079;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiPorukeIB180079> poruke;


        public frmIzvjestaji(List<StudentiPorukeIB180079> poruke)
        {
            InitializeComponent();
            this.poruke = poruke;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var tblPoruke = new dsDLWMS.dsPorukeDataTable();
            for (int i = 0; i < poruke.Count(); i++)
            {
                var Red = tblPoruke.NewdsPorukeRow();
                Red.RB = (i + 1).ToString();
                Red.Predmet = poruke[i].Predmet.ToString();
                Red.Sadrzaj = poruke[i].Sadrzaj;
                Red.BrojZnakova = poruke[i].Sadrzaj.Count().ToString();
                Red.Validnost = poruke[i].Validnost.ToString();
                tblPoruke.Rows.Add(Red);
            }

            var rds = new ReportDataSource();
            rds.Value = tblPoruke;
            rds.Name = "dsPoruke";
            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("student", poruke[0].Student.ToString()));
            rpc.Add(new ReportParameter("broj", poruke.Count().ToString()));
            rpc.Add(new ReportParameter("prosjek", poruke.Average(x => x.Sadrzaj.Count()).ToString()));
            reportViewer1.LocalReport.SetParameters(rpc);


            reportViewer1.RefreshReport();
        }
    }
}
