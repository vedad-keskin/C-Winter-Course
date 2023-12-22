using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB170074
{
    public class StudentiPredmetiIB170074
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public string StudentPodaci => $"{Student} ({DateTime.Now.Year - Student.DatumRodjenja.Year})";
        public int PredmetId { get; set; }
        public PredmetiIB170074 Predmet { get; set; }

        public string PredmetPodaci => db.StudentiPredmeti.Where(x => x.StudentId == StudentId).ToList() == null ? "0" : $"{Predmet}  ({db.StudentiPredmeti.Where(x=> x.StudentId == StudentId).Average(x=> x.Ocjena)})";

        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }

        public bool Aktivan => Student.Aktivan;
        public string BrojIndeksa => Student.BrojIndeksa;
    }
}
