namespace DoWhile
{
    public class DoWhileLooping
    {
        public static void DoWhileLoops()
        {
            Console.WriteLine("Enter the number for x:");
            int nValue = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(10 * nValue);
            }

            while(nValue != 0);
        }
    }
}