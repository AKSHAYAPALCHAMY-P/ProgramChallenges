using System.Runtime.InteropServices;

namespace TwoDimensionalArrayCharacters
{
    public class CharacterArray
    {
        public static void Solution()
        {
            int row = 20;
            int col = 70;

            char[,] nNewArray = new char[row, col];
            char cLetter = 'X';

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    nNewArray[i, j] = cLetter;
                }
            }

            for(int i = 0; i < row; i++) 
            {
                for(int j = 0; j < col; j++) 
                {
                    Console.Write(cLetter);
                }
                Console.WriteLine();
            }
        }
    }
}