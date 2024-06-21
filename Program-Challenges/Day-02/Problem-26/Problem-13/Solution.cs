namespace MultiplyFactors
{
    public class MultiplyThreeFactorsContext
    {
        public static void MultiplicationOfThree()
        {
            Console.WriteLine("Enter the First Number:");
            int nValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            int nValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third Number:");
            int nValue3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nValue1 * nValue2 * nValue3}");

        }
    }
}