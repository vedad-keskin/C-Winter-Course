using DLWMS.Data;
using DLWMS.WinForms.Izvjestaji;
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

namespace DLWMS.WinForms.IspitIB170074
{

    public partial class frmPretragaIB170074 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> Studenti;
        public frmPretragaIB170074()
        {
            InitializeComponent();
        }

        private void frmPretragaIB170074_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            UcitajSve();
        }

        private void UcitajSve()
        {
            Studenti = db.Studenti.Include("Spol").ToList();
            if (Studenti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = Studenti;
            }
            lblBrojStudenata.Text = Studenti.Count().ToString();
            lblProsjek.Text = db.StudentiPredmeti.Average(x => x.Ocjena).ToString();
        }





        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cbAktivnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            var GodinaStudija = cbGodina.SelectedItem == null ? "Sve" : cbGodina.SelectedItem.ToString();
            var Filter = string.IsNullOrEmpty(txtImePrezime.Text) ? "" : txtImePrezime.Text.ToLower();


            // null 
            // Sve
            // Aktivni
            // Neaktivni

            var Aktivnost = cbAktivnost.SelectedItem == null ? "Svi" : cbAktivnost.SelectedItem.ToString();





            Studenti = db.Studenti.Include("Spol").Where(x => (x.Ime.ToLower().Contains(Filter) || x.Prezime.ToLower().Contains(Filter) || Filter == "")
            && (x.GodinaStudija.ToString() == GodinaStudija || GodinaStudija == "Sve") &&
  (Aktivnost == "Svi" || (x.Aktivan == false && Aktivnost == "Neaktivni") || (x.Aktivan == true && Aktivnost == "Aktivni"))
            ).ToList();

            if (Studenti != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = Studenti;
            }
            lblBrojStudenata.Text = Studenti.Count().ToString();


            int suma = 0;
            float brojac = 0;

            var SveOcjene = db.StudentiPredmeti.ToList(); // sve ocjene


            for (int i = 0; i < SveOcjene.Count(); i++)     // sve ocjene
            {
                for (int j = 0; j < Studenti.Count(); j++)   // kroz pretrazene studente
                {
                    if (SveOcjene[i].StudentId == Studenti[j].Id)    // ako studentu odgovara ocjena
                    {
                        suma += SveOcjene[i].Ocjena;
                        brojac++;
                    }
                }
            }

            lblProsjek.Text = (suma / brojac).ToString();


        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            if(Studenti.Count() != 0)
            {

                frmIzvjestaji frmIzvjestaj = new frmIzvjestaji(Studenti); // narpavili formu izvjestaj
                frmIzvjestaj.ShowDialog();
            }
        }
    }
}
