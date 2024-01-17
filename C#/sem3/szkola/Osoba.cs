using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szkola
{
    using System;

    public class Osoba : IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        }

        protected string imie;
        protected string nazwisko;
        protected string pesel;

        // Konstruktor
        public Osoba(string im, string naz, string pes)
        {
            imie = im;
            nazwisko = naz;
            pesel = pes;
        }

        // Metody set
        public void SetFirstName(string im)
        {
            imie = im;
        }

        public void SetLastName(string naz)
        {
            nazwisko = naz;
        }

        public void SetPesel(string pes)
        {
            pesel = pes;
        }

        public int GetAge()
        {
            int yearOfBirth = int.Parse(pesel.Substring(0, 2));
            int currentYear = DateTime.Now.Year % 100;

            return (currentYear - yearOfBirth + 100) % 100;
        }

        public string GetGender()
        {
            int position = int.Parse(pesel.Substring(9, 1));
            return (position % 2 == 0) ? "Kobieta" : "Mężczyzna";
        }

        public virtual void GetEducationInfo()
        {
            Console.WriteLine("Brak informacji o edukacji dla osoby.");
        }

        public string GetFullName()
        {
            return imie + " " + nazwisko;
        }

        public virtual bool CanGoAloneToHome()
        {
            return GetAge() >= 12;
        }
    }

}
