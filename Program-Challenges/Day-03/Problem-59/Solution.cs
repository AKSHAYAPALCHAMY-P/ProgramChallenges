namespace ArraySearch
{
    public class ArithmeticMean
    {
        public static void Solution()                                                                                                   
        {
            int nTotal = 10;

            int nCountPositive = 0;
            int nCountNegative = 0;

            int nTotalPositive = 0; 
            int nTotalNegative =0;

            int[] nNums = new int[nTotal];

            Console.WriteLine($"Enter {nTotal} Integers:");
            for(int i = 0; i < nTotal; i++) 
            {
                nNums[i] = Convert.ToInt32(nNums[i]);
            }

            for(int i = 0; i < nTotal; i++) 
            { 
                if(nNums[i] > 0)
                {
                    nTotalPositive = nTotalPositive + nNums[i];
                    nCountPositive++;
                }

                if(nNums[i] < 0)
                {
                    nTotalNegative = nTotalNegative + nNums[i];
                    nCountNegative++;
                }
            }

             double dAveragePositive = nTotalPositive / nCountPositive;
             double dAverageNegative = nTotalNegative / nCountNegative;


            Console.WriteLine("Average of Positive Numbers:",dAveragePositive);
            Console.WriteLine("Average of Negative Numbers:", dAverageNegative);

        }
    }                                       
}