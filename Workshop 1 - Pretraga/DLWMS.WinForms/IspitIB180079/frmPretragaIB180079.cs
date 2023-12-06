using DLWMS.Data;
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

namespace DLWMS.WinForms.IspitIB180079
{
    public partial class frmPretragaIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cbSpol.DataSource = db.Spolovi.ToList();
            UcitajSve();
        }

        private void UcitajSve()
        {
            var SviStudenti = db.Studenti.Include("Spol").ToList();


            if (SviStudenti != null)
            {


                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = SviStudenti;
            }


        }
        private void UcitajStudente()
        {
            // 1. textbox
            // 1.1 moze baciti null --> prazan string

            var filter = string.IsNullOrEmpty(txtPretaga.Text) ? "" : txtPretaga.Text.ToLower();
            //                           izraz ? then : else;


            // 2. combobox
            // 2.1 kada rucno upisujemo vrijednosti moze baciti null
            // 2.2 kada iz baze upisujemo vrijednost ne moze biti null --> po defaultu je vazda prvi item

            var spol = cbSpol.SelectedItem.ToString();  // ***** muski zenski

            // 3. checkbox
            // 3.1 ne moze baciti null --> false 

            var aktivan = chbAktivan.Checked; // true ili false


            // 4. datetimepicker
            // 4.1 ne moze baciti null --> danasnji datum i vrijeme

            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;


            var studenti = db.Studenti.Include("Spol").Where(x => (x.Spol.Naziv == spol) &&
            (x.Aktivan == aktivan) &&
            (x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter) || filter == "")
            && (x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo))
                .ToList();


            if (studenti != null)
            {


                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;
            }


        }

        private void txtPretaga_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }


        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
