namespace Switch
{
    public class Calculator
    {
        public static void BasicCalculatorFunction()
        {
            Console.WriteLine("Enter the First Number:");
            int nFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Operator:");
            int nOperator = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            int nSecond = Convert.ToInt32(Console.ReadLine());

            switch(nOperator)
            {

                case '+':
                    Console.WriteLine($"{nFirst + nSecond}");
                    break;

                case '-':
                    Console.WriteLine($"{nFirst - nSecond}");
                    break;

                case '*':
                    Console.WriteLine($"{nFirst * nSecond}");
                    break;

                case '/':
                    Console.WriteLine($"{nFirst / nSecond}");
                    break;

            }
        }
    }
}