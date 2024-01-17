using System;
using szkola;

class Program
{
    static void Main()
    {
        Uczen uczen = new Uczen("Jan", "Kowalski", "15042181976", "Szkoła Podstawowa");

        Console.WriteLine("Informacje o uczniu:");
        Console.WriteLine($"Imię i nazwisko: {uczen.GetFullName()}");
        Console.WriteLine($"Wiek: {uczen.GetAge()} lat");
        uczen.SetCanGoHomeAlone();

        Console.WriteLine($"Uczeń {uczen.GetFullName()} {(uczen.CanGoAloneToHome() ? "może" : "nie może")} sam wracać do domu.");
        
                uczen.GetEducationInfo();

        Uczen uczen2 = new Uczen("Anna","Mucha", "66122286492", "Szkoła Podstawowa nr 2");


        Nauczyciel nauczyciel = new Nauczyciel("Jan","Muran", "61082997479", "Szkola Podstawowa", "Nauczyciel");


        nauczyciel.AddStudent(uczen);
        nauczyciel.AddStudent(uczen2);
        nauczyciel.WhichStudentCanGoHomeAlone();

        //zadanie 3a
        Console.WriteLine("=====_zadanie 3a_======");

        List<IOsoba> listaOsob = new List<IOsoba>
        {
            new Osoba("Paweł", "Drążek"),
            new Osoba("Marcin", "West"),
            new Osoba("Ambroży", "Wałęsa")
        };

        foreach (var osoba in listaOsob)
        {
            Console.WriteLine(osoba.ZwrocPelnaNazwe());
        }
        //zadanie3b
        Console.WriteLine("=====_zadanie 3b_======");
        List<IOsoba> listaOsob2 = new List<IOsoba>
        {
            new Osoba("Artur", "Kopiec"),
            new Osoba("Marian", "Pietrucha"),
            new Osoba("Grzegorz", "Kuś")
        };

 
        listaOsob2.WypiszOsoby();
        //zadanie3c
        Console.WriteLine("=====_zadanie 3c_======");
        listaOsob2.PosortujOsobyPoNazwisku();


        //zadanie3d
        Console.WriteLine("=====_zadanie 3d_======");
        IStudent student1 = new Student("Jan", "Kowalski", "12345678901", "WSIiZ", "Informatyka", 4, 2);

        Console.WriteLine(student1.WypiszPelnaNazweIUczelnie());
    }

}