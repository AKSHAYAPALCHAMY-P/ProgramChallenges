namespace ConditionalOperators
{
    public class ArithmeticConditional
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the First Number");
            int nA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int nB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(nA > 0 ? "A is Positive" : "A is not Positive");
            Console.WriteLine(nB > 0 ? "B is Positive" : "B is not Positive");
            Console.WriteLine(nA > 0 && nB >0 ? "Both are Positive" : "Both are Negative");

        }
    }
}