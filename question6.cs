// program to accept a number and print * on screen that many times (Better)
internal class question6
{
    public void PrintStar(int iNo)
    {
        if(iNo == 0)
        {
            return;
        }
        
        if(iNo < 0)
        {
            iNo = -(iNo);
        }

        int i = 0;
        i = 1;

        while(i <= iNo)
        {
            Console.Write(" * ");
            i++;
        }
    }
}