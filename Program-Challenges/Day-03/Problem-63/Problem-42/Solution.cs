namespace Descending
{
    public class DescendingNumbers
    {
        public static void OddDescending()
        {
            Console.WriteLine("Enter the Biggest number");
            int nBiggest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Lowest number");
            int nLowest = Convert.ToInt32(Console.ReadLine());

            if(nBiggest % 2 == 0)
            {
                nBiggest--;
            }

            while(nBiggest > nLowest) 
            {
                Console.WriteLine(nBiggest);
                nBiggest -= 2;


            }

        }
    }
}