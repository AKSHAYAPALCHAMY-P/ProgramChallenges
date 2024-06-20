namespace While
{
    public class whileLopping
    {
        public static void InstrutionWhile()
        {
            Console.WriteLine("Enter the X Value:");
            int nX = Convert.ToInt32(Console.ReadLine());

            while(nX != 0)
            {
                Console.WriteLine($"{10 * nX}");
                nX = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}