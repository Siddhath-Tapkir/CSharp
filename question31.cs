//Input : 5
//Output : * * * * * # # # # #
internal class question31
{
    public void DisplayPattern(int iNo)
    {
        for(int i = 1; i < (iNo * 2); i++)
        {
            if(i < iNo)
            {
                Console.Write(" * ");
            }
            else
            {
                Console.Write(" # ");
            }
        }
    }
}