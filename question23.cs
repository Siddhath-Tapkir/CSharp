//Input : 5
//Output : -5 -4 -3 -2 -1 0 1 2 3 4 5

internal class question23
{
    public void DisplayNumbers(int iNo)
    {
        for(int iCnt = -(iNo); iCnt <= iNo; iCnt++)
        {
            Console.Write(iCnt+" ");
        }
    }
}