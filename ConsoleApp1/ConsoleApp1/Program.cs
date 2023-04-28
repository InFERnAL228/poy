using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            double ma = 0.0;
            double cm = 0.0;
            double mm = 0.0;
            double d = 0.0;
            Console.WriteLine("Введите число дюймов:");
            d = Convert.ToDouble(Console.ReadLine()); //
            cm = 2.54 * d;
            mm = 2.54 * d * 10;
            ma = 2.54 * d / 100; //
            Console.WriteLine(" {0} м, {1} см, {2} мм", ma, cm, mm);
            Console.ReadKey();
        }
    }
}