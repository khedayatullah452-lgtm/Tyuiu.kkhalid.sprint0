using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.kkhalid.sprint0.task4.v0.lib;

namespace Tyuiu.kkhalid.sprint0.task4.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ПРИМЕР ЛИНЕЙНОЙ СТРУКТУРЫ ПРОГРАММЫ
            //ВЫЗОВ МЕТОДА СЛОЖЕНИЯ ADDITION
            Console.WriteLine(DataService.Addition(1, 5));
            //Вызов Метода Вычитания Subtraction
            Console.WriteLine(DataService.Subtraction(15, 5));
            //Вызов Метода умножения Multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));
            //Вызов метода деления Division
            Console.WriteLine(DataService.Division(5, 5));    

            Console.ReadKey();
        }
    }
}
