// Write a program which accept number from user and display its table.
internal class question29
{
    public void DisplayTable(int iNo)
    {
        if(iNo < 0)
        {
            iNo = -(iNo);
        }

        int iTable = iNo;

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(iTable * i);
        }
    }
} 