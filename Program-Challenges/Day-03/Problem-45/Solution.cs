namespace CheckNumbers
{
    public class Exceptions
    {
        public static void CheckException()
        {
            Console.WriteLine("Enter the X value:");
            string? strText = Convert.ToString(Console.ReadLine());

            try
            {
                Convert.ToInt32(strText);
                Console.WriteLine("It's not a number");

            }

            catch
            {
                Console.WriteLine("It's a Text");
            }
        }
    }
}