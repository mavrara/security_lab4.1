using System;
using System.IO;

namespace LargeNumbersCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nSUMA:\n" + Adder.SumGeneratedValues());
            Console.WriteLine("\nСУМА:\n" + Adder.SumValuesFromFiles(Path.Combine(Environment.CurrentDirectory, "числа.txt")));
            Console.ReadKey();
            Console.WriteLine("\nРIЗНИЦЯ:\n" + Adder.SumGeneratedValues2());
            Console.ReadKey();
            Console.WriteLine("\nДОБУТОК:\n" + Adder.SumGeneratedValues3());
            Console.ReadKey();
            Console.WriteLine("\nКВАДРАТ:\n" + Adder.SumGeneratedValues4());
            Console.ReadKey();
            Console.WriteLine("\nЗАЛИШКИ ПО МОДУЛЮ ДІЛЕННЯ ДВОХ ЧИСЕЛ:\n" + Adder.SumGeneratedValues5());
            Console.ReadKey();
        }
    }
}
