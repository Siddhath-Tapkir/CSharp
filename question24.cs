// Write a program which accepts N from user and print all odd numbers up to N.

internal class question24
{
    public void DisplayOddNum(int iNo)
    {
        for(int iCnt = 1; iCnt <= iNo; iCnt++)
        {
            if((iCnt % 2) != 0)
            {
                Console.Write(iCnt +" ");
            }
        }
    }
}