namespace BooleanOpertion
{
    public class ConditionalOperator
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the Value X:");
            int nFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value Y:");
            int nSecond = Convert.ToInt32(Console.ReadLine());

            if(nFirst % 10 == 0 && nSecond % 10 == 0)
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False"); ;
            }
        }
    }
}