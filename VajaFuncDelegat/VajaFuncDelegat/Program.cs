using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaFuncDelegat
{
    internal class Program
    {
        //delegate string Spremeni(string s);
        static void Main(string[] args)
        {
            Func<string, int, string> metoda = (x, i) => x.ToUpper();

            string ime = "blaž";
            
            Console.WriteLine(metoda(ime, 66));
        }

        //private static string VVelike(string s)
        //{
        //    return s.ToUpper();
        //}
    }
}
