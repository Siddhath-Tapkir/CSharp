// Write a program which accept number from user and display all its non factors.
internal class question18
{
    public void DisplayNonFactors(int iNo)
    {
        for(int iCnt = 1; iCnt <= iNo; iCnt++)
        {
            if((iNo % iCnt) != 0)
            {
                Console.WriteLine(iCnt);
            }
        }
    }
}