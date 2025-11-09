// Write a program to find odd factorial of given number.
internal class question34
{
    public int OddFactorial(int iNo)
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
            if((i % 2) != 0)
            {
                iFact *= i;
            }
        }
        return iFact;
    }
}