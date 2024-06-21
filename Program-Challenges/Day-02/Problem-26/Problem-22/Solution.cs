namespace NumberChecking 
{ 
    public class CheckingNumbers
    {
        public static void NumberCheck()
        {
            Console.WriteLine("Enter the Number for Checking:");
            int nValue = Convert.ToInt32(Console.ReadLine());

            if(nValue > 0)
            {
                Console.WriteLine("Positive Number");
            }

            else
            {
                Console.WriteLine("Negative Number");
            }
        }
    }
}