// Write a program which accept number from user and return summation of non factors
internal class question20
{
    public int SumFactorsNonFactors(int iNo)
    {
        int iFact = 0, iNonFact = 0;
        for(int iCnt = 1; iCnt < iNo; iCnt++)
        {
            if((iNo % iCnt) == 0)
            {
                iFact = iFact + iCnt;
            }
            else if(((iNo % iCnt) != 0))
            {
                iNonFact = iNonFact + iCnt;
            }
        }
        //return iNonFact - iFact;
        return iFact - iNonFact;
    }
}