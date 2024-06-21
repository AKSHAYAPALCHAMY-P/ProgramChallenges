namespace BubbleSort
{
    public class Sorting
    {
        public static void Solution()
        {
            int nTotal = 10;
            int[] nNumbers = new int[nTotal];

            Console.WriteLine($"Enter the {nTotal} Values");
            for(int i = 0; i < nTotal; i++) 
            { 
                nNumbers[i] = Convert.ToInt32( Console.ReadLine());
            }

            for(int i = 0;i < nTotal - 1; i++)
            {
                for(int j = 1; j < nTotal - 1; j++) 
                {
                    if(nNumbers[i] > nNumbers[i + 1])
                    {
                        int nFirst = nNumbers[j];

                         nNumbers[j] = nNumbers[i];

                        nNumbers[j] = nFirst;
                    }
                }
            }

            foreach(int n in nNumbers)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}