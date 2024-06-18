namespace sphere
{
    public static class Dimensions
    {
        static double pi = 22 / 7;

        public static void Solution(double dRadius)
        {            
            double dSurface = 4 * pi * dRadius * dRadius;

            Console.WriteLine($"Surface:{dSurface}");
        }

        public static void Volume(double dRadius)
        {
            double dvolume=4.0/3.0*pi* dRadius * dRadius * dRadius;

            Console.WriteLine($"volume:{dvolume}");
        }
    }
}