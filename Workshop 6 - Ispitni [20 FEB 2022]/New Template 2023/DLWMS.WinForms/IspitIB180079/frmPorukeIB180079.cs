using DLWMS.Data;
using DLWMS.Data.IspitIB180079;
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
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            poruke = db.StudentiPorukeIB180079
                .Include("Predmet").Include("Student")
                .Where(x=> x.StudentId == student.Id)
                .ToList();


            if(poruke != null)
            {

                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = poruke;
            }
        }
    }
}
