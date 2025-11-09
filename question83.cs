/*
Write a program which accept string from user and count number of
white spaces
*/

public class Character
{
    public int CountSpace(string str)
    {
        char []cStr = str.ToCharArray();
        int i = 0, iCount = 0;

        for(i = 0; i < cStr.Length; i++)
        {
            if(str[i] == ' ')
            {
                iCount++;
            }
        }

        return iCount;
    }
}

internal class question83
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character();

        int iRet = cobj.CountSpace(str);

        Console.WriteLine(iRet);
    }
}