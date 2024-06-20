namespace FunctionParams
{
    public class Parameters
    {
        public static void FunctionWithParameterName(string strName)
        {
            Console.WriteLine($"Hello {strName}");
        }

        public static void FunctionWithOutParameterName()
        {
            Console.WriteLine("Good Bye!");
        }
    }
}