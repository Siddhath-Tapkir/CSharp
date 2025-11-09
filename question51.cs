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
        char a = 'A';
        for(int i = 1; i <= _iNo; i++,a++)
        {
            Console.Write(a+" ");
        }
    }
}

public class question51
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
        Console.WriteLine("Press any key to exit...");
Console.ReadKey(); // Wait so the finalizer can run
    }
}