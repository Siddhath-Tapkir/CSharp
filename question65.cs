/*
Accept N numbers from user and accept Range, Display all elements from
that range
*/
using System.IO;
public class NNumber
{
    public void Range(int []Arr,int iStart,int iEnd)
    {
        for(int i = 0; i < Arr.Length; i++)
        {
            if(Arr[i] >= iStart && Arr[i] <= iEnd)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
}
internal class question65
{
    public static void Main(string []A)
    {
        StreamReader sobj = new StreamReader(Console.OpenStandardInput());
        Console.WriteLine("Enter size of array");

        int iSize = int.Parse(sobj.ReadLine());
        int []Arr = new int[iSize];

        Console.WriteLine("Enter elements");

        for(int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = int.Parse(sobj.ReadLine());
        }

        NNumber nobj = new NNumber();

        nobj.Range(Arr,60,90);

    }
}