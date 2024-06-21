namespace MultipleNumbers
{
    public class MultipledNumbers
    {
        public static void MultiplyOperations()
        {
            for (int i = 0; i <= 500; i++)
            {
                if(i % 3 ==0 && i % 15 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}