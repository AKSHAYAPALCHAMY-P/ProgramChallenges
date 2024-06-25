namespace Paralellogran
{
    public class PatternParalellogram
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the width of the paralellogram");
            int nWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Height of the paralellogram:");
            int nHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Character Value:");
            char nValue = char.Parse(Console.ReadLine());

            for(int i = 0; i < nHeight;i++) 
            {
                for(int j = 1; j < nWidth; j++)
                {
                    Console.Write(nValue);
                }
                Console.WriteLine("");


                for(int k = 0; k <= i; k++)
                {
                    Console.Write(" ");
                }
            }

        } 
    }
        
}
    
