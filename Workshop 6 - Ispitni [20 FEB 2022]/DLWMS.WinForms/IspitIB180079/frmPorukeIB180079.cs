using DLWMS.Data;
using DLWMS.Data.IspitIB180079;
using DLWMS.WinForms.Helpers;
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

namespace DLWMS.WinForms.IspitIB180079
{
    public partial class frmPorukeIB180079 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPorukeIB180079> poruke;

        public frmPorukeIB180079(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmPorukeIB180079_Load(object sender, EventArgs e)
        {
            dgvPoruke.AutoGenerateColumns = false;
            lblStudent.Text = student.ToString();
            cbPredmet.DataSource = db.Predmeti.ToList();
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            poruke = db.StudentiPorukeIB180079.Include("Predmet").Include("Student")
                .Where(x => x.StudentId == student.Id && x.Validnost >= DateTime.Now)
                .ToList();

            if (poruke != null)
            {

                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = poruke;
            }
            this.Text = $"Broj poruka: {poruke.Count()}";

            if (poruke.Count() == 0)
            {
                btnDodaj.Enabled = false;
            }
            else
            {
                btnDodaj.Enabled = true;
            }
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabranaPoruka = poruke[e.RowIndex];

            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati ovu poruku ?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.StudentiPorukeIB180079.Remove(odabranaPoruka);
                    db.SaveChanges();

                }

            }

            UcitajPoruke();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIB180079 frmNova = new frmNovaPorukaIB180079(student);
            if (frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajPoruke();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            // 1. dio 
            // sve sto je vezano za combobox, postavljanje threada
            if (Validiraj())
            {

                var predmet = cbPredmet.SelectedItem as PredmetiIB180079;

                Thread t1 = new Thread(() => GenerisiPoruke(predmet));
                t1.Start();
            }
        }

        private void GenerisiPoruke(PredmetiIB180079 predmet)
        {
            // 2. dio 
            // sve kalkulacije, pohranjivanja 

            var brojPoruka = int.Parse(txtBroj.Text);
            var validnost = dtpValidnost.Value;
            var slika = poruke[0].Slika;
            var info = "";


            for (int i = 0; i < brojPoruka; i++)
            {

                var NovaPoruka = new StudentiPorukeIB180079()
                {
                    PredmetId = predmet.Id,
                    StudentId = student.Id,
                    Validnost = validnost,
                    Sadrzaj = $"{i + 1}. GENERISANA PORUKA",
                    Slika = slika
                };

                // \r\n za novi red ili {Environment.NewLine}

                info += $"{validnost} -> generisana poruka za {student} na predmetu {predmet} \r\n";

                db.StudentiPorukeIB180079.Add(NovaPoruka);
                db.SaveChanges();
            }


            // 3.dio 
            // ispisi, mbox, ucitavanja
            Action action = () =>
            {
                UcitajPoruke();
                MessageBox.Show($"Uspješno generisano {brojPoruka} poruka", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInfo.Text = info;
            };
            BeginInvoke(action);

        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBroj, err, Kljucevi.ObaveznaVrijednost);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(poruke.Count() != 0)
            {
                frmIzvjestaji frmIzvjestaj = new frmIzvjestaji(poruke);
                frmIzvjestaj.ShowDialog();
            }
        }
    }
}
