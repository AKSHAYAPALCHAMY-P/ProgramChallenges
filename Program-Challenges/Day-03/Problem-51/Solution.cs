namespace MathematicalStatistics
{
    public class StatisticsOfFive
    {
        public static void DisplayStatistics()
        {
            Console.WriteLine("Enter the First Value:");
            int nFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Value:");
            int nSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third Value:");
            int nThird = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fourth Value:");
            int nFourth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fifth Value:");
            int nFifth = Convert.ToInt32(Console.ReadLine());

            int[] nNumbers = {nFirst,nSecond,nThird,nFourth,nFifth};

            int nTotal = 5;

            int nSum = 0;
            int nMean = 0;

            int nMax = int.MaxValue;
            int nMin = int.MinValue;
           

            foreach(int num in nNumbers)
            {
                nSum+= num; 

                if(nSum > num)
                {
                    nMax= num;
                }

                else
                {
                    nMin= num;
                }

                nMean = nSum / nTotal;


            }

            Console.WriteLine(nSum);
            Console.WriteLine(nMean);
            Console.WriteLine(nMax);
            Console.WriteLine(nMin);
        }
    }
}