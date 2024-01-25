using FIT.Data;
using FIT.Infrastructure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FIT.WinForms.Helpers
{
    public class Generator
    {
        public static string GetLozinka(int brojZnakova = 15)
        {
            string znakovi = "1234567890'+qwertzuiopšđžasdfghjklčćyxcvbnm,.-QtERTZUIOPŠĐŽASDFGHJKLČĆYXCVBNM;:_!#$%&/()=?*";
            string lozinka = "";//tWK!
            Random rand = new Random();
            for (int i = 0; i < brojZnakova; i++)
                lozinka += znakovi[rand.Next(0, znakovi.Length)];
            return lozinka;
        }
      
        public static string GetEmail(string ime, string prezime)
        {            
            return $"{ime.ToLower()}.{prezime.ToLower()}{Resursi.Get(Kljucevi.EmailDomain)}";
        }
    }
}
