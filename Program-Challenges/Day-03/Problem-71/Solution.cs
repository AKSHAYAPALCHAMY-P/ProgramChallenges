namespace ModifyCharacter
{
    public class CharacterModification
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the text String:");
            string strWord = Console.ReadLine();

            Console.WriteLine("Enter the Position for delete:");
            bool bIsSuccess = int.TryParse(Console.ReadLine(), out int n);

            Console.WriteLine("Enter the letter for replace:");
            char cLetter = Convert.ToChar(Console.ReadLine());

           
            string strChangedString = ChangeLetter(strWord, n, cLetter);
            Console.WriteLine(strChangedString);




        }

        public static string ChangeLetter(string strWord, int nPosition, char cLetter)
        {
            char[] charArray = strWord.ToCharArray();
            charArray[nPosition] = cLetter;
            return new string(charArray);
        }
    }
}