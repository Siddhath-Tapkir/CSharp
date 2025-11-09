// Write a program which accept number from user and return multiplication of all digits.
public class Digits
{
    public int Mult(int iNo)
    {
        int iDigit = 1;

        while(iNo != 0)
        {
            iDigit *= iNo % 10;
            iNo = iNo / 10;
        }

        return iDigit;
    }
}
public class question49
{
    public static void Main(string []a)
    {
        Digits dobj = new Digits();
        Console.WriteLine("Enter a number");
        int iValue = int.Parse(Console.ReadLine());

        int iRet = dobj.Mult(iValue);

        Console.WriteLine("Multiplication of all digits is : "+iRet);
    }
}