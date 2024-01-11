using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class StudentiPredmetiIB180079
    {
        public int Id { get; set; }
        public int StudentId { get; set; }  // 1 2 3 
        public Student Student { get; set; } // Vedad Keskin IB180079
        public int PredmetId { get; set; }
        public PredmetiIB180079 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }

        public string BrojIndeksa => Student == null ? "" : Student.BrojIndeksa;

    }

}
