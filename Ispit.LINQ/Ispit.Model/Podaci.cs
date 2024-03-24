using Ispit.Model.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Podaci
    {
        public List<Banka> ListaBanki { get; set; }
        public List<Klijent> ListaKlijenata { get; set; }

        public Podaci()
        {
            ListaBanki = new List<Banka>()
                {
                new Banka() { Simbol = "ZABA", Naziv = "Zagrebacka banka" },
                new Banka() { Simbol = "PBZ", Naziv = "Privredna banka Zagreb" },
                new Banka() { Simbol = "HPB", Naziv = "Hrvatska postanska banka" }
                };

            ListaKlijenata = new List<Klijent>()
                {
                new Klijent() { ImePrezime = "Nikola Tesla", Stanje = 100000, Banka = "ZABA" },
                new Klijent() { ImePrezime = "Mirko Filipovic", Stanje = 1000000, Banka = "PBZ" },
                new Klijent() { ImePrezime = "Jon Jones", Stanje = 1940, Banka = "HPB" },
                new Klijent() { ImePrezime = "Clark Kent", Stanje = 20, Banka = "HPB" },
                new Klijent() { ImePrezime = "Fjodor Emelianenko", Stanje = 199000, Banka = "ZABA" },
                new Klijent() { ImePrezime = "Wnderlei Silva", Stanje = 99999, Banka = "PBZ" },
                new Klijent() { ImePrezime = "Zeljko Mavrovic", Stanje = 1000, Banka = "PBZ" },
                new Klijent() { ImePrezime = "Mike Tyson", Stanje = 1000000, Banka = "ZABA" },
                new Klijent() { ImePrezime = "Matt Rife", Stanje = 600000, Banka = "PBZ" },
                new Klijent() { ImePrezime = "Cody Detwiler", Stanje = 1000000, Banka = "HPB" }
                };
        }
    }
}
