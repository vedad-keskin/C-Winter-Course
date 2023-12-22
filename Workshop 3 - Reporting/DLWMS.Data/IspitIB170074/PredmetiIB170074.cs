using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB170074
{
    public class PredmetiIB170074
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
