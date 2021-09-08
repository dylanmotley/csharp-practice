using System;

namespace MyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String choice = "y";
            while (choice.Equals("y"))
            {

                Console.WriteLine("Enter Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                int total = num1 * num1;

                Console.WriteLine(total);

                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
            }


        }
    }
}
