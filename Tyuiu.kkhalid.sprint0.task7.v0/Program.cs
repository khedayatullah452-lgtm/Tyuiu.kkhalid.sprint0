using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.kkhalid.sprint0.task7.v0.lib;

namespace Tyuiu.kkhalid.sprint0.task7.v0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "спринт #0 | Выполнил: сприн И.С. |  пктб-23-1";
            //Длинна строки 75 символов
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* спринт #0                                                                *");
            Console.WriteLine("* тема: создания итогового решения по спринту                              *");
            Console.WriteLine("* задание #7                                                               *");
            Console.WriteLine("* вариант #0                                                               *");
            Console.WriteLine("* выполнил : спирин Игор Сергеевич | пктб-23-1                             *");
            Console.WriteLine("* условие :                                                                *");
            Console.WriteLine("* написать консольную программу на C#, которая суммирует значения двух     *");
            Console.WriteLine("* одиныковых массивов по длинне.                                           *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* исходные данные :                                                        *");
            Console.WriteLine("****************************************************************************");


            //место решения задания
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5, };

            Console.WriteLine("значение элементов массива №1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ",");
            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("значение элементов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ",");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* реэультат:****************************************************************");
            Console.WriteLine("****************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resulAarray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("сумма элементов массива ровна:");
                for (int i = 0; i < resulAarray.Length; i++)
                {
                    Console.WriteLine(resulAarray[i] + ",");
                }
            }
            else
            {
                Console.WriteLine("ошибка! исходные массивы имеют разное количество элементов");
                Console.ReadKey();

            }

        }
    }
}
       
        


    
    