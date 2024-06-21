namespace Tables{
    public class MultipliedTables{
        public static void Multiplicationtable()
        {
            Console.WriteLine("Enter the value:");
            int nInput = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=10;i++){
                Console.WriteLine($"{nInput}*{i}={nInput * i}");
            }
        }
    }
}