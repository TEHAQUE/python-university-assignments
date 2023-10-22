using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void Zadanie1()
        {
            Licz licz1 = new Licz();
            licz1.addValue(5);
            licz1.view();
            licz1.addValue(53);
            licz1.subValue(23);
            licz1.view();

            Licz licz2 = new Licz(123);
            licz2.addValue(123);
            licz2.view();
        }
        static void Zadanie2()
        {
            int[] oceny = { 1, 3, 2, 1, 4, 5, 6, 4, 2, 4, 2, 3 };
            Sumator suamtor = new Sumator
        }
    }
}
