//Write a program which accept number from user and return the count of even digits.
public class Digits
{
    public int CountFreq(int iNo)
    {
        int iCount = 0, iDigit = 0;

        while(iNo != 0)
        {
            iDigit = iNo % 10;
            if((iDigit % 2) == 0)
            {
                iCount++;
            }
            iNo = iNo / 10;
        }
        return iCount;
    }
}
internal class question46
{
    public static void Main(string []a)
    {
        Console.WriteLine("Enter a number");
        int iValue = int.Parse(Console.ReadLine());

        Digits obj = new Digits();

        int iRet = obj.CountFreq(iValue);

        Console.WriteLine(iRet);
    }
}