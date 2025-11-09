// Write a program which accept number from user and check whether it contains 0 in it or not.
public class Digits
{
    public bool ContainsZero(int iNo)
    {
        int iDigit = 0;
        while(iNo != 0)
        {
            iDigit = iNo % 10;
            if(iDigit == 0)
            {
                break;
            }
            iNo = iNo / 10;
        }
        return (iNo != 0);
    }
}

public class question42
{
    public static void Main(string []a)
    {
        Digits obj = new Digits();

        Console.WriteLine(obj.ContainsZero(09024));
    }
}