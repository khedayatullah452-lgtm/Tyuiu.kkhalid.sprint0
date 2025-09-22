using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tyuiu.kkhalid.sprint0.task6.v0.lib
{
    public class DataService
    {
        private static object tatol;
        private static int i;

        //пример циклической структыры (цикл с параметрами) for
        public static object AdditionArray(int[] numbers)
        {
            {
                Var total = 0;
                for (var i = 0; i < numbers.Length; i++) { }

                total = total + numbers[i]; 

            }

            return tatol;
        }
        //Пример циклической структыры (цикл с предусловием) While
        public static object SubtractionArray(int[] numbers)
        {
            Var total = 0;
            int index = 0;

            while (index < numbers.Length) { }
            {
                total = total - numbers[index];
            
                

            }
            index++;

            return total;

        }

        //пример циклической структыры (цикл с постусловием) do while
        public static object MnltiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total  * numbers[index];
                index++;
            }
            while (index< numbers.Length);
            return total;
        }

    }

}



