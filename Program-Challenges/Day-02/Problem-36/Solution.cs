namespace RepetitiveStructure
{
    public class Repetitive
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the X value:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y value:");
            int nY = Convert.ToInt32(Console.ReadLine());

            for(int i = nX ; i <= nY; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            

            while(nX <= nY)
            {
                Console.Write(nX);
                nX++;
            }
            Console.WriteLine();

            int nI = nX;
            do
            {
                Console.Write(nI);
                nI++;
            }
            while(nI <= nY);
            Console.WriteLine();

        }
    }
}