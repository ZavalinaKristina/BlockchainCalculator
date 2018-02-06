using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            var operations = calc.GetOperNames();
            Console.WriteLine("Калькулятор");

            if (args.Length == 0)
            {
                Console.WriteLine("Введите операцию");
                foreach (var item in operations)
                {
                    Console.WriteLine(item);
                }
                string oper = Console.ReadLine();

                Console.WriteLine("Введите параметры через запятую");
                string x = Console.ReadLine();
                args = new[] { oper, x };
            }

            Сalculation(args[0], args[1]);

            Console.ReadKey();
        }

        static void Сalculation(string oper, string x)
        {
            var calc = new Calc();
            double[] a = x.Split(',').Select(s => double.Parse(s)).ToArray();

            var result = calc.Exec(oper, a);

            Console.WriteLine($"{oper}({String.Join(",", a)}) = {result}");
        }
    }
}
