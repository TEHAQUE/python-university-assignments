using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szkola
{
    internal class Nauczyciel : Uczen
    {
        public string tytulNaukowy { get; set; }
        private List<Uczen> podwladniUczniowie;
        public Nauczyciel(string im, string naz, string pes, string szk, string tytul) : base(im, naz, pes, szk)
        {
            tytulNaukowy = tytul;
            podwladniUczniowie = new List<Uczen>();
        }

        public void SetAcademicTitle(string tytul)
        {
            tytulNaukowy = tytul;
        }

        public void AddStudent(Uczen uczen)
        {
            podwladniUczniowie.Add(uczen);
        }
        public void WhichStudentCanGoHomeAlone()
        {
            Console.WriteLine("Uczniowie, którzy mogą iść sami do domu:");

            foreach (var uczen in podwladniUczniowie)
            {
                if (uczen.CanGoAloneToHome())
                {
                    Console.WriteLine($"- {uczen.GetFullName()}");
                }
            }
        }
    }
}
