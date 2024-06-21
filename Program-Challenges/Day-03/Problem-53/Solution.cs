namespace NestedConditionaloperator
{
    public class ConditionalOperation
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the X Number:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y Number");
            int nY = Convert.ToInt32(Console.ReadLine());

            int nCount = 0;

            for(int i = nX; i < nY; i++) 
            {
                if(i > 0)
                {
                    nCount++;
                    
                }

            }
            Console.WriteLine(nCount);
        }
    }
}