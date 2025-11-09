/*
Write a program which accept string from user and count number of
small characters.
*/

public class Character
{
    private string str;

    public Character(string s)
    {
        this.str = s;
    }

    public int CountSmall()
    {
        char []str = this.str.ToCharArray();
        int iCount = 0;

        for(int i = 0; i < str.Length; i++)
        {
            if((str[i] >= 'a') && (str[i] <= 'z'))
            {
                iCount++;
            }
        }

        return iCount;
    }
}

internal class question75
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character(str);

        int iRet = cobj.CountSmall();

        Console.WriteLine(iRet);
    }
}