namespace Rectangle
{
    public class DrawRectangle
    {
        public static void RectangleDrawing()
        {
            Console.WriteLine("Enter the number of Rows:");
            int nValue = Convert.ToInt32(Console.ReadLine());


            

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(nValue);
                }

                Console.WriteLine();
            }
        }
    }
}