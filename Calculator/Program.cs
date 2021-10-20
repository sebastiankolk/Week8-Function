using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene number ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teine number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vali tehe ('+', '-', '*' või '/'");
            char useroperation = Convert.ToChar(Console.ReadLine());

            switch (useroperation)
            {
                case '+':
                    AddTwoNumbers(number1, number2);
                    break;
                case '-':
                    SubstractTwoNumbers(number1, number2);
                    break;
                case '*':
                    KorrutaTwoNumbers(number1, number2);
                    break;
                case '/':
                    DivideTwoNumbers(number1, number2);
                    break;
                default:
                    Console.WriteLine("invalid tehe");
                    break;
            }

        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }
        private static void SubstractTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }
        private static void KorrutaTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");

        }
    }
}
