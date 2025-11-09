/*
Write a program which accept string from user and display only
digits from that string.
*/

public class Character
{
    public void DisplayDigits(string str)
    {
        char []cStr = str.ToCharArray();
        int i = 0;

        for(i = 0; i < cStr.Length; i++)
        {
            if((str[i] >= '1') && (str[i] <= '9'))
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}

internal class question82
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character();

        cobj.DisplayDigits(str);

    }
}