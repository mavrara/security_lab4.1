using System;
using System.IO;
using System.Numerics;


namespace LargeNumbersCalculator
{
    class Adder
    {
        private static Random random = new Random();
        private const int MinNumberOfDigits = 1000;
        private const int MaxNumberOfDigits = 10000;

        public static string SumValuesFromFiles(String path)
        {
            string[] lines = File.ReadAllLines(path);

            BigInteger firstNumber = BigInteger.Parse(lines[0]);
            BigInteger secondNumber = BigInteger.Parse(lines[1]);

            Console.WriteLine("\nПерше довге числ:\n");
            Console.WriteLine(firstNumber);
            Console.WriteLine("\nДруге довге число:\n");
            Console.WriteLine(secondNumber);

            return (firstNumber + secondNumber).ToString();
        }

        public static string SumValuesFromFiles2(String path)
        {
            string[] lines = File.ReadAllLines(path);

            BigInteger firstNumber = BigInteger.Parse(lines[0]);
            BigInteger secondNumber = BigInteger.Parse(lines[1]);

            Console.WriteLine("\nПерше довге число:\n");
            Console.WriteLine(firstNumber);
            Console.WriteLine("\nДруге довге число:\n");
            Console.WriteLine(secondNumber);

            return (firstNumber - secondNumber).ToString();
        }

        public static string SumValuesFromFiles3(String path)
        {
            string[] lines = File.ReadAllLines(path);

            BigInteger firstNumber = BigInteger.Parse(lines[0]);
            BigInteger secondNumber = BigInteger.Parse(lines[1]);

            Console.WriteLine("\nПерше довге число:\n");
            Console.WriteLine(firstNumber);
            Console.WriteLine("\nДруге довге число:\n");
            Console.WriteLine(secondNumber);

            return (firstNumber * secondNumber).ToString();
        }

        public static string SumValuesFromFiles4(String path)
        {
            string[] lines = File.ReadAllLines(path);

            BigInteger firstNumber = BigInteger.Parse(lines[0]);
            BigInteger secondNumber = BigInteger.Parse(lines[1]);

            Console.WriteLine("\nПерше довге число:\n");
            Console.WriteLine(firstNumber);
            Console.WriteLine("\nДруге довге число:\n");
            Console.WriteLine(secondNumber);

            return (firstNumber / secondNumber).ToString();
        }
        public static string SumGeneratedValues()
        {
            string firstString = GenerateLongValue();
            string secondString = GenerateLongValue();

            BigInteger firstNumber = BigInteger.Parse(firstString);
            BigInteger secondNumber = BigInteger.Parse(secondString);

            Console.WriteLine("\nПерше довге число:\n");
            Console.WriteLine(firstString);
            Console.WriteLine("\nДруге довге число:\n");
            Console.WriteLine(secondString);

            return (firstNumber + secondNumber).ToString();
        }

        public static string GenerateLongValue()
        {
            int numberOfDigits = random.Next(MinNumberOfDigits, MaxNumberOfDigits);
            string generatedNumber = "";

            for (int i = 0; i < numberOfDigits; i++)
            {
                generatedNumber += GenerateDigit();
            }
            return generatedNumber;
        }
        public static string SumGeneratedValues2()
        {
            string firstString = GenerateLongValue();
            string secondString = GenerateLongValue();

            BigInteger firstNumber = BigInteger.Parse(firstString);
            BigInteger secondNumber = BigInteger.Parse(secondString);

            Console.WriteLine("\nПерше довге число:\n");
            Console.WriteLine(firstString);
            Console.WriteLine("\nДруге довге число:\n");
            Console.WriteLine(secondString);

            return (firstNumber - secondNumber).ToString();
        }
        public static string SumGeneratedValues3()
        {
            string firstString = GenerateLongValue();
            string secondString = GenerateLongValue();

            BigInteger firstNumber = BigInteger.Parse(firstString);
            BigInteger secondNumber = BigInteger.Parse(secondString);

            Console.WriteLine("\nПерше довге число:\n");
            Console.WriteLine(firstString);
            Console.WriteLine("\nДруге довге число:\n");
            Console.WriteLine(secondString);

            return (firstNumber * secondNumber).ToString();
        }
        public static string SumGeneratedValues4()
        {
            string firstString = GenerateLongValue();
            string secondString = GenerateLongValue();

            BigInteger firstNumber = BigInteger.Parse(firstString);

            Console.WriteLine("\nДовге число:\n");
            Console.WriteLine(firstString);

            return (firstNumber * firstNumber).ToString();
        }
        public static string SumGeneratedValues5()
        {
            string firstString = GenerateLongValue();
            string secondString = GenerateLongValue();

            BigInteger firstNumber = BigInteger.Parse(firstString);
            BigInteger secondNumber = BigInteger.Parse(secondString);

            Console.WriteLine("\nПерше довге число:\n");
            Console.WriteLine(firstString);
            Console.WriteLine("\nДруге довге число:\n");
            Console.WriteLine(secondString);

            return (firstNumber % secondNumber).ToString();
        }

        public static string GenerateDigit()
        {
            return random.Next(0, 10).ToString();
        }
    }
}
