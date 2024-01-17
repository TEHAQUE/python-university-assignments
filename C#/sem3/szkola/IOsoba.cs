using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szkola
{
    public interface IOsoba
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }

        string ZwrocPelnaNazwe();
    }

    public static class ListaOsobW
    {
        public static void WypiszOsoby(this List<IOsoba> listaOsob)
        {
            foreach (var osoba in listaOsob)
            {
                Console.WriteLine($"{osoba.Imie} {osoba.Nazwisko}");
            }
        }
        public static void PosortujOsobyPoNazwisku(this List<IOsoba> listaOsob)
        {
            listaOsob.Sort((osoba1, osoba2) => osoba1.Nazwisko.CompareTo(osoba2.Nazwisko));
            foreach (var osoba in listaOsob)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }
    }
}
