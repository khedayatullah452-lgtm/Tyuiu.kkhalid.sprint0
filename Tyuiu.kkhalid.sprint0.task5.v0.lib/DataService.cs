using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.kkhalid.sprint0.task5.v0.lib
{
    public class DataService

    //Пример линейной структуры

    {
        public static int Addition(int a, int b)
        { return a + b; }

        //Пример линейной структуры

        public static int Subtraction(int a, int b)
        { return a - b; }

        //Пример линейнщи структуры

        public static int Multiplication(int a, int b)

        {
            { return a * b; }
        }

        public static double Division(int a, int b)
        {


            if (b == 0)

                //пример создан в целях демонстрации ветвления
                //в реальных проектах нужно использовать Exception
                Console.WriteLine("переменная Ь ={0} на ноль делить нельзя,b");
            return -1;
        }
        else
        {
            return a / b ;
        }


     

    
}
  

















