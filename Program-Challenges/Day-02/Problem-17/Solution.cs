namespace Equivalent
{
    public class EquivalentOperations
    {
        public static void EqualOperations()
        {
            Console.WriteLine("Enter the first number:");
            int nA= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number:");
            int nB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number:");
            int nC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{(nA+nB)*nC}\n{nA*nC + nB * nC }");


        }
    }
}