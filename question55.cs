public class Pattern
{
    private int _iNo;

    public Pattern(int iVal)
    {
        this._iNo = iVal;
    }

    ~Pattern()
    {
        Console.WriteLine("Inside finalize");
    }

    public void DisplayPattern()
    { 
        int j = 2;
        for(int i = 1; i <= _iNo; i++)
        {
            Console.WriteLine(j);

            j = j + 2;
        }
    }
}

public class question52
{
    public static void Main(string []A)
    {
        Console.WriteLine("Enter a number");
        int iValue = Int32.Parse(Console.ReadLine());

        Pattern pobj = new Pattern(iValue);

        pobj.DisplayPattern();

        pobj = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}