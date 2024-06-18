using System;

namespace Read
{
    public class ReadLine
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("What is Your Favourite Animal?");
            var x = Console.ReadLine();

            Console.ReadKey();
            Console.WriteLine("Mine Too!");
        }
    }
}