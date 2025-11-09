// Accept N numbers from user and display all such elements which are multiples of 11.
public class NNumber
{
    private int []Arr;

    public NNumber(int []Arr)
    {
        this.Arr = Arr;
    }

    public void Display()
    {
        for(int i = 0; i < Arr.Length; i++)
        {
            if((Arr[i] % 11) == 0)
            {
                Console.Write(Arr[i]+"\t");
            }
        }
    }
}

internal class question61
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

        obj.Display();

        Console.WriteLine();
    }
}