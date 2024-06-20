namespace DoubleValue
{
    public class DoubleValueDataType{
        public static void Calculate(int a,int b)
        {
            Console.WriteLine($"Perimeter: {a * 2 + b * 2}");
            Console.WriteLine($"Area: {a * b}");
            Console.WriteLine($"diagonal: {a + b + Math.Sqrt(a + b)}");
        }
        
    }
}