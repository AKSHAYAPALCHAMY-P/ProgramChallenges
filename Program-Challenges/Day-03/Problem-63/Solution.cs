using System;

namespace Mathematicalstatistics
{
    public class StatisticsMathematical
    {
        public static void Solution()
        {
            const int total = 1000;
            float[] numbers = new float[total];
            int nCount = 0;

            float nMaxValue = float.MinValue;
            float nMinValue = float.MaxValue;
            float nTotalValues = 0.0f;

            int nOption = 0;

            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Statistics");
                Console.WriteLine("5. Exit");

                Console.WriteLine();
                Console.Write("Enter the Option: ");
                nOption = int.Parse(Console.ReadLine());

                switch(nOption)
                {
                    case 1:
                        if(nCount < total)
                        {
                            Console.Write("Enter number to add: ");
                            float nNum = float.Parse(Console.ReadLine());
                            numbers[nCount] = nNum;

                            if(nNum > nMaxValue)
                            {
                                nMaxValue = nNum;
                            }
                            if(nNum < nMinValue)
                            {
                                nMinValue = nNum;
                            }

                            nTotalValues += nNum;
                            nCount++;
                        }
                        else
                        {
                            Console.WriteLine("The database is full.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Numbers:");
                        if(nCount > 0)
                        {
                            for(int i = 0; i < nCount; i++)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("No Data Available");
                        }
                        break;

                    case 3:
                        Console.Write("Enter the number to search: ");
                        float fSearchNumber = float.Parse(Console.ReadLine());
                        bool fFound = false;
                        if(nCount > 0)
                        {
                            for(int i = 0; i < nCount; i++)
                            {
                                if(numbers[i] == fSearchNumber)
                                {
                                    Console.WriteLine($"Number {fSearchNumber} found at index {i}");
                                    fFound = true;
                                    break;
                                }
                            }

                            if(!fFound)
                            {
                                Console.WriteLine($"Number {fSearchNumber} not found");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Data Available");
                        }
                        break;

                    case 4:
                        if(nCount > 0)
                        {
                            float fAverage = nTotalValues / nCount;

                            Console.WriteLine($"Minimum Value: {nMinValue}");
                            Console.WriteLine($"Maximum Value: {nMaxValue}");
                            Console.WriteLine($"Average Value: {fAverage}");
                            Console.WriteLine($"Total Count: {nCount}");
                        }
                        else
                        {
                            Console.WriteLine("No data Available");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program");
                        break;
                }

                Console.WriteLine();
            }
            while(nOption != 5);
        }
    }
}
