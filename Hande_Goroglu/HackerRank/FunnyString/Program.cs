using System;
namespace FunnyString
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                HandleTestCase();
            }
        }
        static void HandleTestCase()
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length - 1; i++)
            {
                int lastIndex = str.Length - i - 1;
                int mod1 = Math.Abs(str[i] - str[i + 1]);
                int mod2 = Math.Abs(str[lastIndex] - str[lastIndex - 1]);
                if (mod1 != mod2)
                {
                    Console.WriteLine("Not Funny");
                    return;
                }
            }
            Console.WriteLine("Funny");
        }
    }
}
