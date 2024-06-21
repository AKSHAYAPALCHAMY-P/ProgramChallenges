namespace GiveChange
{
    public class CashRegisterMaintenance
    {
        public static void Register()
        {
            Console.WriteLine("Enter the Total amount of money in the cash register:");
            int nTotal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Purchase Value:");
            int nPurchase = Convert.ToInt32(Console.ReadLine());

            int nExchange = nTotal - nPurchase;

            while(nExchange != 0)
            {
                if(nExchange >= 100)
                {
                    
                    nExchange -= 100;
                    
                    Console.WriteLine("100");
                }
                if(nExchange >= 50)
                {
                    
                    nExchange -= 50;
                    Console.WriteLine("50");
                }
                 if (nExchange >= 20)
                {
                    
                    nExchange -= 20;
                    Console.WriteLine("20");
                }
                 else if (nExchange >= 10)
                {
                    
                    nExchange -= 10;
                    Console.WriteLine("10");
                }
                 else if(nExchange >= 5)
                {
                    
                    nExchange -= 5;
                    Console.WriteLine("5");
                }
                 else if(nExchange >= 2)
                {
                    
                    nExchange -= 2;
                    Console.WriteLine("2");
                }
                 else if(nExchange >= 1)
                {
                   
                    nExchange -= 1;
                    Console.WriteLine("1");
                }

            }  
            
        }
    }
}