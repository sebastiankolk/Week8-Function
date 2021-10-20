using System;

namespace Functions
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("sisesta oma eesnimi.");
            string username = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonna nimi.");
            string username2 = Console.ReadLine();
            Console.WriteLine("sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Greetings(username, username2, userAge);
        }

        private static void Greetings(string someName,string SomeName2, int someNumber)
        {
            Console.WriteLine($"Tere, {someName} {SomeName2}");
            Console.WriteLine($"oled sündinud aastal {2021 - someNumber}.");

        }
    }
}
