// program to accept a number and check whether if it is divisible by 5 or not
internal class question4
{
    public bool CheckDivisibleBy5(int iNo)
    {
        if(iNo < 0)
        {
            return false;
        }

        if((iNo % 5) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}