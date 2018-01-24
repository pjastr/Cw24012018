using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class WlasnaKlasa
    {
        private static WlasnaKlasa instancja;
        private WlasnaKlasa()
        {

        }

        public static WlasnaKlasa Utworz()
        {
            if (instancja == null)
            {
                instancja = new WlasnaKlasa();
            }
            return instancja;
        }
    }
}
