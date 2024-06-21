namespace FunctionParams
{
    public class ParametersPassing
    {
        public static void FunctionWithParameterPassing(string strName)
        {
            Console.WriteLine($"Hello {strName}");
        }

        public static void FunctionWithOutParameterPassing()
        {
            Console.WriteLine("Good Bye!");
        }
    }
}