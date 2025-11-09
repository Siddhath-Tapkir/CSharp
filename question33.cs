// Write a program to find even factorial of given number.
internal class question33
{
    public int EvenFactorial(int iNo)
    {
        if(iNo == 0)
        {
            return 1;
        }

        if(iNo < 0)
        {
            iNo = -(iNo);
        }

        int iFact = 1;
        for(int i = 1; i <= iNo; i++)
        {
            if((i % 2) == 0)
            {
                iFact *= i;
            }
        }
        return iFact;
    }
}