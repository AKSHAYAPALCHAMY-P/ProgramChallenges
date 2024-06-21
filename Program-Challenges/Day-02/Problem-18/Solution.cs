namespace Square
{
    public class DrawSquare
    {
        public static void SquareDrawing()
        {
            Console.WriteLine("Enter the number of X:");
            int nX=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of Width:");
            int nWidth = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < nWidth; i++)
            { 
                for(int j = 0; j < nWidth; j++)
                {
                    Console.Write(nX);
                }

                Console.WriteLine();
            }
        }
    }
}