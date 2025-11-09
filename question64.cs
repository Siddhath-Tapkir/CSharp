/*
Accept N numbers from user and return product of all odd elements.
*/
public class NNumber
{
    private int []Arr;

    public NNumber(int []Arr)
    {
        this.Arr = Arr;
    }

    public int DiffOdd()
    {
        int iDifference = 1;
        for(int i = 0; i < Arr.Length; i++)
        {
            if((Arr[i] % 2) != 0)
            {
                iDifference = iDifference * Arr[i];
            }
        }
        return iDifference;
    }
}

internal class question64
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

        NNumber obj = new NNumber(Arr);
        int iRet = 0;
        iRet = obj.DiffOdd();

        Console.WriteLine("Odd difference is : "+iRet);
    }
}