namespace PrimeNumber
{
    public class IdentifyPrimes
    {
        public static void PrimesNumbers()
        {
            Console.WriteLine("Enter the Number:");
            int nInput = Convert.ToInt32(Console.ReadLine());

            if(nInput % 10 != 0)
            {
                Console.WriteLine("Is Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}