using DLWMS.Data;
using DLWMS.Data.IspitIB180079;
using DLWMS.WinForms.Helpers;
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
        List<StudentiPredmetiIB180079> studentiPredmeti;



        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
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
            this.Text = $"Ukupno zapisa {studentiPredmeti.Count()}";
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
            // txt moze baciti null 

        }

        private void UcitajStudente()
        {
            var filter = string.IsNullOrEmpty(txtPretraga.Text) ? "" : txtPretraga.Text.ToLower();
            //                     uslov ? true : false ;


            studentiPredmeti = db.StudentiPredmeti.Include("Student").Include("Predmet").Where(x => x.Predmet.Naziv.ToLower().Contains(filter) || filter == "")


                .ToList();

            if (studentiPredmeti != null)
            {


                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = studentiPredmeti;
            }


            this.Text = $"Ukupno zapisa {studentiPredmeti.Count()}";
        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var StudentPredmet = studentiPredmeti[e.RowIndex];

            if (e.ColumnIndex == 4)
            {
                //   glavni tekst , Zaglavlje , buttoni  , icone
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati ovaj predmet", "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    db.StudentiPredmeti.Remove(StudentPredmet);
                    db.SaveChanges();
                }




            }

            UcitajStudente();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                // sve sto je vezano za combobox

                Thread thread = new Thread(() => SumirajBrojeve());
                thread.Start();

            }

        }

        private void SumirajBrojeve()
        {
            // sve kalkulacije, racunanje, pohranjivate

            var brojOd = int.Parse(txtBrojOd.Text);
            var brojDo = int.Parse(txtBrojDo.Text);
            double suma = 0;

            for (int i = brojOd; i < brojDo; i++)
            {
                suma += i;
            }



            Action action = () =>
            {
                // ispisi, mbox, ucitavanja

                txtSuma.Text = suma.ToString();
            };
            BeginInvoke(action);



        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBrojOd, err, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtBrojDo, err, Kljucevi.ObaveznaVrijednost);
        }
    }
}
