//Write a program which returns difference between Even factorial and odd factorial of given number.
internal class question35
{
    public int OddEvenFactorial(int iNo)
    {
        if(iNo == 0)
        {
            return 1;
        }

        if(iNo < 0)
        {
            iNo = -(iNo);
        }

        int iEvenFact = 1, iOddFact = 1;
        for(int i = 1; i <= iNo; i++)
        {
            if((i % 2) != 0)
            {
                iOddFact *= i;
            }
            else if((i % 2) == 0)
            {
                iEvenFact *= i;
            }
        }
        return (iEvenFact - iOddFact);
    }
}