/*
Write a program which accept string from user and return
difference between frequency of small characters and frequency of
capital characters.
*/

public class Character
{
    private string str;

    public Character(string s)
    {
        this.str = s;
    }

    public int Frequency()
    {
        char []str = this.str.ToCharArray();
        int CountCap = 0, CountSm = 0;

        for(int i = 0; i < str.Length; i++)
        {
            if((str[i] >= 'a') && (str[i] <= 'z'))
            {
                CountSm++;
            }
            else if((str[i] >= 'A') && (str[i] <= 'Z'))
            {
                CountCap++;
            }
        }

        return (CountCap - CountSm);
    }
}

internal class question76
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character(str);

        int iRet = cobj.Frequency();

        Console.WriteLine(iRet);
    }
}