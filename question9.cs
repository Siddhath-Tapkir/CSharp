// accept two number from user and print the first number that many times
internal class question9
{
    public void DisplayFirstNumber(int iNo1,int iNo2)
    {
        if(iNo2 == 0)
        {
            return;
        }

        if(iNo2 < 0)
        {
            iNo2 = -(iNo2);
        }
        
        for(int i = 1; i <= iNo2; i++)
        {
            Console.WriteLine(iNo1);
        }
    }
}