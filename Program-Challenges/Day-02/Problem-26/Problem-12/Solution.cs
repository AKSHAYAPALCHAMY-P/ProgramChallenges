namespace SumSquared
{
    public class Squaring
    {
        public static void SquareAdd()
        {
            Console.WriteLine("Enter the number for squaring:");
            int nValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nValue} x {nValue} = {nValue * 2}");

        }
    }
}