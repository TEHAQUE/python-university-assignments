using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sumator
    {
        public int[] Liczby;

        public int Sumy()
        {
            int suma = 0;
            foreach(int elem in Liczby)
            {
                suma += elem;
            }
            return suma;
        }
        public SumaPodziel2()
        {
            int suma = 0;
            if (elem % 2 == 0)
                suma += elem;
        }
    }
}
