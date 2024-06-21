namespace DoWhile
{
    public class DoWhileLooping
    {
        public static void DoWhileLoops()
        {
            int nValue = 0;

            do
            {
                Console.WriteLine("Enter the number for x:");
                nValue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(10 * nValue);
            }
            while(nValue != 0);
        }
    }
}