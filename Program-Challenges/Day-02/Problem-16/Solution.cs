namespace Average
{
    public class CalculateAverage
    {
        public static void AverageCalculations()
        {
            Console.WriteLine("Enter the Total Numbers:");
            int nTotal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the First Number");
            int nA=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int nB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third Number");
            int nC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fourth Number");
            int nD = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{(nA+nB+nC+nD) / nTotal}");
        }
    }
}