namespace ReverseOrder
{
    public class ArrayInReverse
    {
        public static void ArrayReverseOrder()
        {
            Console.WriteLine("Enter the First Value:");
            int nFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Value:");
            int nSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third Value:");
            int nThird = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fourth Value:");
            int nFourth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fifth Value:");
            int nFifth = Convert.ToInt32(Console.ReadLine());

            int[] nArray = { nFirst, nSecond, nThird, nFourth, nFifth };

            int[] nReversedArray = new int[nArray.Length];

            

            for(int i =0; i < nArray.Length; i++)
            {
                nReversedArray[i] = nArray[nArray.Length-1-i];
            }

            Console.WriteLine("ReversedArray:");

            foreach(int num in nReversedArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}