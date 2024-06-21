namespace CalculateValuefunctions
{
    public class FunctionsCalculations
    {
        public static void ValuesFunctions()
        {
            Console.WriteLine("Enter the value of X:");
            int nX1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of Y:");
            int nX2 = Convert.ToInt32(Console.ReadLine());

            for(int i = nX1; nX1 <= nX2; i++)
            {
                int nY = nX1*nX1 - 2*nX1 + 1;
                Console.WriteLine(nY);
            }
        }
    }
}