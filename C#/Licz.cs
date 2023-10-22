using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Licz
    {
        public int value;

        public int addValue(int a)
        {
            return value += a;
        }
        public int subValue(int a)
        {
            return value -= a;
        }
        public void view()
        {
            Console.WriteLine("Wartość obiektu " + this.value);
        }
       
        public Licz(int a)
        {
            value = a;
            Console.WriteLine("Konstruktor z jednym argumentem");
        }
        public Licz()
        {
            value = 0;
   
            Console.WriteLine("Konstruktor bezarguemntowy");
        }
    }
