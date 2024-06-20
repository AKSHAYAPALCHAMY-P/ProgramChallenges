namespace ReversedCharacter
{
    public class Reverse
    {
        public static void CharReversed()
        {
            Console.WriteLine("Enter The First Character:");
            char a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter The Second Character:");
            char b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter The Third Character:");
            char c = Convert.ToChar(Console.ReadLine());


            Console.WriteLine($"{c} {b} {c}");
        }
    }
}