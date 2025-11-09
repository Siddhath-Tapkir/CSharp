//Write a program which accept number from user and display its multiplication of factors.
internal class question16
{
    public void MultFact(int iNo)
    {
        int iMult = 1, iCnt = 0;
        for(iCnt = 1; iCnt <= (iNo / 2); iCnt++)
        {
            if((iNo % iCnt) == 0)
            {
                iMult = iMult * iCnt;
            }
        }
        Console.WriteLine(iMult);
    }
}