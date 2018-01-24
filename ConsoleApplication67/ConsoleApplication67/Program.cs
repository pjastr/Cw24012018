using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication67
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<DateTime>> prac = new Dictionary<string, List<DateTime>>();
            prac.Add("Nowak", new List<DateTime>() { new DateTime(2017,2,11), new DateTime(2017,2,13)});
            prac.Add("Kowalski", new List<DateTime>() { new DateTime(2017, 2, 1) });
            foreach(var element in prac)
            {
                string opis = "";
                opis = "Pracownik " + element.Key + " jego dyżury" + Environment.NewLine;
                foreach(var el2 in element.Value)
                {
                    opis += el2.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-US")) + Environment.NewLine;
                }
                Console.WriteLine(opis);
            }
            Console.ReadKey();
        }
    }
}
