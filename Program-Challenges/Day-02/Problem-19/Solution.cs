namespace Rectangle
{
    public class DrawRectangle
    {
        public static void RectangleDrawing()
        {
            Console.WriteLine("Enter the number of Rows:");
            int nRows = Convert.ToInt32(Console.ReadLine());

            

            for(int i = 0; i <= 5; i++)
            {
                for(int j = nRows; j <= 5; j++)
                {
                    Console.Write("3");
                }

                Console.WriteLine();
            }
        }
    }
}