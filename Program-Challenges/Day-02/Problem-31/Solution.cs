namespace Repeated
{
    public class NumberRepetaed
    {
        public static void RepeatedNumber()
        {
            Console.WriteLine("Enter the Value of X:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Times it will print:");
            int nCount = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < nX; i++)
            {
                Console.WriteLine(nX);
            }
        }
    }
}