namespace HollowRectAngle
{
    public class RectangleHollow
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the Symbol:");
            char cSymbol = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            int nWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Height:");
            int nHeight = int.Parse(Console.ReadLine());

            for(int i = 0; i <nHeight; i++)
            {
                for(int j = 0; j < nWidth; j++) 
                {
                    if(i == 0 || i == nHeight - 1 || j == 0 || j == nWidth - 1)
                    {
                        Console.Write(cSymbol);
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