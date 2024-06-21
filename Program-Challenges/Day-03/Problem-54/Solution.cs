namespace ProductOfPrime 
{ 
    public class Product
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the number for factoring:");
            int nNumber = Convert.ToInt32(Console.ReadLine());

            int nDivisor = 2;

            while(nNumber > 1) 
            {
              while(nNumber %  nDivisor == 0)
                {
                    Console.Write(nDivisor + "X");
                    nNumber /= nDivisor;
                }
                nDivisor++;
                
            }
            Console.WriteLine(1);
        }
    }
}
    