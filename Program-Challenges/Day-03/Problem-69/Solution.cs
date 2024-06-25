using System.ComponentModel;

namespace Pyramid
{
    public class DrawAPyramid
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the text :");
            string strText = Console.ReadLine();

            if(strText.Length % 2 == 0)
            {
                strText += "";
            }

            int nPosition = strText.Length / 2; 
            int rows = strText.Length / 2 + 1;
           

            for(int i = 0; i < rows; i++)
            {

                for(int j = 0; j < nPosition; j++)
                {
                    Console.Write(" ");
                }


                for(int k = 0; k <= i * 2; k++)
                {
                    
                        int nIndex = (nPosition + k) % strText.Length;
                        Console.Write(strText[nIndex]);

                }

                Console.WriteLine();

                nPosition--;


            }
        }
    }
}