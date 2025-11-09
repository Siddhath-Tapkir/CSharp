//Write a program which accept number from user and display its digits in reverse order.
public class RevDigits
{
    public void ReverseDigits(int iNo)
    {
        int iDigit = 0;
        while(iNo != 0)
        {
            iDigit = iNo % 10;
            Console.WriteLine(iDigit);
            iNo = iNo / 10;
        }
    }
}

public class question41
{
    public static void Main(string []a)
    {
        RevDigits obj = new RevDigits();

        obj.ReverseDigits(673);
    }
}