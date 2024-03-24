using Ispit.Model;
using Ispit.Model.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    public class Program
    {
        static void Main(string[] args)
        {
            var podaci = new Podaci();
            var GrupirajPremaBanci = podaci.ListaKlijenata
                .Where(k => k.Stanje >= 1000000)
                .GroupBy(k => k.Banka)
                .Select(grupa => new GrupiraniMilijunasi
                {
                    Banka = grupa.Key,
                    Milijunasi = grupa.Select(k => k.ImePrezime)
                });
            foreach (var m in GrupirajPremaBanci)
            {
                Console.Write(m.Banka + ": ");
                foreach (var milijunas in m.Milijunasi)
                {
                    Console.Write(milijunas + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            var IzvjestajMilijunasa = podaci.ListaKlijenata
                .Where(k => k.Stanje >= 1000000)
                .Select(k => new
                {
                    ImeIPrezime = k.ImePrezime,
                    BankaNaziv = podaci.ListaBanki.First(b => b.Simbol == k.Banka).Naziv
                });
                

            foreach (var m in IzvjestajMilijunasa)
            {
                Console.WriteLine($"{m.ImeIPrezime} je u {m.BankaNaziv}");
            }
        }
    }
}
