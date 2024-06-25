using System;

namespace HollowSquare
{
    public class DrawHollowSquare
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the Width of the square:");
            int nWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Height of the square:");
            int nHeight = int.Parse(Console.ReadLine());

            for(int i = 0; i < nHeight; i++)
            {
                for(int j = 0; j < nWidth; j++)
                {
                    if(i == 0 || i == nHeight - 1 || j == 0 || j == nWidth - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}
