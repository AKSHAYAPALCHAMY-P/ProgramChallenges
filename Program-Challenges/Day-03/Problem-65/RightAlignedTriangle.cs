namespace Patterns
{
    public class RightAlignedTriangle
    {
        public static void Solution()
        {
             string strName = "Jonny";
             string strOutput = "";

            for(int i = strName.Length-1; i >= 0; i--)
            {
                for(int j = 1; j <= strName.Length-i; j++)
                {
                    strOutput += strName[strName.Length - j];
                }

                strOutput += "\n";
            }
                        
            Console.WriteLine(strOutput);
        }

    }
}
