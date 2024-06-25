namespace TwoDimensionalArray
{
    public class ArithmeticAverage
    {
        public static void Solution()
        {
            int nTotalByGroup = 10;
            float[,] nTotalGroup = new float[2, nTotalByGroup];
            float nTotalGroup1 = 0.0f; float nTotalGroup2 = 0.0f;

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter{nTotalByGroup} numbers for Group{i + 1}:");

                for(int j = 1; j < nTotalByGroup; j++)
                {
                    nTotalGroup[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }


            for(int i = 0; i < nTotalByGroup; i++)
            {
                nTotalGroup1 += nTotalGroup[0, i];
                nTotalGroup2 += nTotalGroup[1, i];
            }


            Console.WriteLine("Average for Group 1 is {0}", nTotalGroup1 / nTotalByGroup);
            Console.WriteLine("Average for Group 2 is {1}", nTotalGroup2 / nTotalByGroup);

            Console.ReadLine();




        }
    }

}
