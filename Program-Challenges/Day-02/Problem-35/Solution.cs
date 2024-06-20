namespace Switch
{
    public class GradeCalculation
    {
        public static void StudentGrade()
        {
            Console.WriteLine("Enter Your Score:");
            int nScore = Convert.ToInt32(Console.ReadLine());

            switch(nScore)
            {
                case 10:
                    Console.WriteLine("A+");
                    break;

                case 9:
                    Console.WriteLine("A");
                    break;

                case 7:
                    Console.WriteLine("B");
                    break;

                case 8:
                    Console.WriteLine("B");
                    break;

                case 6:
                    Console.WriteLine("C");
                    break;

                case 5:
                    Console.WriteLine("E");
                    break;

                default:
                    Console.WriteLine("F");
                    break;




            }
        }
    }
}