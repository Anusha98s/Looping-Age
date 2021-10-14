using System;

namespace Looping_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter yur age");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age>18)
            {
                Console.WriteLine("Eligible for voting");
            }
            else
            {
                Console.WriteLine("Not Eligible for voting");
            }
        }
    }
}
