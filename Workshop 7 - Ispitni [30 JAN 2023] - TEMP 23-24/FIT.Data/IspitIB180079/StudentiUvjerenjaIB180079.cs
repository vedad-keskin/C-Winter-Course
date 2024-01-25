using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB180079
{
    public class StudentiUvjerenjaIB180079
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Vrijeme { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }
        
        public byte[] Uplatnica { get; set; }
        public bool Print { get; set; }

    }
}
