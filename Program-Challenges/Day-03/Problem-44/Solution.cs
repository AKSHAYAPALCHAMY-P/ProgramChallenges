namespace Vowels
{
    public class CheckVowels
    {
        public static void Switch()
        {
            Console.WriteLine("Enter the value:");
            string? nValue = Convert.ToString(Console.ReadLine());

            nValue = nValue.ToLower();

            switch(nValue)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Is Vowel");
                    break;
                default:
                    Console.WriteLine("Other Symbol");
                    break;
            }
            
        }

    }
}