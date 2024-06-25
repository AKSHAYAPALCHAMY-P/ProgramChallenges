using System;

namespace GraphicFunctions
{
    public class FunctionalGraphics
    {
        public static void Solution()
        {
           
            Console.WriteLine("Enter the start value of x:");
            int xStart = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end value of x:");
            int xEnd = int.Parse(Console.ReadLine());

            for(int x = xStart; x <= xEnd; x++)
            {
               
                int y = (x - 4) * (x - 4);

                
                for(int i = 0; i < y; i++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }

        
    }
}
