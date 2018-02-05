﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleCalc;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");

            var oper = args[0];
            var x = double.Parse(args[1]);
            var y = double.Parse(args[2]);

            Сalculation(oper, x, y);
            Console.ReadKey();
        }

        static void Сalculation(string oper, double x, double y)
        {
            var calc1 = new Calc();
            if (oper == "sum")
            {
                Console.WriteLine($"SUM({x}, {y}) = {calc1.Sum(x, y)}");
            }
            else if (oper == "sub")
            {
                Console.WriteLine($"SUB({x}, {y}) = {calc1.Sub(x, y)}");
            }
            else if (oper == "mult")
            {
                Console.WriteLine($"MULT({x}, {y}) = {calc1.Mult(x, y)}");
            }
            else if (oper == "segm")
            {
                Console.WriteLine($"SEGM({x}, {y}) = {calc1.Segm(x, y)}");
            }
            else if (oper == "pow")
            {
                Console.WriteLine($"POW({x}, {y}) = {calc1.Pow(x, y)}");
            }
            else
            {
                Console.WriteLine("Введите операцию");
                oper = Console.ReadLine();
                Console.WriteLine("Введите первый аргумент");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второй аргумент");
                y = double.Parse(Console.ReadLine());
                Сalculation(oper, x, y);
            }
        }
    }
}
