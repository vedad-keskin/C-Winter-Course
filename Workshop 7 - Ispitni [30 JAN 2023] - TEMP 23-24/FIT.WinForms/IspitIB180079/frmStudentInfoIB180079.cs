using FIT.Data;
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
using static System.Net.Mime.MediaTypeNames;

namespace FIT.WinForms.IspitIB180079
{

    public partial class frmStudentInfoIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student odabraniStudent;

        public frmStudentInfoIB180079()
        {
            InitializeComponent();
        }

        public frmStudentInfoIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void frmStudentInfoIB180079_Load(object sender, EventArgs e)
        {
            pbProfilePhoto.Image = Ekstenzije.ToImage(odabraniStudent.Slika);
            lbImePrezime.Text = odabraniStudent.ImePrezime;
            lbProsjek.Text = db.PolozeniPredmeti.Where(x => x.StudentId == odabraniStudent.Id).Count() == 0 ? "0" : db.PolozeniPredmeti.Where(x => x.StudentId == odabraniStudent.Id).Average(x => x.Ocjena).ToString();
            label3.Text = $"frmStudentInfo {odabraniStudent.Indeks}";
            this.Text = odabraniStudent.Indeks;
        }
    }
}
