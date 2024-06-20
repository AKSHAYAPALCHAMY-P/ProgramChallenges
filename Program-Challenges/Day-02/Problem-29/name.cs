namespace Triangle
{
    public class TriangleDrawing()
    {
        public static void DrawTriangle()
        {
            Console.WriteLine("Enter the number of X:");
            int nX=Convert.ToInt32(Console.ReadLine());

          
            Console.WriteLine("Enter the height of the triangle:");
            int nWidth = Convert.ToInt32(Console.ReadLine());

            for(int i = nWidth; i > 0; i--) 
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(nX);
                }

                Console.WriteLine();
            }

        }  
    }
}
