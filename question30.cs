// Write a program which accept number from user and display its table in reverse
internal class question30
{
    public void DisplayTableRev(int iNo)
    {
        if(iNo < 0)
        {
            iNo = -(iNo);
        }

        int iTable = iNo;

        for(int i = 10; i >= 1; i--)
        {
            Console.WriteLine(iTable * i);
        }
    }
} 