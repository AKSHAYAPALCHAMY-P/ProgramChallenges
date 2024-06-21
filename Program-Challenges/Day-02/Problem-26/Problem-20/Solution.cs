namespace Calculator
{
    public class BasiccalculatorOperation
    {
        public static void CalculatorOperations()
        {
            Console.WriteLine("Enter the First Number:");
            int nFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Operator:");
            int nOperator = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            int nSecond = Convert.ToInt32(Console.ReadLine());

            if(nOperator == '+')
            {
                Console.WriteLine($"{nFirst + nSecond}");
            }

            else if(nOperator == '-')
            {
                Console.WriteLine($"{nFirst - nSecond}");
            }

            else if(nOperator == '*')
            {
                Console.WriteLine($"{nFirst * nSecond}");
            }

            else if(nOperator == '/')
            {
                Console.WriteLine($"{nFirst / nSecond}");
            }

            else
            {
                Console.WriteLine("Unrecognized character");
            }
        }
    }
}