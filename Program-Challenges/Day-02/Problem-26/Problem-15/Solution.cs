namespace OrderPriority
{
    public class Priority
    {
        public static void OrderOfPriority()
        {
            Console.WriteLine("Enter the value of X:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{-6 + nX * 5}");
            Console.WriteLine($"{(13-2) * nX}");
            Console.WriteLine($"{(nX+ -2) * (20 / 10)}");
            Console.WriteLine($"{(12 + nX)/(5 - 4)}");

        }
    }
}