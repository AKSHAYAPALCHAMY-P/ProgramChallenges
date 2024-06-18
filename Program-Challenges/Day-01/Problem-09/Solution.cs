namespace Conversion
{
    public class ConversionTable
    {
        public static void ConversionTables(double dCelcius)
        {
            Console.WriteLine("Enter th Celcius value:");
            double dValue = Convert.ToDouble(dCelcius);

            double dKelvin = dCelcius + 273;
            double dFarenheit = dCelcius * 18 / 10 + 32;

            Console.WriteLine(dKelvin);
            Console.WriteLine(dFarenheit);

            

        }
    }
}