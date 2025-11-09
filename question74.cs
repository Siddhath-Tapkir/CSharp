/*
1.Write a program which accept string from user and count number of
capital characters.
*/

public class Character
{
    private string str;

    public Character(string s)
    {
        this.str = s;
    }

    public int CountCapital()
    {
        char []str = this.str.ToCharArray();
        int iCount = 0;

        for(int i = 0; i < str.Length; i++)
        {
            if((str[i] >= 'A') && (str[i] <= 'Z'))
            {
                iCount++;
            }
        }

        return iCount;
    }
}

internal class question74
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character(str);

        int iRet = cobj.CountCapital();

        Console.WriteLine(iRet);
    }
}