namespace AccessControl
{
    public class Access
    {
        public static void ControlAccess()
        {
            const int nUserName = 12;
            const int nPassword = 1234;
            int nAttempts = 0;
            int nMaxAttempt = 3;

           

            while(nAttempts < nMaxAttempt)
            {
                Console.WriteLine("Enter the Username");
                int nLoginUserName = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the password");
                int nUserPassword = Convert.ToInt32(Console.ReadLine());

                if(nUserName != nLoginUserName && nUserPassword != nPassword)
                {
                    Console.WriteLine("lOGIN fAILED!");
                    nAttempts++;
                }


                else if(nUserName == nLoginUserName && nUserPassword == nPassword)
                {
                    
                    nAttempts++;
                }

                if(nUserName == nLoginUserName && nUserPassword == nPassword && nAttempts== nMaxAttempt)
                {
                    Console.WriteLine("Login Success");
                }



            }

            
        }
    }
}