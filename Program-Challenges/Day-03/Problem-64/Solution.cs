namespace AddDigit
{
    public class TextString
    {
        public static  int AddDigits(string strNumber)
        {
            

            int sum = 0;
            for(int i = 0; i < strNumber.Length; i++) 
            {
                if(char.IsDigit(strNumber[i])) 
                {
                    sum += strNumber[i] - '0';
                }
                
            }

            return sum;
        }
    }
}