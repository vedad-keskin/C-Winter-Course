
using FIT.Data;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB180079
{
    public partial class frmPretragaIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studenti;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }
        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudentiPredmeti.AutoGenerateColumns = false;
            cbSemestar.DataSource = db.Semestri.ToList();
            UcitajSve();
        }

        private void UcitajSve()
        {
            studenti = db.Studenti.Include("Semestar").ToList();

            if (studenti != null)
            {

                var tblStudenti = new DataTable();

                tblStudenti.Columns.Add("Indeks");
                tblStudenti.Columns.Add("ImePrezime");
                tblStudenti.Columns.Add("Prosjek");
                tblStudenti.Columns.Add("DatumRodjenja");
                tblStudenti.Columns.Add("Aktivan");
                tblStudenti.Columns.Add("Semestar");

                for (int i = 0; i < studenti.Count(); i++)
                {

                    var Red = tblStudenti.NewRow();
                    Red["Indeks"] = studenti[i].Indeks;
                    Red["ImePrezime"] = studenti[i].ToString();
                    Red["Prosjek"] = db.PolozeniPredmeti.Where(x => x.StudentId == studenti[i].Id).Count() == 0 ? Vrijednosti.NotSet : db.PolozeniPredmeti.Where(x => x.StudentId == studenti[i].Id).Average(x => x.Ocjena).ToString();
                    Red["DatumRodjenja"] = studenti[i].DatumRodjenja.ToString();
                    Red["Aktivan"] = studenti[i].Aktivan;
                    Red["Semestar"] = studenti[i].Semestar.ToString();

                    tblStudenti.Rows.Add(Red);

                }










                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = tblStudenti;

            }
        }

        private void UcitajStudenta()
        {
            var filter = string.IsNullOrEmpty(txtImePrezime.Text) ? "" : txtImePrezime.Text.ToLower();

            var DatumOd = dtpOd.Value;
            var DatumDo = dtpDo.Value;

            var Aktivan = cbAktivan.SelectedItem == null ? "Svi" : cbAktivan.SelectedItem.ToString();

            var Semestar = cbSemestar.SelectedItem.ToString();

            studenti = db.Studenti.Include("Semestar")
                .Where(x => (x.DatumRodjenja >= DatumOd && x.DatumRodjenja <= DatumDo) &&
                (x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter) || filter == "") &&
            ((x.Aktivan == true && Aktivan == "Aktivni") || (x.Aktivan == false && Aktivan == "Neaktivni") || Aktivan == "Svi") &&
            (x.Semestar.Oznaka == Semestar)


                )


                .ToList();

            if (studenti != null)
            {
                var tblStudenti = new DataTable();

                tblStudenti.Columns.Add("Indeks");
                tblStudenti.Columns.Add("ImePrezime");
                tblStudenti.Columns.Add("Prosjek");
                tblStudenti.Columns.Add("DatumRodjenja");
                tblStudenti.Columns.Add("Aktivan");
                tblStudenti.Columns.Add("Semestar");

                for (int i = 0; i < studenti.Count(); i++)
                {

                    var Red = tblStudenti.NewRow();
                    Red["Indeks"] = studenti[i].Indeks;
                    Red["ImePrezime"] = studenti[i].ToString();
                    Red["Prosjek"] = db.PolozeniPredmeti.Where(x => x.StudentId == studenti[i].Id).Count() == 0 ? Vrijednosti.NotSet : db.PolozeniPredmeti.Where(x => x.StudentId == studenti[i].Id).Average(x => x.Ocjena).ToString();
                    Red["DatumRodjenja"] = studenti[i].DatumRodjenja.ToString();
                    Red["Aktivan"] = studenti[i].Aktivan;
                    Red["Semestar"] = studenti[i].Semestar.ToString();

                    tblStudenti.Rows.Add(Red);

                }




                dgvStudentiPredmeti.DataSource = false;
                dgvStudentiPredmeti.DataSource = tblStudenti;

            }

            if (studenti.Count() == 0)
            {
                MessageBox.Show($"U datom datumu od: {DatumOd} do: {DatumDo} za semestar {Semestar}, za aktivnost {Aktivan}", "Informejsn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cbSemestar_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudenta();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudenta();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudenta();
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajStudenta();
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudenta();
        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                var odabraniStudent = studenti[e.RowIndex];
            if (e.ColumnIndex == 6)
            {
                
               frmUvjerenja180079cs Uvjerenje = new frmUvjerenja180079cs(odabraniStudent);
                Uvjerenje.ShowDialog();
            }
            else
            {

                frmStudentInfoIB180079 samir = new frmStudentInfoIB180079(odabraniStudent);
                samir.ShowDialog();
            }
        }
    }
}
