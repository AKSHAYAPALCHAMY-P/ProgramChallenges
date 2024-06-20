namespace ProductNumber
{
    public class Numbers
    {
        public static void ConsecutiveProduct()
        {
            Console.WriteLine("Enter the First number:");
            int nFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number:");
            int nSecond = Convert.ToInt32(Console.ReadLine());

            int nResult = 0;
            int nOne = 0;

            while(nOne < nSecond)
            {
                nResult = nResult + nFirst;
                nOne++;
            }

            Console.WriteLine($"{nFirst} x {nSecond} ={nResult}");


        }
    }
}