using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHK_GenerateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int kdnr = 43234;
            int date = 121212;
            string kennung = getHerkunft(kdnr);
            string kwjahr = getKWJahr(date);
            long code = generateCode(kennung, kwjahr);
            Console.WriteLine($"{code}");
            string countryCode = getLand(code);
            Console.WriteLine($"{countryCode}");
            Console.ReadLine();
        }

        private static string getLand(long code)
        {
            char first = (char)(code / 2300 / 54 / 91 / 91);
            char second = (char)(code / 2300 / 54 / 91 % 91);
            char third =  (char)(code / 2300 / 54 % 91);
            return first.ToString() + second.ToString() + third.ToString();
        }

        private static long generateCode(string kennung, string kwjahr)
        {
            long code = 0;
            string ww = kwjahr.Substring(0, 2);
            string yyyy = kwjahr.Substring(2);
            code = ((((long)kennung[0] * 91 + kennung[1]) * 91 + kennung[2]) * 54 + Convert.ToInt32(ww)) * 2300 + Convert.ToInt32(yyyy);
            Console.WriteLine(kennung[0]);
            return code;
        }

        private static string getKWJahr(int date)
        {
            return "392011";
        }

        private static string getHerkunft(int kdnr)
        {
            return "GER";
        }
    }
}
