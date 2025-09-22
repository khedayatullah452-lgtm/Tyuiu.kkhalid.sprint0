using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.kkhalid.sprint0.task6.v0
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5, };
            //пример циклической структуры находится в бибиотеке в методу AdditionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));

            ///пример циклической структуры находится в бибиотеке в методу SubtractionArray
            Console.WriteLine("РАЗНОСТЬ ЭЛЕМЕНТОВ МАССИВА = " + DataService.SubtractionArray(numsArray));
            ///пример циклической структуры находится в бибиотеке в методу MultiplicationArray
            Console.WriteLine("произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
