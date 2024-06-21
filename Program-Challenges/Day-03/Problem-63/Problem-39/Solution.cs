using System.Diagnostics;

namespace Absolute
{
    public class AbsoluteValueFinding
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the Value:");
            int nValue = Convert.ToInt32(Console.ReadLine());

            if(nValue > 0) 
            {
                Console.WriteLine(nValue);
            }

            if(nValue < 0) 
            {
                Console.WriteLine(nValue);
            }
        }
    }
}