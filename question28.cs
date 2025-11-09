// Write a program to find factorial of given number.
internal class question28
{
    public int Factorial(int iNo)
    {
        if(iNo == 0 || iNo == -0)
        {
            return 0;
        }

        if(iNo < 0)
        {
            iNo = -(iNo);
        }

        int iFact = 1, iCnt = 0;

        for(iCnt = 1; iCnt <= iNo; iCnt++)
        {
            iFact = iCnt * iFact;
        }

        return iFact;
    }
} 