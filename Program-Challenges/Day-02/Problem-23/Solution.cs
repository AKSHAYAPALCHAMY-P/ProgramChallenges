namespace GreatestOfThree
{
    public class BiggestOne
    {
        public static void BiggestAmongThree()
        {
            Console.WriteLine("Enter the First Number");
            int nFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int nSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Three Number");
            int nThird = Convert.ToInt32(Console.ReadLine());

            if(nFirst > nSecond && nFirst > nThird)
            {
                Console.WriteLine("First is the Biggest one");
            }

            if(nSecond > nFirst && nSecond > nThird)
            {
                Console.WriteLine("Second is the Biggest one");
            }

            if(nThird > nFirst && nThird > nSecond)
            {
                Console.WriteLine("Third is the Biggest one");
            }

        }
    }
}