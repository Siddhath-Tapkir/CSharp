// Accept N numbers from user and accept one another number as NO ,return frequency of NO form it.
public class NNumber
{
    private int []Arr;

    public NNumber(int []Arr)
    {
        this.Arr = Arr;
    }

    public int frequency(int NO)
    {
        int iCount = 0;
        for(int i = 0; i < Arr.Length; i++)
        {
            if(Arr[i] == NO)
            {
                iCount++;
            }
        }
        return iCount;
    }
}

internal class question62
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
        iRet = obj.frequency(iNo);

        Console.WriteLine(iRet);
    }
}