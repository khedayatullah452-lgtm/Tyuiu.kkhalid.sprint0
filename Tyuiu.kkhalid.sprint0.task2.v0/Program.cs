using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ПодклочеTyuiu.kkhalid.sprint0.task2.libuiu.kkhalid.sprint0.task2.v0.Lib;


namespace Tyuiu.kkhalid.sprint0.task2.v0


internal class Program
{
    public static object Dataservice { get; private set; }

    static void Main(string[] args)
    {
        //вызов класса DataService и митода GetMessage
        //из библиотеки Tyuiu.kkhalid.sprint0.task2.v0.Lib
        Console.WriteLine(Dataservice.GetMessage("khalid"));
      Console.ReadKey();
    }
}
