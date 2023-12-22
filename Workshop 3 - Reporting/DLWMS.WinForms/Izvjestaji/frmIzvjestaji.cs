

using DLWMS.Data;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<Student> studenti; // 

        public frmIzvjestaji(List<Student> studenti)
        {
            InitializeComponent();
            this.studenti = studenti;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            var tblStudenti = new dsDLWMS.dsStudentiDataTable();

            for (int i = 0; i < studenti.Count(); i++)
            {
                var Red = tblStudenti.NewdsStudentiRow();
                Red.RB = (i + 1).ToString();
                Red.Indeks = studenti[i].BrojIndeksa;
                Red.Ime = studenti[i].Ime;
                Red.Prezime = studenti[i].Prezime;
                Red.Spol = studenti[i].Spol.Naziv;
                Red.Godina = studenti[i].GodinaStudija.ToString();
                Red.Aktivan = studenti[i].Aktivan == false ? "Ne" : "Da";

                tblStudenti.Rows.Add(Red);


            }


            var rds = new ReportDataSource();
            rds.Name = "dsStudenti";
            rds.Value = tblStudenti;


            reportViewer1.LocalReport.DataSources.Add(rds); 

            reportViewer1.RefreshReport();
        }
    }
}
