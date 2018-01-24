using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma f = new Firma();
            f.DodajPracownika("Jan Kowalski");
            f.DodajPracownika("Adam Nowak");
            foreach (var prac in f)
            {
            Console.WriteLine(prac);
            }

            Console.ReadKey();
        }
    }

    class Firma:IEnumerable
    {
        List<string> pracownicy;
        public Firma()
        {
            pracownicy = new List<string>();
        }

        public void DodajPracownika(string p1)
        {
            pracownicy.Add(p1);
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var element in pracownicy)
            {
                yield return element;
            }
        }
    }
}
