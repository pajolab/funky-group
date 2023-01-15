using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyBus
{
    public class Karta
    {
        public string mjestoPolaska;
        public string mjestoDolaska;
        public string datumOdlaska;
        public string Termin;
        public string Destinacija;

        public static bool Registracija(string username, string password)
        {
            return username.Length > 0 && password.Length > 0;
        }
    }
}
