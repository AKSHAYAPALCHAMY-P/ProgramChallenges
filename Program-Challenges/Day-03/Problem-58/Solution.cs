namespace ArrayOfIntegers
{
    public class ArrayIntegervalues
    {
        public static void Solution()
        {
            Console.WriteLine("Emter the Size of an Array:");
            int nSize = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[nSize];

            Console.WriteLine($"Enter {nSize} Values to The Array:");

            for (int i = 0; i < nSize; i++) 
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("");

            for(int i = 0; i < nSize; i++) 
            {
                if(nums[i] % 2 == 0)
                {
                    Console.WriteLine(nums[i]);
                }

            }


        }



    }
}
