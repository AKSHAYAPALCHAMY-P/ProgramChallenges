namespace TriangleNorthEast
{
    public class TriangleClass
    {
        public static void NortheastTriangle()
        {
            Console.WriteLine("Enter the Width of the triangle");
            int nWidth = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < nWidth; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for(int k = i; k < nWidth; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
