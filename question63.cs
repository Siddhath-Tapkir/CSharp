/*
Accept N numbers from user and accept one another number as NO ,
return index of last occurrence of that NO.
*/
public class NNumber
{
    private int []Arr;

    public NNumber(int []Arr)
    {
        this.Arr = Arr;
    }

    public int LastOcc(int NO)
    {
        int iCount = 0;
        for(int i = 0; i < Arr.Length; i++)
        {
            if(Arr[i] == NO)
            {
                iCount = i;
            }
        }
        return iCount;
    }
}

internal class question63
{
    static public void Main(string []a)
    {
        int iSize = 0;
        Console.WriteLine("Enter size of array");
        iSize = int.Parse(Console.ReadLine());

        int []Arr = new int[iSize];

        Console.WriteLine("Enter the elements");
        for(int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter a number to find it");
        int iNo = int.Parse(Console.ReadLine());

        NNumber obj = new NNumber(Arr);
        int iRet = 0;
        iRet = obj.LastOcc(iNo);

        Console.WriteLine("Last Occurence is : "+iRet);
    }
}