using FIT.Data;
using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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

    public partial class frmNovoUvjerenje180079 : Form
    {
        private Student odabraniStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovoUvjerenje180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void pbUplatnica_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var vrsta = cbVrsta.SelectedItem.ToString();
                var svrha = txtSvrha.Text;
                var uplatnica = Ekstenzije.ToByteArray(pbUplatnica.Image);
                var novoUvjerenje = new StudentiUvjerenjaIB180079() {
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Uplatnica = uplatnica,
                    Print = false,
                    StudentId = odabraniStudent.Id,
                    Vrijeme = DateTime.Now
                };
                db.StudentiUvjerenjaIB180079.Add(novoUvjerenje);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(cbVrsta, err, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.ReqiredValue)
            && Validator.ProvjeriUnos(pbUplatnica, err, Kljucevi.ReqiredValue);
        }
    }
}
