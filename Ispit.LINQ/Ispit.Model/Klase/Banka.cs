using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model.Klase
{
    public class Banka
    {
        public string Simbol {  get; set; }
        public string Naziv {  get; set; }
    }

    public class Klijent
    {
        public string ImePrezime { get; set; }
        public double Stanje { get; set; }
        public string Banka { get; set; }
    }

    public class GrupiraniMilijunasi
    {
        public string Banka { get; set; }
        public IEnumerable<string> Milijunasi { get; set; }
    }
}
