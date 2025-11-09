// Accept N numbers from user and return difference between summation
// of even elements and summation of odd elements.

public class NNumber
{
    private int []Arr;

    public NNumber(int []Arr)
    {
        this.Arr = Arr;
    }

    public int Difference()
    {
        int EvenSum = 0, OddSum = 0;

        for(int i = 0; i < Arr.Length; i++)
        {
            if((Arr[i] % 2) == 0)
            {
                EvenSum = EvenSum + Arr[i];
            }
            else if((Arr[i] % 2) != 0)
            {
                OddSum = OddSum + Arr[i];
            }
        }

        //return (OddSum - EvenSum);
        return (EvenSum - OddSum);
    }
}

internal class question57
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

        iSize = obj.Difference();

        Console.WriteLine(iSize);
    }
}