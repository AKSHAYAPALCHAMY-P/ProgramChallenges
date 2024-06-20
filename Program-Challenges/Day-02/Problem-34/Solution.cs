namespace MultiplicationTable 
{
    public class RangeTables
    {
        public static void InfiniteMultiplicationtables()
        {
            Console.WriteLine("Enter the First Number");
            int nFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int nSecond = Convert.ToInt32(Console.ReadLine());

            for(int i = nFirst; i<= nSecond; i++)
            {
                for(int j=1; j<=10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
            }
        }
    }
}