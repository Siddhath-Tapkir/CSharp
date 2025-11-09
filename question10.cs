// accept a number from user and check wheather it is odd or even
internal class question10
{
    public bool CheckOddEven(int iNo) // true = if the number is even, odd = if the number is odd
    {
        if(iNo == 0)
        {
            return false;
        }

        if(iNo < 0)
        {
            iNo = -(iNo);
        }
        
        return ((iNo % 2) == 0);
    }
}