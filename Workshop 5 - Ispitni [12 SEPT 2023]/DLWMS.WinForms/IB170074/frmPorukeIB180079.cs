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
    public partial class frmPorukeIB180079 : Form
    {
        private Student student; // Jasmin Denis Vedad 
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
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            poruke = db.StudentiPorukeIB180079.Include("Student").Include("Predmet").Where(x => x.StudentId == student.Id &&
            x.Validnost >= DateTime.Now)

                .ToList();

            if (poruke != null)
            {

                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = poruke;
            }

            this.Text = $"Broj poruka {poruke.Count()}";
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var OdabranaPoruka = poruke[e.RowIndex];

            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati ovu poruku ?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.StudentiPorukeIB180079.Remove(OdabranaPoruka);
                    db.SaveChanges();

                }


            }
            UcitajPoruke();
        }
    }
}
