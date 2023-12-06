using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB180079
{
    public class PredmetiIB180079
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        override public string ToString()
        {
            return Naziv;
        }


    }
}
