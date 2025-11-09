// accept a number from user and print even factors
internal class question13
{
    public void DisplayEvenFactors(int iNo)
    {
        if(iNo <= 0)
        {
            return;
        }
        Console.WriteLine(1);
        for(int i = 0; i <= (iNo / 2); i++)
        {   
            try
            {    
                if(((iNo % i) == 0) && ((i % 2) == 0))
                {
                    Console.WriteLine(i);
                }
            }
            catch(Exception e)
            {}
        }
    }
}