using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Wybierz program:");
            Console.WriteLine("1. Obliczanie delt i pierwiastków trójmianu kwadratowego");
            Console.WriteLine("2. Kalulator");
            Console.WriteLine("3. Wyświetlanie 10 elementowej tablicy");
            Console.WriteLine("4. Operacje na 10 elementowej tablicy");
            Console.WriteLine("5. Wyświetlenie 20 liczb bez 2, 6, 9, 15, 19");
            Console.WriteLine("6. Program pytający w nieskończoność");

            Console.Write("Twój wybór (wpisz numer programu lub 'q' aby wyjść): ");
            string job = Console.ReadLine();

            if (job == "q")
            {
                break;
            }

            switch (job)
            {
                case "1":
                    Zad1();
                    break;
                case "2":
                    Zad2();
                    break;
                case "3":
                    Zad3();
                    break;
                case "4":
                    Zad4();
                    break;
                case "5":
                    Zad5();
                    break;
                case "6":
                    Zad6();
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                    break;
            }

            Console.WriteLine("\nNaciśnij Enter, aby kontynuować...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    static void Zad1()
    {
        Console.WriteLine("Program do obliczania delty i pierwiastków trójmianu kwadratowego.");

        Console.Write("Podaj współczynniki trójmianu kwadratowego ax^2 + bx + c:\n");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = Delta(a, b, c);

        Console.WriteLine($"Delta: {delta}");

        if (delta >= 0)
        {
            double[] pierwiastki = Pierwiastki(a, b, delta);

            if (pierwiastki.Length == 1)
            {
                Console.WriteLine($"Jeden pierwiastek: {pierwiastki[0]}");
            }
            else
            {
                Console.WriteLine($"Pierwiastki: {pierwiastki[0]} i {pierwiastki[1]}");
            }
        }
        else
        {
            Console.WriteLine("Brak pierwiastków rzeczywistych dla delty ujemnej.");
        }
        static double Delta(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        static double[] Pierwiastki(double a, double b, double delta)
        {
            double pierwiastekDelta = Math.Sqrt(delta);

            double x1 = (-b + pierwiastekDelta) / (2 * a);
            double x2 = (-b - pierwiastekDelta) / (2 * a);

            return new double[] { x1, x2 };
        }
    }
    static void Zad2()
    {
        while (true)
        {
            Console.WriteLine("Wybierz operację:");
            Console.WriteLine("-1. Suma");
            Console.WriteLine("-2. Różnica");
            Console.WriteLine("-3. Iloczyn");
            Console.WriteLine("-4. Iloraz");
            Console.WriteLine("-5. Potęga");
            Console.WriteLine("-6. Pierwiastek");
            Console.WriteLine("-7. Sinus");
            Console.WriteLine("-8. Cosinus");
            Console.WriteLine("-9. Tangens");
            Console.WriteLine("-10. Cotangens");
            Console.WriteLine("-b Wróć");

            Console.Write("Twój wybór: ");
            string job = Console.ReadLine();

            if (job == "b")
            {
                break;
            }
            switch (job)
            {
                case "1":
                    Suma();
                    break;
                case "2":
                    Roznica();
                    break;
                case "3":
                    Mnozenie();
                    break;
                case "4":
                    Dzielenie();
                    break;
                case "5":
                    Potegowanie();
                    break;
                case "6":
                    Pierwiastkowanie();
                    break;
                case "7":
                    Sinus();
                    break;
                case "8":
                    Cosinus();
                    break;
                case "9":
                    Tangens();
                    break;
                case "10":
                    Cotangens();
                    break;
            }
            static void Suma()
            {
                Console.WriteLine("Wprowadź pierwszą liczbe");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wprowadź drugą liczbe");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Wynik sumy: {a + b}");
            }
            static void Roznica()
            {
                Console.WriteLine("Wprowadź pierwszą liczbe");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wprowadź drugą liczbe");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Wynik odejmowania: {a - b}");
            }
            static void Mnozenie()
            {
                Console.WriteLine("Wprowadź pierwszą liczbe");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wprowadź drugą liczbe");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Wynik mnożenia: {a * b}");
            }
            static void Dzielenie()
            {
                Console.WriteLine("Wprowadź liczbe do dzielenia");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wprowadź dzielnik");
                double b = Convert.ToDouble(Console.ReadLine());
                if(b != 0)
                {
                    Console.WriteLine($"Wynik dzielenia: {a / b}");
                }
                else
                {
                    Console.WriteLine("Pamiętaj cholero nie dziel przez zero.");
                }
            }
            static void Potegowanie()
            {
                Console.WriteLine("Wprowadź podstawę");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wprowadź wykładnik");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Wynik potęgowania: {Math.Pow(a, b)}");
            }
            static void Pierwiastkowanie()
            {
                Console.WriteLine("Wprowadź liczbe");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Wynik pierwiastkowania: {Math.Sqrt(a)}");
            }
            static void Sinus()
            {   
                Console.WriteLine("===== Wybrano sinus =====");
                Console.WriteLine("Podaj kąt");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Sinus({a}): {Math.Sin(a)} rad");
            }
            static void Cosinus()
            {
                Console.WriteLine("===== Wybrano cosinus =====");
                Console.WriteLine("Podaj kąt");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Cosinus({a}): {Math.Cos(a)} rad");
            }
            static void Tangens()
            {
                Console.WriteLine("===== Wybrano tangens =====");
                Console.WriteLine("Podaj kąt");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Tangens({a}): {Math.Tan(a)} rad");
            }
            static void Cotangens()
            {
                Console.WriteLine("===== Wybrano cotangens =====");
                Console.WriteLine("Podaj kąt");
                double a = Convert.ToDouble(Console.ReadLine());
                if(Math.Tan(a) != 0)
                {
                    Console.WriteLine($"Cotangens({a}): {1/a} rad");
                }
                else
                {
                    Console.WriteLine("Nie można obliczyć cotangensa dla kąta, dla którego tangens wynosi 0.");
                }
            }
        }
    }
    static void Zad3()
    {
        while (true)
        {
            double[] liczby = new double[10];
            Console.WriteLine("Wprowadź 10 liczb, aby kontynuwoać:");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                liczby[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\n***** Dostępne opcje:");
            Console.WriteLine("-1. Wyświetl tablicę od pierwszego do ostatniego indeksu.");
            Console.WriteLine("-2. Wyświetl tablicę od ostatniego do pierwszego indeksu.");
            Console.WriteLine("-3. Wyświetl elementy o nieparzystych indeksach.");
            Console.WriteLine("-4. Wyświetl elementy o parzystych indeksach.");
            Console.WriteLine("-b Wróć");

            string job = Console.ReadLine();
            if (job == "b")
            {
                break;
            }
            switch (job)
            {
                case "1":
                    Normalne(liczby);
                    break;
                case "2":
                    OdOstatniego(liczby);
                    break;
                case "3":
                    Nieparzyste(liczby);
                    break;
                case "4":
                    Parzyste(liczby);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
            static void Normalne(double[] tablica)
            {
                Console.WriteLine("Tablica od pierwszego do ostatniego indeksu:");
                for (int i = 0; i < tablica.Length; i++)
                {
                    Console.WriteLine($"Element {i}: {tablica[i]}");
                }
            }
            static void OdOstatniego(double[] tablica)
            {
                Console.WriteLine("Tablica od ostatniego do pierwszego indeksu:");
                for (int i = tablica.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"Element {i}: {tablica[i]}");
                }
            }
            static void Nieparzyste(double[] tablica)
            {
                Console.WriteLine("Elementy nieparzyste:");
                for (int i = 1; i < tablica.Length; i += 2)
                {
                    Console.WriteLine($"Element {i}: {tablica[i]}");
                }
            }

            static void Parzyste(double[] tablica)
            {
                Console.WriteLine("Elementy parzyste:");
                for (int i = 0; i < tablica.Length; i += 2)
                {
                    Console.WriteLine($"Element {i}: {tablica[i]}");
                }
            }
        }
    }
    static void Zad4()
    {
        while (true)
        {
            double[] liczby = new double[10];
            Console.WriteLine("Wprowadź 10 liczb, aby kontynuwoać:");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                liczby[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Operacje na tablicy:");
            double suma = Suma(liczby);
            double iloczyn = Iloczyn(liczby);
            double srednia = Srednia(liczby);
            double minimalna = Minimum(liczby);
            double maksymalna = Maksimum(liczby);

            Console.WriteLine($"\nSuma: {suma}");
            Console.WriteLine($"Iloczyn: {iloczyn}");
            Console.WriteLine($"Średnia: {srednia}");
            Console.WriteLine($"Minimalna wartość: {minimalna}");
            Console.WriteLine($"Maksymalna wartość: {maksymalna}");
            Console.WriteLine("--Wybierz b aby wrócić do menu");
            string job = Console.ReadLine();
            if (job == "b")
            {
                break;
            }
        }
        static double Suma(double[] tablica)
        {
            double suma = 0;
            foreach (double liczba in tablica)
            {
                suma += liczba;
            }
            return suma;
        }
        static double Iloczyn(double[] tablica)
        {
            double iloczyn = 1;
            foreach (double liczba in tablica)
            {
                iloczyn *= liczba;
            }
            return iloczyn;
        }
        static double Srednia(double[] tablica)
        {
            double suma = Suma(tablica);
            return suma / tablica.Length;
        }

        static double Minimum(double[] tablica)
        {
            double min = tablica[0];
            foreach (double liczba in tablica)
            {
                if (liczba < min)
                {
                    min = liczba;
                }
            }
            return min;
        }

        static double Maksimum(double[] tablica)
        {
            double max = tablica[0];
            foreach (double liczba in tablica)
            {
                if (liczba > max)
                {
                    max = liczba;
                }
            }
            return max;
        } 
    }
    static void Zad5()
    {
        Console.WriteLine("Liczby od 20 do 0 (z wyłączeniem {2, 6, 9, 15, 19}):");

        for (int i = 20; i >= 0; i--)
        {
            if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
    static void Zad6()
    {
        Console.WriteLine("****** Aby zakończyć podaj liczbę mniejszą niż 0.");
        while (true)
        {
            Console.Write("Podaj liczbę całkowitą: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba < 0)
            {
                Console.WriteLine("Wprowadzono liczbę mniejszą od zera. Koniec programu.");
                break;
            }
            Console.WriteLine($"Wprowadzono: {liczba}");
        }
    }
}

