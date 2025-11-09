// Write a program which accept number from user and return summation of non factors
internal class question19
{
    public int SumNonFactors(int iNo)
    {
        int iSum = 0;
        for(int iCnt = 1; iCnt <= iNo; iCnt++)
        {
            if((iNo % iCnt) != 0)
            {
                iSum = iSum + iCnt;
            }
        }
        return iSum;
    }
}