namespace NumbersSum
{
    public class SumNumbersInfinite
    {
        public static void sumInfinite()
        {
            
            Console.WriteLine("Enter the number do you add:");
            int nNumber = Convert.ToInt32(Console.ReadLine());

            int nTotal = 0;

            do
            {
                nTotal = Convert.ToInt32(Console.ReadLine());
                nTotal = nTotal + nNumber;

                if( nNumber != 0) 
                {
                    Console.WriteLine(nTotal);
                }
                
                 
            }

            while(nTotal != 0);
            {
                Console.WriteLine("Finished");
            }


        }
    }
}