using DLWMS.Data;
using DLWMS.Data.IB170074;
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

namespace DLWMS.WinForms.IB170074
{
    public partial class frmPretragaIB170074 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPredmetiIB170074> studentiPredmeti;
        public frmPretragaIB170074()
        {
            InitializeComponent();
        }

        private void frmPretragaIB170074_Load(object sender, EventArgs e)
        {
            dgvStudentiPredmeti.AutoGenerateColumns = false;
            UcitajSve();
        }

        private void UcitajSve()
        {
            studentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").ToList();


            if (studentiPredmeti != null)
            {


                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = studentiPredmeti;
            }

        }
        private void UcitajStudente()
        {
            // combox box koji rucno kucamo moze baciti null

            var ocjenaOd = cbOcjenaOd.SelectedItem == null ? 6 : int.Parse(cbOcjenaOd.SelectedItem.ToString()); // 6 7 8 9 10
            var ocjenaDo = cbOcjenaDo.SelectedItem == null ? 10 : int.Parse(cbOcjenaDo.SelectedItem.ToString()); // 10 9 8 7 6 


            // dtp ne moze baciti null jer je dft vrijednost danasnji datum

            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;


            // chb ne moze baciti null jer je dft vrijednost false

            var aktivan = chbAktivan.Checked;  // false true 


            studentiPredmeti = db.StudentiPredmeti.Include("Predmet").Include("Student").Where(x =>
            (x.Ocjena >= ocjenaOd && x.Ocjena <= ocjenaDo) &&
            (x.Datum >= datumOd && x.Datum <= datumDo) &&
            (x.Student.Aktivan == aktivan))
                .ToList();

            if (studentiPredmeti != null)
            {
                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = studentiPredmeti;
            }

            if (studentiPredmeti.Count() == 0)
            {

                if (aktivan == true)
                {
                    MessageBox.Show($"U periodu od {datumOd} do {datumDo} nema ocjene u opsegu od {ocjenaOd} do {ocjenaDo} za bilo kojeg aktivnog studenta", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"U periodu od {datumOd} do {datumDo} nema ocjene u opsegu od {ocjenaOd} do {ocjenaDo} za bilo kojeg (ne)aktivnog studenta", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }


        }

        private void cbOcjenaOd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cbOcjenaDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }





        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var OdabraniStudentPredmet = studentiPredmeti[e.RowIndex];

            if (e.ColumnIndex == 6)
            {
               
                frmPorukeIB180079 frmPoruke = new frmPorukeIB180079(OdabraniStudentPredmet.Student); // forma je napravljena
                frmPoruke.ShowDialog();


            }



        }
    }
}
