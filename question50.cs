// Write a program which accept number from user and return difference between
// summation of even digits and summation of odd digits.

public class Digits
{
    public int Difference(int iNo)
    {
        int CountEven = 0, CountOdd = 0, iDigit = 0;

        while(iNo != 0)
        {
            iDigit = iNo % 10;

            if((iDigit % 2) == 0)
            {
                CountEven = CountEven + iDigit;
            }
            else if((iDigit % 2) != 0)
            {
                CountOdd = CountOdd + iDigit;
            }
            iNo = iNo / 10;
        }

        return (CountEven - CountOdd);
    }
}
internal class question50
{
    public static void Main(string []A)
    {
        Console.WriteLine("Enter a number");
        int iValue = int.Parse(Console.ReadLine());

        Digits dobj = new Digits();

        Console.WriteLine(dobj.Difference(iValue));
    }
}