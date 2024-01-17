using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szkola
{
    public class Uczen : Osoba
    {
        private string szkola;
        private bool mozeSamWracacDoDomu;

        public Uczen(string im, string naz, string pes, string szk) : base(im, naz, pes)
        {
            szkola = szk;
            mozeSamWracacDoDomu = false;
        }

        public void SetSchool(string szk)
        {
            szkola = szk;
        }

        public void SetCanGoHomeAlone()
        {
            mozeSamWracacDoDomu = true;
        }

        public void ChangeSchool(string nowaSzkola)
        {
            szkola = nowaSzkola;
            mozeSamWracacDoDomu = false;
        }

        public override void GetEducationInfo()
        {
            Console.WriteLine($"Uczeń uczęszcza do szkoły: {szkola}");
        }

        public override bool CanGoAloneToHome()
        {
            return mozeSamWracacDoDomu;
        }
    }
}
