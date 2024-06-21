namespace CharAlphabet
{
    public class AlphabetIndex
    {
        public static void AlphabetCharacters()
        {
            char[] Characters = {'A','B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N',  'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y','Z'};

            for(int i = 0; i < Characters.Length; i++)
            {
                char c = Characters[i];
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}