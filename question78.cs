/*
Write a program which accept string from user and display it inn
reverse order.
*/

public class Character
{
    private string str;

    public Character(string s)
    {
        this.str = s;
    }

    public void DisplayRev()
    {
        char []str = this.str.ToCharArray();
        int iEnd = (str.Length - 1);
        int i = 0;

        for(i = iEnd; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
    }
}

internal class question78
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character(str);

        cobj.DisplayRev();

        Console.WriteLine();
    }
}