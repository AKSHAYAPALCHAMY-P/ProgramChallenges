namespace DivisionOperations
{
    public class Division
    {
        public static void ArithmeticDivision()
        {
            Console.WriteLine("Enter the first number");
            int nFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            int nSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nFirst/nSecond}\n{nFirst % nSecond}");

        }
    }
}