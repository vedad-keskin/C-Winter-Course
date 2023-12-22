using DLWMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
            UcitajSve();
        }

        private void UcitajSve()
        {
            var studenti = db.Studenti.Include("Spol").ToList();


            if (studenti != null)
            {


                var tblStudenti = new DataTable();
                tblStudenti.Columns.Add("Student");
                tblStudenti.Columns.Add("Godina");
                tblStudenti.Columns.Add("Prosjek");

                for (int i = 0; i < studenti.Count(); i++)
                {
                    var student = studenti[i];  // vedad denis 



                    var Red = tblStudenti.NewRow();
                    Red["Student"] = student.ToString();
                    Red["Godina"] = student.GodinaStudija.ToString();
                    Red["Prosjek"] = db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString();

                    tblStudenti.Rows.Add(Red);


                }







                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblStudenti;
            }

        }
        private void UcitajStudente()
        {
           // txtbox moze baciti null zato imamo uslov 
            var filter = string.IsNullOrEmpty(txtPretraga.Text) ? "" : txtPretraga.Text.ToLower();

            // rucno unesen combobox moze baciti null
            var godina = cbGodina.SelectedItem == null ? 0 : int.Parse(cbGodina.SelectedItem.ToString());


            var studenti = db.Studenti.Include("Spol").Where(x=> 
            (x.GodinaStudija == godina || godina == 0) && 
            (x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter) || filter == "" ))
                .ToList();



            if(studenti != null)
            {

                var tblStudenti = new DataTable();
                tblStudenti.Columns.Add("Student");
                tblStudenti.Columns.Add("Godina");
                tblStudenti.Columns.Add("Prosjek");


                for(int i = 0;i< studenti.Count(); i++)
                {
                    var student = studenti[i];

                    var Red = tblStudenti.NewRow();
                    Red["Student"] = student.ToString();
                    Red["Godina"] = student.GodinaStudija.ToString();
                    Red["Prosjek"] = db.StudentiPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString();
                    tblStudenti.Rows.Add(Red);

                }


                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblStudenti;
            }



        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }


        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }
    }
}
