// program to accept a number and print * on screen that many times
internal class question5
{
    public void PrintStar(int iNo)
    {
        if(iNo == 0)
        {
            return;
        }

        for(int i = 1; i <= iNo; i++)
        {
            Console.Write(" * ");
        }
    }
}