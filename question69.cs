//Accept Character from user and check whether the alphabet is small or not 
using System.IO;

public class CharacterX
{
    private char ch;

    public CharacterX(char c)
    {
        this.ch = c;
    }

    public bool ChkSmall()
    {
        if(((ch >= 'a') && (ch <= 'z')))
        {
            return true;
        }
        else
        {
            return false;
        }
    } 
}
public class question69
{
    static public void Main(string []A)
    {
        StreamReader srobj = new StreamReader(Console.OpenStandardInput());

        Console.WriteLine("Enter a character");

        char ch = (char)srobj.Read();

        CharacterX cobj = new CharacterX(ch);

        bool bFlag = cobj.ChkSmall();

        Console.WriteLine(bFlag);
    }
}