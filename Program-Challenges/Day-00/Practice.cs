namespace Program_Challenges
{
    public static class Practice
    {
        public static void Execute()
        {
            //Console.WriteLine(5e2);

            //int i = 5;
            //for(Console.WriteLine(); Convert.ToBoolean(Convert.ToInt32(i)); Console.WriteLine(i--)) ;
            //Console.ReadLine();

            //int res;
            //string myStr = "120";
            //res = int.Parse(myStr);
            //Console.WriteLine("String is a numeric representation: " + res);

            //string var_string = "4.5";

            //Console.WriteLine(int.Parse("4") + 3);
            //Console.WriteLine(float.Parse(var_string) + 4.4f);

            //Console.WriteLine(int.Parse("Seven") + 1);


            string textExample = "Seven";
            Console.WriteLine(textExample);

            int textExampleInt;
            int.TryParse(textExample, out textExampleInt);
            // "Seven" cannot be converted to int, hence textExampleInt store 0 value.
            Console.WriteLine(textExampleInt);

            string textExample2 = "5.5";
            Console.WriteLine(textExample2);

            float textExampleFloat;
            float.TryParse(textExample2, out textExampleFloat);
            // "5.5" will be converted to float value 5.5 and stored in textExampleFloat
            Console.WriteLine(textExampleFloat);
        }
    }
}
