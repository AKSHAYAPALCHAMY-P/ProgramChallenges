using System.Diagnostics;


namespace BasicCalculator
{
    public class Calculator
    {
        public static void Solution(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {(x + y)}");
            Console.WriteLine($"{x} + {y} = {(x - y)}");
            Console.WriteLine($"{x} * {y} = {(x *  y)}");
            Console.WriteLine($"{x} / {y} = {(x / y)}");
            Console.WriteLine($"{x} mod {y} = {(x % y)}");
        }

        //    public static int add(int x, int y) 
        //    {
        //        return x + y;
        //    }

        //    public static int subtract(int x, int y)
        //    {
        //        return x - y;
        //    }

        //    public static int multiply(int x, int y)
        //    {
        //        return x * y;
        //    }

        //    public static int division(int x, int y)
        //    {
        //        return x / y;
        //    }

        //    public static int modulo(int x, int y)
        //    {
        //        return x % y;
        //    }
    }
}