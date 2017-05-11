using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef24nr1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dier> dieren = new List<Dier>();
            Dier koe = new Koe() { Gewicht = 500};
            Dier slang = new Slang() { Gewicht = 50};
            Dier varken = new Varken() { Gewicht = 350};
            dieren.Add(koe);
            dieren.Add(slang);
            dieren.Add(varken);

            foreach (Dier d in dieren)
            {
                d.Zegt();
            }
        }
    }
}
