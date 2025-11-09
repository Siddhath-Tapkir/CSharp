//Input : 5
//Output : $ * $ * $ * $ * $ *

internal class question21
{
    public void DisplayPattern(int iNo)
    {
        for(int iCnt = 1; iCnt <= iNo; iCnt++)
        {
            Console.Write(" $ * ");
        }
    }
}