//Write a program which accept number from user and display its factors in decreasing order.
internal class question17
{
    public void RevFactors(int iNo)
    {
        int iCnt = 0;
        for(iCnt = (iNo / 2); iCnt >= 1; iCnt--)
        {
            if((iNo % iCnt) == 0)
            {
                Console.WriteLine(iCnt);
            }
        }
    }
}