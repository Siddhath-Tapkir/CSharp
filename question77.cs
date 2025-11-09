/*
Write a program which accept string from user and return it inn
reverse order.
*/

public class Character
{
    private string str;

    public Character(string s)
    {
        this.str = s;
    }

    public string StrRevX()
    {
        char []str = this.str.ToCharArray();
        char []rev = new char[str.Length];
        int iStart = 0;
        int iEnd = (str.Length - 1);
        int i = 0;

        for(i = iEnd, iStart = 0; i >= 0; i--, iStart++)
        {
            rev[iStart] = str[i];
        }

        string nstr = new string(rev);

        return nstr;
    }
}

internal class question77
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character(str);

        string sRet = cobj.StrRevX();

        Console.WriteLine(sRet);
    }
}