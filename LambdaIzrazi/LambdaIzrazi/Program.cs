using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaIzrazi
{
    internal class Program
    {
        //delegate bool FunkcijaZaNize(string s);
        static void Main(string[] args)
        {
            string[] imena = {"David","Blaž","Ivan","David","Neža","Alen","Saša","Erik","Simon","Mitja","Kristjan"};

            List<string> a = DelajOperacijeNadNizi(imena, ZacneSS);

            //FunkcijaZaNize anonimna = delegate (string s) { return s.EndsWith("n"); };

            //List<string> b = DelajOperacijeNadNizi(imena, delegate (string s) { return s.EndsWith("n"); });

            List<string> b = DelajOperacijeNadNizi(imena, s => s.EndsWith("n"));

            foreach (string x in b)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }

        static List<string> DelajOperacijeNadNizi(string[] mojiNizi, Func<string, bool> mojaFunkcija)
        {
            List<string> rezultat = new List<string>();

            foreach (string x in mojiNizi)
            {
                if (mojaFunkcija(x))
                    rezultat.Add(x);
            }

            return rezultat;
        }

        static bool ZacneSS(string a)
        {
            return a.StartsWith("S");
        }

        static bool KoncaZN(string a)
        {
            return a.EndsWith("n");
        }
    }
}
