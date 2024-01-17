using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szkola
{
    public interface IStudent : IOsoba
    {
        string Uczelnia { get; set; }
        string Kierunek { get; set; }
        int Rok { get; set; }
        int Semestr { get; set; }
    }

    public class Student : IStudent
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

        public Student(string imie, string nazwisko, string pesel, string uczelnia, string kierunek, int rok, int semestr)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            Uczelnia = uczelnia;
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }
        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }

        public string WypiszPelnaNazweIUczelnie()
        {
            return $"{ZwrocPelnaNazwe()}\n{Rok}{Semestr}{Kierunek} {Rok} {Uczelnia}";
        }
    }

}
