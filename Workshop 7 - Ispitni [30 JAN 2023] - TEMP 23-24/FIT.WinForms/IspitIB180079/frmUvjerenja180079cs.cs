using FIT.Data;
using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
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
    public partial class frmUvjerenja180079cs : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student odabraniStudent;
        List<StudentiUvjerenjaIB180079> Uvjerenja;

        public frmUvjerenja180079cs(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranoUvjerenje = Uvjerenja[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Jeste li sigurni da zelite izbrisati uvjerenje","Pitanje",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {

                    db.StudentiUvjerenjaIB180079.Remove(odabranoUvjerenje);
                    db.SaveChanges();
                }

            }
            UcitajUvjerenja();
        }

        private void frmUvjerenja180079cs_Load(object sender, EventArgs e)
        {
            dgvUvjerenja.AutoGenerateColumns = false;
            UcitajUvjerenja();
        }

        private void UcitajUvjerenja()
        {
            Uvjerenja = db.StudentiUvjerenjaIB180079.Where(x => x.StudentId == odabraniStudent.Id).ToList();
            if (Uvjerenja != null)
            {
                dgvUvjerenja.DataSource = null;
                dgvUvjerenja.DataSource = Uvjerenja;
            }
        }

        private void btnZahtjev_Click(object sender, EventArgs e)
        {
            frmNovoUvjerenje180079 NovoUvjerenje = new frmNovoUvjerenje180079(odabraniStudent);
            if (NovoUvjerenje.ShowDialog() == DialogResult.OK)
            {
                UcitajUvjerenja();
            } 
        }
    }
}
