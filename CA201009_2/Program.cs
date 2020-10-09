using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201009_2
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            int y = 20;
            int sum = Osszead(x, y);
        }

        private static int Osszead(int x, int y) => x + y;

        private static Random rnd = new Random();
        /// <summary>
        /// Generál egy véletlenszerű jelszónak használható karakterláncot
        /// </summary>
        /// <param name="length">meghatározza a karakterlánc hosszát</param>
        /// <returns>egy véletlen karakterek szekvenciája</returns>

        private static string GetRndPassword(int length)
        {
            string pwd = "";
            for (int i = 0; i < length; i++)
            {
                pwd += RndChar();
            }
            return pwd;
        }

        private static readonly string similar = "0oO1lLqg9";
        private static char RndChar()
        {
            var intv = new (int, int)[] 
            { 
                (65, 91), (97, 123), (48, 58)
            };
            int r = rnd.Next(3);
            var c = (char)rnd.Next(intv[r].Item1, intv[r].Item2);
            return similar.Contains(c) ? RndChar() : c;
        }
    }
}
