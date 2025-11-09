// accept a number from user and print even numbers that many times
internal class question11
{
    public void DisplayEven(int iNo)
    {
        if(iNo <= 0)
        {
            return;
        }

        int iValue = 0;
        iValue = 2;
        for(int i = 1; i <= iNo; i++,iValue = (iValue + 2))
        {
            Console.WriteLine(iValue);
        }
    }
}