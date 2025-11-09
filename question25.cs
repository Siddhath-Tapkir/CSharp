// Write a program which accept N and print first 5 multiples of N.

internal class question25
{
    public void DisplayMultiple(int iNo)
    {
        for(int iCnt = 1; iCnt <= 5; iCnt++)
        {
            Console.Write((iCnt * iNo) + " ");
        }
    }
}